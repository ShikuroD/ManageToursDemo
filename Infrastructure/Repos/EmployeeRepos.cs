using AppCore;
using AppCore.Interfaces;
using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public new IList<Employee> GetAllByStatus(STATUS status = STATUS.ALL)
        {
            if (status == STATUS.ALL) return this.GetAll();
            else
            {
                return _context.Set<Employee>().Where(m => m.Status == status).ToList();
            }
        }
    }
}
