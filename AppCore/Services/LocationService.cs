
using AppCore.Interfaces;
using AppCore.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;


namespace AppCore.Services
{
    public class LocationService : Service<Location>, ILocationService
    {
        public LocationService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

    }
}
