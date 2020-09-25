using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppCore.Models;

namespace AppCore.Interfaces
{
    public interface ITourRepos : IRepository<Tour>
    {
        ///manage tourdetails
        Task<IList<TourDetail>> GetTourDetailsByTourId(int tourId);
        Task UpdateTourDetails(IList<TourDetail> dets);
        Task RemoveAllTourDetails(int tourId);


        //manage prices
        Task<IList<Price>> GetPricesByTourId(int tourId);

        Task<Price> GetPrice(int tourId, int priceId);
        Task<Price> AddPrice(int tourId, Price price);
        Task DisablePrice(int tourId, int priceId);
        Task ActivatePrice(int tourId, int priceId);


    }
}
