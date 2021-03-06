﻿using AppCore;
using AppCore.Interfaces;
using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public new IList<Customer> GetAllByStatus(STATUS status = STATUS.ALL)
        {
            if (status == STATUS.ALL) return this.GetAll();
            else
            {
                return _context.Set<Customer>().Where(m => m.Status == status).ToList();
            }
        }

        public new void Activate(Customer entity)
        {
            this.UpdateStatus(entity, STATUS.AVAILABLE);
        }

        public new void Disable(Customer entity)
        {
            this.UpdateStatus(entity, STATUS.DISABLED);
        }

        private void UpdateStatus(Customer entity, STATUS status)
        {
            entity.Status = status;
            this.Update(entity);
        }
    }
}
