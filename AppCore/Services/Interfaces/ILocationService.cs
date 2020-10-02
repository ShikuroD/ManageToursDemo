using AppCore.DTOs;
using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public interface ILocationService : IService<Location, LocationDTO, LocationDTO>
    {
        Task<IList<LocationDTO>> GetAll();
        Task<LocationDTO> GetBy(int id);
        Task<LocationDTO> Add(LocationDTO entity);
        Task Update(LocationDTO entity);
        Task Delete(LocationDTO entity);

        Task Activate(LocationDTO entity);

        Task Disable(LocationDTO entity);
    }
}
