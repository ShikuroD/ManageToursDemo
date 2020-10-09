using System;
using System.Collections.Generic;
using System.Text;

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


        public new void Activate(Location entity)
        {
            this.UpdateStatus(entity, STATUS.AVAILABLE);
        }

        public new void Disable(Location entity)
        {
            this.UpdateStatus(entity, STATUS.DISABLED);
        }

        private void UpdateStatus(Location entity, STATUS status)
        {
            entity.Status = status;
            this.Update(entity);
        }
    }
}
