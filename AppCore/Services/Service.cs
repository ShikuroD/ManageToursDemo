using AppCore.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;


namespace AppCore.Services
{
    public class Service<Entity> : IService<Entity>
    {
        protected readonly IUnitOfWork _unitOfWork;
        
        public Service(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
        }


        public int Complete()
        {
            return _unitOfWork.Complete();
        }
    }
}
