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
        Task<IEnumerable<TourDTO>> GetAll();
        Task<TourDTO> GetBy(int id);
        Task<TourDTO> Add(TourDTO entity);
        Task Update(TourDTO entity);
        Task Delete(TourDTO entity);

        Task Activate(TourDTO entity);

        Task Disable(TourDTO entity);
    }
}
