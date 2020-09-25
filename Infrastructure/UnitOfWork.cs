using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
        }
        public ILocationRepos Locations { get; private set; }
        public ITourRepos Tours { get; private set; }
        public ITourTypeRepos TourTypes { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
