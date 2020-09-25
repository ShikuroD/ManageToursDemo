using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public interface IService<Entity, Dto, SaveDto>
    {
        Dto toDto(Entity entity);
        IEnumerable<Dto> toDtoRange(IEnumerable<Entity> entities);

        Entity toEntity(SaveDto save);
        IEnumerable<Entity> toEnityRange(IEnumerable<SaveDto> entites);
        void convertEntityToDto(Entity entity, Dto dto);
        void convertDtoToEntity(SaveDto dto, Entity entity);

        Task<int> CompleteAsync();
    }
}
