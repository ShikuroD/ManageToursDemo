using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        public string GetLocationName(int Id)
        {
            var res = this.GetBy(Id);
            if (res != null) return res.Name;
            return null;
        }

        public new IList<Location> GetAllByStatus(STATUS status = STATUS.ALL)
        {
            if (status == STATUS.ALL) return this.GetAll();
            else
            {
                return _context.Set<Location>().Where(m => m.Status == status).ToList();
            }
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
