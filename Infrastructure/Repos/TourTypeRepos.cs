using System;
using System.Collections.Generic;
using System.Linq;
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
        public string GetTourTypeName(int Id)
        {
            var res = this.GetBy(Id);
            if (res != null) return res.Name;
            return null;
        }
        public new IList<TourType> GetAllByStatus(STATUS status = STATUS.ALL)
        {
            if (status == STATUS.ALL) return this.GetAll();
            else
            {
                return _context.Set<TourType>().Where(m => m.Status == status).ToList();
            }
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
