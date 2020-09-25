using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Interfaces;
using Infrastructure;
using Infrastructure.Repos;
using AutoMapper;
using AppCore;

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
            var mainForm = ServiceProvider.GetService<MainForm>();
            Application.Run(mainForm);

        }

        private static IServiceProvider ServiceProvider { get; set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();

            //forms
            services.AddScoped<MainForm>();


            services.AddAutoMapper(typeof(Mapping));

            services.AddTransient<ITourRepos, TourRepos>();
            services.AddTransient<ITourTypeRepos, TourTypeRepos>();
            services.AddTransient<ILocationRepos, LocationRepos>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<ManageToursContext>(options => options.UseSqlite("Data Source=tours.db", x => x.MigrationsAssembly("Presentation.Migrations")));
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
