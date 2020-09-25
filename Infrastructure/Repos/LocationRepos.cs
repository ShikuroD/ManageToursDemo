using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppCore;
using AppCore.Interfaces;
using AppCore.Models;

namespace Infrastructure.Repos
{
    public class LocationRepos : Repository<Location>, ILocationRepos
    {
        private readonly ManageToursContext _context;
        public LocationRepos(ManageToursContext context) : base(context)
        {
            _context = context;
        }


        public new async Task Activate(Location entity)
        {
            await this.UpdateStatus(entity, STATUS.AVAILABLE);
        }

        public new async Task Disable(Location entity)
        {
            await this.UpdateStatus(entity, STATUS.DISABLED);
        }

        private async Task UpdateStatus(Location entity, STATUS status)
        {
            entity.Status = status;
            await this.Update(entity);
        }
    }
}
