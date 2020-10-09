using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public interface IService<Entity>
    {

        int Complete();
    }
}
