using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto
                {
                    Id = 1, 
                    Name = "New York City",
                    Description = "The one with that big park",
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1, 
                            Name = "Big Apple",
                            Description = "That apple is very big."
                        }
                    }
                },
                new CityDto
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with cathedral that was never finished"
                },
                new CityDto
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower"
                },
            };
        }
    }
}
