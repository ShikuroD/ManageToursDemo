using AppCore.Interfaces;
using AppCore.Models;
using System;
using System.Collections.Generic;
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
    }
}
