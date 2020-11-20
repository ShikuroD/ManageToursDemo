using AppCore.Models;
using AppCore.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AppCore.Services
{
    public class TourAnalysisService : Service<Tour>, ITourAnalysisService
    {
        public TourAnalysisService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }
        public void AnalyzeGroups(IList<Group> groups)
        {
            foreach(Group t in groups)
            {
                var dets = _unitOfWork.Tours.GetGroupDetailsByGroupId(t);
                var atts = _unitOfWork.Tours.GetAttendantsByGroupId(t);
                var costs = _unitOfWork.Tours.GetCostsByGroupId(t);

                t.GroupDetailsCount = dets == null ? 0 : dets.Count;
                t.AttendantsCount = atts == null ? 0 : atts.Count;
                t.PriceSum = t.GroupDetailsCount * t.Price;

                t.CostSum = 0;
                foreach(Cost c in costs)
                {
                    t.CostSum += c.Value;
                }
                t.Revenue = t.PriceSum - t.CostSum;
            }
        }
        public void AnalyzeTour(Tour tour)
        {
            tour.SumRevenue = 0;
            tour.SumPrice = 0;
            tour.SumCost = 0;
            foreach (Group g in tour.Groups)
            {
                tour.SumRevenue += g.Revenue;
                tour.SumCost += g.CostSum;
                tour.SumPrice += g.PriceSum;
            }
        }
        public bool CanEmployeeBeAdded(int empId, DateTime start, DateTime end)
        {
            var groups = _unitOfWork.Tours.GetAllGroups().Select(m => m.Clone());
            groups = groups.Where(m => (DateTime.Compare(m.StartDate, start) >= 0 && DateTime.Compare(m.StartDate, end) <= 0)
                                    || (DateTime.Compare(m.EndDate, start) >= 0 && DateTime.Compare(m.EndDate, end) <= 0)
                                    || (DateTime.Compare(m.StartDate, start) < 0 && DateTime.Compare(m.EndDate, end) > 0)).ToList();
            foreach(Group g in groups)
            {
                var atts = _unitOfWork.Tours.GetAttendantsByGroupId(g);
                if (atts.Select(m => m.EmployeeId).Contains(empId)) return false;
            }
            return true;
        }
        public bool CanCustomerBeAdded(int cusId, DateTime start, DateTime end)
        {
            var groups = _unitOfWork.Tours.GetAllGroups().Select(m => m.Clone());
            groups = groups.Where(m => (DateTime.Compare(m.StartDate, start) >= 0 && DateTime.Compare(m.StartDate, end) <= 0)
                                    || (DateTime.Compare(m.EndDate, start) >= 0 && DateTime.Compare(m.EndDate, end) <= 0)
                                    || (DateTime.Compare(m.StartDate, start) < 0 && DateTime.Compare(m.EndDate, end) > 0)).ToList();
            foreach (Group g in groups)
            {
                var atts = _unitOfWork.Tours.GetGroupDetailsByGroupId(g);
                if (atts.Select(m => m.CustomerId).Contains(cusId)) return false;
            }
            return true;
        }
        
        public void FilterEmployeeByDate(IList<Employee> emps, DateTime start, DateTime end)
        {
            foreach(Employee e in emps)
            {
                e.TurnCount = 0;
                var groups = _unitOfWork.Tours.GetAllGroups().Select(m => m.Clone());
                groups = groups.Where(m => (DateTime.Compare(start, m.StartDate) >= 0 && DateTime.Compare(start, m.EndDate) <= 0)
                                        || (DateTime.Compare(end, m.StartDate) >= 0 && DateTime.Compare(end, m.EndDate) <= 0)
                                        || (DateTime.Compare(start, m.StartDate) < 0 && DateTime.Compare(end, m.EndDate) > 0)).ToList();
                foreach (Group g in groups)
                {
                    var atts = _unitOfWork.Tours.GetAttendantsByGroupId(g);
                    if (atts.Select(m => m.EmployeeId).Contains(e.Id)) e.TurnCount++;
                }
            }
        }
    }
}
