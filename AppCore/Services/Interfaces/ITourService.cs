using AppCore.DTOs;
using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public interface ITourService : IService<Tour, TourDTO, TourDTO>
    {
        //tours root
        Task<IList<TourDTO>> GetAll();
        Task<TourDTO> GetBy(int id);
        Task<TourDTO> Add(TourDTO entity);
        Task Update(TourDTO entity);
        Task Delete(TourDTO entity);

        Task Activate(TourDTO entity);

        Task Disable(TourDTO entity);

        //dependent entities
        Task<IList<TourDetailDTO>> GetTourDetailsByTourId(int tourId);
        Task UpdateTourDetails(IList<TourDetailDTO> dets);
        Task RemoveAllTourDetails(int tourId);


        //manage prices
        Task<IList<PriceDTO>> GetPricesByTourId(int tourId);

        Task<PriceDTO> GetPrice(int tourId, int priceId);
        Task<PriceDTO> AddPrice(int tourId, PriceDTO price);
        Task DisablePrice(int tourId, int priceId);
        Task ActivatePrice(int tourId, int priceId);
    }
}
