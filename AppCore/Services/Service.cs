using AppCore.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class Service<Entity, Dto, SaveDto> : IService<Entity, Dto, SaveDto>
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;
        public Service(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Dto toDto(Entity entity)
        {
            return _mapper.Map<Entity, Dto>(entity);
        }

        public IList<Dto> toDtoRange(IList<Entity> entities)
        {
            return _mapper.Map<IList<Entity>, IList<Dto>>(entities);
        }

        public Entity toEntity(SaveDto save)
        {
            return _mapper.Map<SaveDto, Entity>(save);
        }

        public IList<Entity> toEntityRange(IList<SaveDto> dtos)
        {
            return _mapper.Map<IList<SaveDto>, IList<Entity>>(dtos);
        }

        public void convertEntityToDto(Entity entity, Dto dto)
        {
            _mapper.Map<Entity, Dto>(entity, dto);
        }
        public void convertDtoToEntity(SaveDto save, Entity entity)
        {
            _mapper.Map<SaveDto, Entity>(save, entity);
        }

        public async Task<int> CompleteAsync()
        {
            return await _unitOfWork.CompleteAsync();
        }
    }
}
