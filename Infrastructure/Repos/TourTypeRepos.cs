using System;
using System.Collections.Generic;
using System.Text;

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


        public new void Activate(TourType entity)
        {
            this.UpdateStatus(entity, STATUS.AVAILABLE);
        }

        public new void Disable(TourType entity)
        {
            this.UpdateStatus(entity, STATUS.DISABLED);
        }

        private void UpdateStatus(TourType entity, STATUS status)
        {
            entity.Status = status;
            this.Update(entity);
        }
    }
}
