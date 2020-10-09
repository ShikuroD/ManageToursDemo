using AppCore.Interfaces;
using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repos
{
    public class CustomerRepos : Repository<Customer>, ICustomerRepos
    {
        private readonly ManageToursContext _context;
        public CustomerRepos(ManageToursContext context) : base(context)
        {
            _context = context;
        }
    }
}
