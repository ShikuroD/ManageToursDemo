using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Models;

namespace AppCore.Interfaces
{
    public interface ILocationRepos : IRepository<Location>
    {
        string GetLocationName(int Id);
    }
}
