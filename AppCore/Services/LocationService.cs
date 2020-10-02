using AppCore.DTOs;
using AppCore.Interfaces;
using AppCore.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class LocationService : Service<Location, LocationDTO, LocationDTO>, ILocationService
    {
        public LocationService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public async Task<IList<LocationDTO>> GetAll()
        {
            return toDtoRange(await _unitOfWork.Locations.GetAll());
        }
        public async Task<LocationDTO> GetBy(int id)
        {
            return toDto(await _unitOfWork.Locations.GetBy(id));
        }
        public async Task<LocationDTO> Add(LocationDTO entity)
        {
            return toDto(await _unitOfWork.Locations.Add(toEntity(entity)));
        }
        public async Task Update(LocationDTO entity)
        {
            await _unitOfWork.Locations.Update(toEntity(entity));
        }
        public async Task Delete(LocationDTO entity)
        {
            await _unitOfWork.Locations.Delete(toEntity(entity));
        }

        public async Task Activate(LocationDTO entity)
        {
            await _unitOfWork.Locations.Activate(toEntity(entity));
        }

        public async Task Disable(LocationDTO entity)
        {
            await _unitOfWork.Locations.Disable(toEntity(entity));
        }
    }
}
