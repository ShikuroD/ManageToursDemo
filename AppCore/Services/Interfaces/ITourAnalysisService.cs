using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public interface ITourAnalysisService : IService<Tour>
    {
        void AnalyzeGroups(IList<Group> groups);
        void AnalyzeTour(Tour tour);

        bool CanEmployeeBeAdded(int empId, DateTime start, DateTime end);
        bool CanCustomerBeAdded(int cusId, DateTime start, DateTime end);

        void FilterEmployeeByDate(IList<Employee> emps, DateTime from, DateTime to);

    }
}
