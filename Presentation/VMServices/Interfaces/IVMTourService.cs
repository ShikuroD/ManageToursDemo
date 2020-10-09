
using AppCore.Models;
using Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.VMServices
{
    public interface IVMTourService
    {
        //View models
        TourTabVM LoadTourTabData();

       
    }
}
