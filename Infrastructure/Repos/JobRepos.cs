using AppCore.Interfaces;
using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repos
{
    public class JobRepos : Repository<Job>, IJobRepos
    {
        private readonly ManageToursContext _context;
        public JobRepos(ManageToursContext context) : base(context)
        {
            _context = context;
        }
    }
}
