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
        public TourTypeService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }
        public async Task<IList<TourTypeDTO>> GetAll()
        {
            return toDtoRange(await _unitOfWork.TourTypes.GetAll());
        }
        public async Task<TourTypeDTO> GetBy(int id)
        {
            return toDto(await _unitOfWork.TourTypes.GetBy(id));
        }
        public async Task<TourTypeDTO> Add(TourTypeDTO entity)
        {
            return toDto(await _unitOfWork.TourTypes.Add(toEntity(entity)));
        }
        public async Task Update(TourTypeDTO entity)
        {
            await _unitOfWork.TourTypes.Update(toEntity(entity));
        }
        public async Task Delete(TourTypeDTO entity)
        {
            await _unitOfWork.TourTypes.Delete(toEntity(entity));
        }

        public async Task Activate(TourTypeDTO entity)
        {
            await _unitOfWork.TourTypes.Activate(toEntity(entity));
        }

        public async Task Disable(TourTypeDTO entity)
        {
            await _unitOfWork.TourTypes.Disable(toEntity(entity));
        }
    }
}
