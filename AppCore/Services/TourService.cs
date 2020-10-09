using AppCore.Interfaces;
using AppCore.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


namespace AppCore.Services
{
    public class TourService : Service<Tour>, ITourService
    {
        public TourService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            
        }



        
    }
}
