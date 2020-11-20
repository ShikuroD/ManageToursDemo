using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    partial interface ITourRepos
    {
        //manage groupDetails
        IList<GroupDetail> GetGroupDetailsByGroupId(Group group, STATUS status = STATUS.ALL);
        GroupDetail GetGroupDetail(Group group, int groupDetailId);
        GroupDetail AddGroupDetail(Group group, GroupDetail groupDetail);
        void DeleteGroupDetail(Group group, GroupDetail groupDetail);
        void UpdateGroupDetail(Group group, GroupDetail groupDetail);

        //___________________________________________________________________________________
        //manage attendants
        IList<Attendant> GetAllAttendants();
        IList<Attendant> GetAttendantsByGroupId(Group group, STATUS status = STATUS.ALL);
        Attendant GetAttendant(Group group, int attendantId);
        Attendant AddAttendant(Group group, Attendant attendant);
        void DeleteAttendant(Group group, Attendant attendant);
        void UpdateAttendant(Group group, Attendant attendant);

        //___________________________________________________________________________________
        //manage costs
        IList<Cost> GetCostsByGroupId(Group group, STATUS status = STATUS.ALL);
        Cost GetCost(Group group, int costId);
        Cost AddCost(Group group, Cost cost);
        void DeleteCost(Group group, Cost cost);
        void UpdateCost(Group group, Cost cost);
    }
}
