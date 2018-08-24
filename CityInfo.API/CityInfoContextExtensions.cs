using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Entities;

namespace CityInfo.API
{
    public static class CityInfoContextExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            // init seed data
            var cities = new List<City>
            {
                new City
                {
                    Name = "New York City",
                    Description = "The one with that big park",
                    PointOfInterest = new List<PointOfInterest>
                    {
                        new PointOfInterest
                        {
                            Name = "Big Apple",
                            Description = "That apple is very big."
                        }
                    }
                },
                new City
                {
                    Name = "Antwerp",
                    Description = "The one with cathedral that was never finished"
                },
                new City
                {
                    Name = "Paris",
                    Description = "The one with that big tower"
                },
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
