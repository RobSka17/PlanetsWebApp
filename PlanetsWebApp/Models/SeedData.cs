using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PlanetsWebApp.Data;
using PlanetsWebApp.Models;
using System;
using System.Linq;

namespace PlanetsWebApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PlanetsWebAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PlanetsWebAppContext>>()))
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

                if (context.Planet.Any())
                {
                    return;
                }

                context.Planet.AddRange(
                    new Planet
                    {
                        Name = "Mercury",
                        Mass = 330110000000000000000000.0,
                        MassDisplay = "3.3011 x10^23",
                        Diameter = 4880,
                        SunDistance = 58000000,
                        ImagePath = "/images/mercury.jpg"
                    }
                );
                context.Planet.AddRange(
                    new Planet
                    {
                        Name = "Venus",
                        Mass = 4867300000000000000000000.0,
                        MassDisplay = "4.8673 ×10^24",
                        Diameter = 12100,
                        SunDistance = 108000000,
                        ImagePath = "/images/venus.jpg"
                    }
                );
                context.Planet.AddRange(
                    new Planet
                    {
                        Name = "Earth",
                        Mass = 5972370000000000000000000.0,
                        MassDisplay = "5.97237 ×10^24",
                        Diameter = 12742,
                        SunDistance = 150000000,
                        ImagePath = "/images/earth.jpg"
                    }
                );
                context.Planet.AddRange(
                    new Planet
                    {
                        Name = "Mars",
                        Mass = 641710000000000000000000.0,
                        MassDisplay = "6.4171 ×10^23",
                        Diameter = 6780,
                        SunDistance = 228000000,
                        ImagePath = "/images/mars.jpg"
                    }
                );
                context.Planet.AddRange(
                    new Planet
                    {
                        Name = "Jupiter",
                        Mass = 1898200000000000000000000000.0,
                        MassDisplay = "1.8982 ×10^27",
                        Diameter = 139822,
                        SunDistance = 778000000,
                        ImagePath = "/images/jupiter.jpg"
                    }
                );
                context.Planet.AddRange(
                    new Planet
                    {
                        Name = "Saturn",
                        Mass = 568340000000000000000000000.0,
                        MassDisplay = "5.6834 ×10^26",
                        Diameter = 116464,
                        SunDistance = 1400000000,
                        ImagePath = "/images/saturn.jpg"
                    }
                );
                context.Planet.AddRange(
                    new Planet
                    {
                        Name = "Uranus",
                        Mass = 86810000000000000000000000.0,
                        MassDisplay = "8.6810 x10^25",
                        Diameter = 50724,
                        SunDistance = 2900000000,
                        ImagePath = "/images/uranus.jpg"
                    }
                );
                context.Planet.AddRange(
                    new Planet
                    {
                        Name = "Neptune",
                        Mass = 102413000000000000000000000.0,
                        MassDisplay = "1.02413 ×10^26",
                        Diameter = 49244,
                        SunDistance = 4500000000,
                        ImagePath = "/images/neptune.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}