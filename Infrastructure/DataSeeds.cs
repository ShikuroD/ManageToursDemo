using AppCore;
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

            
            if (!context.CostTypes.Any())
            {
                context.CostTypes.AddRange(
                    new CostType("Di chuyển"),
                    new CostType("Ăn uống"),
                    new CostType("Khách sạn"),
                    new CostType("Hỗ trợ")
                    );

                context.SaveChanges();
            }
            

            if (!context.Jobs.Any())
            {
                context.Jobs.AddRange(
                    new Job("Tài xế"),
                    new Job("Hướng dẫn viên"),
                    new Job("Hậu cần"),
                    new Job("Tiếp viên")
                    );

                context.SaveChanges();
            }

            if (!context.Customers.Any())
            {
                context.Customers.AddRange(
                    new Customer("Nguyễn Văn A", SEX.MALE, "0123456789", "0123456789", "456/84/12 Somewhere, Earth"),
                    new Customer("Nguyễn Văn B", SEX.MALE, "0123456711", "0123456789", "456/84/12 Somewhere, Earth"),
                    new Customer("Nguyễn Văn C", SEX.MALE, "0123456712", "0123456789", "456/84/12 Somewhere, Earth"),
                    new Customer("Trần Thị H", SEX.FEMALE, "0123456724", "0123456789", "456/84/12 Somewhere, Earth"),
                    new Customer("Trần Thị N", SEX.FEMALE, "0123456746", "0123456789", "456/84/12 Somewhere, Earth"),
                    new Customer("Mã Văn Tài", SEX.MALE, "0123456714", "0123456789", "456/84/12 Somewhere, Earth"),
                    new Customer("John Wick", SEX.MALE, "0123456567", "0123456789", "456/84/12 Somewhere, Earth")

                    );

                context.SaveChanges();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee("Nhân Viên A", SEX.MALE, "0123456789", "0123456789", "456/84/12 Somewhere, Earth",1),
                    new Employee("Nhân viên B", SEX.FEMALE, "0124576711", "0123456789", "456/84/12 Somewhere, Earth",2),
                    new Employee("Nhân viên C", SEX.MALE, "0123473712", "0123456789", "456/84/12 Somewhere, Earth",4),
                    new Employee("Nhân viên D", SEX.FEMALE, "0123274724", "0123456789", "456/84/12 Somewhere, Earth",2),
                    new Employee("Nhân viên E", SEX.FEMALE, "0184356746", "0123456789", "456/84/12 Somewhere, Earth",3),
                    new Employee("Nhân viên F", SEX.MALE, "0123282714", "0123456789", "456/84/12 Somewhere, Earth",1)
                    
                    );

                context.SaveChanges();
            }
        }
    }
}
