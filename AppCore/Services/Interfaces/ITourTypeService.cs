using AppCore.DTOs;
using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public interface ITourTypeService : IService<TourType, TourTypeDTO, TourTypeDTO>
    {
        Task<IList<TourTypeDTO>> GetAll();
        Task<TourTypeDTO> GetBy(int id);
        Task<TourTypeDTO> Add(TourTypeDTO entity);
        Task Update(TourTypeDTO entity);
        Task Delete(TourTypeDTO entity);

        Task Activate(TourTypeDTO entity);

        Task Disable(TourTypeDTO entity);
    }
}
