using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Forms;
using AppCore.Interfaces;
using Infrastructure;
using Infrastructure.Repos;
using AutoMapper;
using Presentation.VMServices;
using AppCore.Services;
using Presentaton.ViewModels;

namespace Presentation
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ///register services
            
            ConfigureServices();

            /// seed data
            var context = ServiceProvider.GetRequiredService<ManageToursContext>();
            DataSeeds.Initalize(context);
            context.SaveChanges();

            ///run forms
            var mainForm = ServiceProvider.GetRequiredService<MainForm>();
            Application.Run(mainForm);

        }

        private static IServiceProvider ServiceProvider { get; set; }
        //private static IHostingEnvironment _appHost;
        static void ConfigureServices()
        {
            var services = new ServiceCollection();

            //forms
            services.AddScoped<MainForm>();

            //auto mapper
            services.AddAutoMapper(typeof(Mapping));

            //add repositories
            services.AddTransient<ITourRepos, TourRepos>();
            services.AddTransient<ITourTypeRepos, TourTypeRepos>();
            services.AddTransient<ILocationRepos, LocationRepos>();
            services.AddTransient<ICostTypeRepos, CostTypeRepos>();
            services.AddTransient<ICustomerRepos, CustomerRepos>();
            services.AddTransient<IEmployeeRepos, EmployeeRepos>();
            services.AddTransient<IJobRepos, JobRepos>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            //add core services
            services.AddTransient<ITourService, TourService>();
            services.AddTransient<ITourTypeService, TourTypeService>();
            services.AddTransient<ILocationService, LocationService>();


            //add vm services
            services.AddTransient<IVMTourService, VMTourService>();

            services.AddDbContext<ManageToursContext>(options => options.UseSqlite($"Data Source=tours.db", x => x.MigrationsAssembly("Presentation.Migrations")));
            //services.AddDbContext<ManageToursContext>(options => options.UseSqlite($"Data Source=D:\\Code\\Visual Studio\\ManageToursDemo\\ManageToursDemo\\Presentation\\tours.db", x => x.MigrationsAssembly("Presentation.Migrations")));
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
