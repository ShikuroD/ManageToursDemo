using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppCore;
using AppCore.Interfaces;
using AppCore.Models;

namespace Infrastructure.Repos
{
    public class TourTypeRepos : Repository<TourType>, ITourTypeRepos
    {
        private readonly ManageToursContext _context;
        public TourTypeRepos(ManageToursContext context) : base(context)
        {
            _context = context;
        }


        public new async Task Activate(TourType entity)
        {
            await this.UpdateStatus(entity, STATUS.AVAILABLE);
        }

        public new async Task Disable(TourType entity)
        {
            await this.UpdateStatus(entity, STATUS.DISABLED);
        }

        private async Task UpdateStatus(TourType entity, STATUS status)
        {
            entity.Status = status;
            await this.Update(entity);
        }
    }
}
