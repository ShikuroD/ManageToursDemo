using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Models;

namespace AppCore.Interfaces
{
    public partial interface ITourRepos : IRepository<Tour>
    {

        ///manage tourdetails
        IList<TourDetail> GetTourDetailsByTourId(int tourId);
        void UpdateTourDetails(IList<TourDetail> dets);
        void RemoveAllTourDetails(int tourId);


        //manage prices
        IList<Price> GetPricesByTourId(int tourId, STATUS status = STATUS.ALL);

        Price GetPrice(int tourId, int priceId);
        Price AddPrice(int tourId, Price price);
        void DisablePrice(int tourId, int priceId);
        void ActivatePrice(int tourId, int priceId);


        //manage groups
        IList<Group> GetGroupsByTourId(int tourId, STATUS status = STATUS.ALL);

        Group GetGroup(int tourId, int groupId);
        Group AddGroup(int tourId, Group group);
        void DeleteGroup(Group group);
        void UpdateGroup(Group group);
        void DisableGroup(int tourId, int groupId);
        void ActivateGroup(int tourId, int groupId);
    }
}
