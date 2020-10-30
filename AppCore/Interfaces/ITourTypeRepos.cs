using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Models;

namespace AppCore.Interfaces
{
    public interface ITourTypeRepos : IRepository<TourType>
    {
        string GetTourTypeName(int Id);
        
    }
}