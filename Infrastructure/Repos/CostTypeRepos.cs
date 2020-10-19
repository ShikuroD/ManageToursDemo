using AppCore;
using AppCore.Interfaces;
using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repos
{
    public class CostTypeRepos : Repository<CostType>, ICostTypeRepos
    {
        private readonly ManageToursContext _context;
        public CostTypeRepos(ManageToursContext context) : base(context)
        {
            _context = context;
        }

        public string GetCostTypeName(int Id)
        {
            var res = this.GetBy(Id);
            if (res != null) return res.Name;
            return null;
        }
        public new IList<CostType> GetAllByStatus(STATUS status = STATUS.ALL)
        {
            if (status == STATUS.ALL) return this.GetAll();
            else
            {
                return _context.Set<CostType>().Where(m => m.Status == status).ToList();
            }
        }
    }
}
