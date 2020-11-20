using AppCore;
using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Infrastructure.Repos
{
    partial class TourRepos
    {
        //manage groupDetails
        public IList<GroupDetail> GetGroupDetailsByGroupId(Group group, STATUS status = STATUS.ALL)
        {
            return _context.GroupDetails.Where(m => m.GroupId.Equals(group.Id)).ToList();
        }

        public GroupDetail GetGroupDetail(Group group, int groupDetailId)
        {
            var groups = this.GetGroupDetailsByGroupId(group);
            if (groups == null || !groups.Any())
            {
                return null;
            }
            return groups.Where(m => m.Id.Equals(groupDetailId)).FirstOrDefault();

        }
        public GroupDetail AddGroupDetail(Group group, GroupDetail groupDetail)
        {
            if (group != null && group.Id.Equals(groupDetail.GroupId))
            {
                var tracked = _context.Set<GroupDetail>().Add(groupDetail);
                _context.SaveChanges();
                return tracked.Entity;
            }
            return null;
        }
        public void DeleteGroupDetail(Group group, GroupDetail groupDetail)
        {
            if (group == null || !group.Id.Equals(groupDetail.GroupId)) return;
            _context.Set<GroupDetail>().Remove(groupDetail);
            _context.SaveChanges();
        }
        public void UpdateGroupDetail(Group group, GroupDetail groupDetail)
        {
            if (group == null || !group.Id.Equals(groupDetail.GroupId)) return;
            _context.Set<GroupDetail>().Update(groupDetail);
            _context.SaveChanges();
        }



        //manage attendants
        public IList<Attendant> GetAllAttendants()
        {
            return _context.Attendants.ToList();
        }
        public IList<Attendant> GetAttendantsByGroupId(Group group, STATUS status = STATUS.ALL)
        {
            return _context.Attendants.Where(m => m.GroupId.Equals(group.Id)).ToList();
        }

        public Attendant GetAttendant(Group group, int attendantId)
        {
            var groups = this.GetAttendantsByGroupId(group);
            if (groups == null || !groups.Any())
            {
                return null;
            }
            return groups.Where(m => m.Id.Equals(attendantId)).FirstOrDefault();

        }
        public Attendant AddAttendant(Group group, Attendant attendant)
        {
            if (group != null && group.Id.Equals(attendant.GroupId))
            {
                var tracked = _context.Set<Attendant>().Add(attendant);
                _context.SaveChanges();
                return tracked.Entity;
            }
            return null;
        }
        public void DeleteAttendant(Group group, Attendant attendant)
        {
            if (group == null || !group.Id.Equals(attendant.GroupId)) return;
            _context.Set<Attendant>().Remove(attendant);
            _context.SaveChanges();
        }
        public void UpdateAttendant(Group group, Attendant attendant)
        {
            if (group == null || !group.Id.Equals(attendant.GroupId)) return;
            _context.Set<Attendant>().Update(attendant);
            _context.SaveChanges();
        }


        //manage costs
        public IList<Cost> GetCostsByGroupId(Group group, STATUS status = STATUS.ALL)
        {
            return _context.Costs.Where(m => m.GroupId.Equals(group.Id)).ToList();
        }

        public Cost GetCost(Group group, int costId)
        {
            var groups = this.GetCostsByGroupId(group);
            if (groups == null || !groups.Any())
            {
                return null;
            }
            return groups.Where(m => m.Id.Equals(costId)).FirstOrDefault();

        }
        public Cost AddCost(Group group, Cost cost)
        {
            if (group != null && group.Id.Equals(cost.GroupId))
            {
                var tracked = _context.Set<Cost>().Add(cost);
                _context.SaveChanges();
                return tracked.Entity;
            }
            return null;
        }
        public void DeleteCost(Group group, Cost cost)
        {
            if (group == null || !group.Id.Equals(cost.GroupId)) return;
            _context.Set<Cost>().Remove(cost);
            _context.SaveChanges();
        }
        public void UpdateCost(Group group, Cost cost)
        {
            if (group == null || !group.Id.Equals(cost.GroupId)) return;
            _context.Set<Cost>().Update(cost);
            _context.SaveChanges();
        }
    }
}
