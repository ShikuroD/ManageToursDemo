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
    public class TourService : Service<Tour, TourDTO, TourDTO>, ITourService
    {
        public TourService(IUnitOfWork _unitOfWork, IMapper _mapper) : base(_unitOfWork, _mapper)
        {
            
        }

        public async Task<IEnumerable<TourDTO>> GetAll()
        {
            return toDtoRange(await unitOfWork.Tours.GetAll());
        }
        public async Task<TourDTO> GetBy(int id)
        {
            return toDto(await unitOfWork.Tours.GetBy(id));
        }
        public async Task<TourDTO> Add(TourDTO entity)
        {
            return toDto(await unitOfWork.Tours.Add(toEntity(entity)));
        }
        public async Task Update(TourDTO entity)
        {
            await unitOfWork.Tours.Update(toEntity(entity));
        }
        public async Task Delete(TourDTO entity)
        {
            await unitOfWork.Tours.Delete(toEntity(entity));
        }

        public async Task Activate(TourDTO entity)
        {
            await unitOfWork.Tours.Activate(toEntity(entity));
        }

        public async Task Disable(TourDTO entity)
        {
            await unitOfWork.Tours.Disable(toEntity(entity));
        }
    }
}
