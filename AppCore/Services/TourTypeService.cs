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
    public class TourTypeService : Service<TourType, TourTypeDTO, TourTypeDTO>, ITourTypeService
    {
        public TourTypeService(IUnitOfWork _unitOfWork, IMapper _mapper) : base(_unitOfWork, _mapper)
        {

        }
        public async Task<IEnumerable<TourTypeDTO>> GetAll()
        {
            return toDtoRange(await unitOfWork.TourTypes.GetAll());
        }
        public async Task<TourTypeDTO> GetBy(int id)
        {
            return toDto(await unitOfWork.TourTypes.GetBy(id));
        }
        public async Task<TourTypeDTO> Add(TourTypeDTO entity)
        {
            return toDto(await unitOfWork.TourTypes.Add(toEntity(entity)));
        }
        public async Task Update(TourTypeDTO entity)
        {
            await unitOfWork.TourTypes.Update(toEntity(entity));
        }
        public async Task Delete(TourTypeDTO entity)
        {
            await unitOfWork.TourTypes.Delete(toEntity(entity));
        }

        public async Task Activate(TourTypeDTO entity)
        {
            await unitOfWork.TourTypes.Activate(toEntity(entity));
        }

        public async Task Disable(TourTypeDTO entity)
        {
            await unitOfWork.TourTypes.Disable(toEntity(entity));
        }
    }
}
