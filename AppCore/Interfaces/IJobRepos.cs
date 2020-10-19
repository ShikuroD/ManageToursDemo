using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IJobRepos : IRepository<Job>
    {
        string GetJobName(int Id);
    }
}
