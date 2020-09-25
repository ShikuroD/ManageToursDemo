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
    class LocationService : Service<Location, LocationDTO, LocationDTO>, ILocationService
    {
        public LocationService(IUnitOfWork _unitOfWork, IMapper _mapper) : base(_unitOfWork, _mapper)
        {

        }

        public async Task<IEnumerable<LocationDTO>> GetAll()
        {
            return toDtoRange(await unitOfWork.Locations.GetAll());
        }
        public async Task<LocationDTO> GetBy(int id)
        {
            return toDto(await unitOfWork.Locations.GetBy(id));
        }
        public async Task<LocationDTO> Add(LocationDTO entity)
        {
            return toDto(await unitOfWork.Locations.Add(toEntity(entity)));
        }
        public async Task Update(LocationDTO entity)
        {
            await unitOfWork.Locations.Update(toEntity(entity));
        }
        public async Task Delete(LocationDTO entity)
        {
            await unitOfWork.Locations.Delete(toEntity(entity));
        }

        public async Task Activate(LocationDTO entity)
        {
            await unitOfWork.Locations.Activate(toEntity(entity));
        }

        public async Task Disable(LocationDTO entity)
        {
            await unitOfWork.Locations.Disable(toEntity(entity));
        }
    }
}
