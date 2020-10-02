using AppCore.DTOs;
using AppCore.Interfaces;
using AppCore.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class TourService : Service<Tour, TourDTO, TourDTO>, ITourService
    {
        public TourService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            
        }

        public async Task<IList<TourDTO>> GetAll()
        {
            return toDtoRange(await _unitOfWork.Tours.GetAll());
        }
        public async Task<TourDTO> GetBy(int id)
        {
            return toDto(await _unitOfWork.Tours.GetBy(id));
        }
        public async Task<TourDTO> Add(TourDTO entity)
        {
            return toDto(await _unitOfWork.Tours.Add(toEntity(entity)));
        }
        public async Task Update(TourDTO entity)
        {
            await _unitOfWork.Tours.Update(toEntity(entity));
        }
        public async Task Delete(TourDTO entity)
        {
            await _unitOfWork.Tours.Delete(toEntity(entity));
        }

        public async Task Activate(TourDTO entity)
        {
            await _unitOfWork.Tours.Activate(toEntity(entity));
        }

        public async Task Disable(TourDTO entity)
        {
            await _unitOfWork.Tours.Disable(toEntity(entity));
        }


        ///
        ///dependent entities
        ///
        public async Task<IList<TourDetailDTO>> GetTourDetailsByTourId(int tourId)
        {
            return toTourDetailDTORange(await _unitOfWork.Tours.GetTourDetailsByTourId(tourId));
        }
        public async Task UpdateTourDetails(IList<TourDetailDTO> dets)
        {
            await _unitOfWork.Tours.UpdateTourDetails(toTourDetailRange(dets));
        }
        public async Task RemoveAllTourDetails(int tourId)
        {
            await _unitOfWork.Tours.RemoveAllTourDetails(tourId);
        }


        //manage prices
        public async Task<IList<PriceDTO>> GetPricesByTourId(int tourId)
        {
            return toPriceDTORange( await _unitOfWork.Tours.GetPricesByTourId(tourId));
        }

        public async Task<PriceDTO> GetPrice(int tourId, int priceId)
        {
            return toPriceDTO(await _unitOfWork.Tours.GetPrice(tourId, priceId));
        }
        public async Task<PriceDTO> AddPrice(int tourId, PriceDTO price)
        {
            return toPriceDTO(await _unitOfWork.Tours.AddPrice(tourId, this.toPrice(price)));
        }
        public async Task DisablePrice(int tourId, int priceId)
        {
            await _unitOfWork.Tours.DisablePrice(tourId, priceId);
        }
        public async Task ActivatePrice(int tourId, int priceId)
        {
            await _unitOfWork.Tours.ActivatePrice(tourId, priceId);
        }


        //sub mappers
        public TourDetailDTO toTourDetailDTO(TourDetail entity)
        {
            return _mapper.Map<TourDetail, TourDetailDTO>(entity);
        }

        public IList<TourDetailDTO> toTourDetailDTORange(IList<TourDetail> entities)
        {
            return _mapper.Map<IList<TourDetail>, IList<TourDetailDTO>>(entities);
        }

        public TourDetail toTourDetail(TourDetailDTO dto)
        {
            return _mapper.Map<TourDetailDTO, TourDetail>(dto);
        }

        public IList<TourDetail> toTourDetailRange(IList<TourDetailDTO> dtos)
        {
            return _mapper.Map<IList<TourDetailDTO>, IList<TourDetail>>(dtos);
        }

        public PriceDTO toPriceDTO(Price entity)
        {
            return _mapper.Map<Price, PriceDTO>(entity);
        }

        public IList<PriceDTO> toPriceDTORange(IList<Price> entities)
        {
            return _mapper.Map<IList<Price>, IList<PriceDTO>>(entities);
        }

        public Price toPrice(PriceDTO dto)
        {
            return _mapper.Map<PriceDTO, Price>(dto);
        }

        public IList<Price> toPriceRange(IList<PriceDTO> dtos)
        {
            return _mapper.Map<IList<PriceDTO>, IList<Price>>(dtos);
        }
    }
}
