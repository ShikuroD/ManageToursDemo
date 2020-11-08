using System;
using System.Collections.Generic;
using System.Text;


namespace AppCore.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ILocationRepos Locations { get; }
        ITourRepos Tours { get; }
        ITourTypeRepos TourTypes { get; }

        ICostTypeRepos CostTypes { get; }
        IEmployeeRepos Employees { get; }
        ICustomerRepos Customers { get; }
        IJobRepos Jobs { get; }

        int Complete();
    }
}
