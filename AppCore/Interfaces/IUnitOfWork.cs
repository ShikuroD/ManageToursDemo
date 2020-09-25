using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ILocationRepos Locations { get; }
        ITourRepos Tours { get; }
        ITourTypeRepos TourTypes { get; }

        Task<int> CompleteAsync();
    }
}
