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
using AppCore;
using Presentation.VMServices;
using Microsoft.Extensions.Logging;
using AppCore.Services;

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
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            //add core services
            services.AddTransient<ITourService, TourService>();
            services.AddTransient<ITourTypeService, TourTypeService>();
            services.AddTransient<ILocationService, LocationService>();


            //add vm services
            services.AddTransient<IVMTourService, VMTourService>();

            services.AddDbContext<ManageToursContext>(options => options.UseSqlite("Data Source=tours.db", x => x.MigrationsAssembly("Presentation.Migrations")));
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
