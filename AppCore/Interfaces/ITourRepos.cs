using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Models;

namespace AppCore.Interfaces
{
    public interface ITourRepos : IRepository<Tour>
    {
        ///manage tourdetails
        IList<TourDetail> GetTourDetailsByTourId(int tourId);
        void UpdateTourDetails(IList<TourDetail> dets);
        void RemoveAllTourDetails(int tourId);


        //manage prices
        IList<Price> GetPricesByTourId(int tourId);

        Price GetPrice(int tourId, int priceId);
        Price AddPrice(int tourId, Price price);
        void DisablePrice(int tourId, int priceId);
        void ActivatePrice(int tourId, int priceId);


    }
}
