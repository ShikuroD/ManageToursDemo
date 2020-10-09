using AppCore.Interfaces;
using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repos
{
    public class EmployeeRepos : Repository<Employee>, IEmployeeRepos
    {
        private readonly ManageToursContext _context;
        public EmployeeRepos(ManageToursContext context) : base(context)
        {
            _context = context;
        }
    }
}
