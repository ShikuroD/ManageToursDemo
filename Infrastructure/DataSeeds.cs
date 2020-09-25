using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class DataSeeds
    {
        public static void Initalize(ManageToursContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Locations.Any())
            {
                context.Locations.AddRange(
                    new Location("TP Hồ Chí Minh"),
                    new Location("Hà Nội"),
                    new Location("Nha Trang"),
                    new Location("Huế")
                    );

                context.SaveChanges();
            }

            if (!context.TourTypes.Any())
            {
                context.TourTypes.AddRange(
                    new TourType("Du lịch di động"),
                    new TourType("Du lịch kết hợp nghề nghiệp"),
                    new TourType("Du lịch xã hội"),
                    new TourType("Gia đình")
                    );

                context.SaveChanges();
            }
        }
    }
}
