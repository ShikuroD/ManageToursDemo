using System;
using System.Collections.Generic;
using System.Text;

using AppCore.Interfaces;
using Infrastructure.Repos;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ManageToursContext _context;

        public UnitOfWork(ManageToursContext context)
        {
            _context = context;

            Locations = new LocationRepos(context);
            Tours = new TourRepos(context);
            TourTypes = new TourTypeRepos(context);
            CostTypes = new CostTypeRepos(context);
            Jobs = new JobRepos(context);
            Employees = new EmployeeRepos(context);
            Customers = new CustomerRepos(context);
        }
        public ILocationRepos Locations { get; private set; }
        public ITourRepos Tours { get; private set; }
        public ITourTypeRepos TourTypes { get; private set; }

        public ICostTypeRepos CostTypes { get; private set; }
        public IEmployeeRepos Employees { get; private set; }
        public ICustomerRepos Customers { get; private set; }
        public IJobRepos Jobs { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
