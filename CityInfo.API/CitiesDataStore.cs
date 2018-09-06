using CityInfo.API.Models;
using System.Collections.Generic;

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
                new CityDto()
                {
                    Id = 1,
                    Name = "Sofia",
                    Description = "The capital of Bulgaria",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Ivan Vazov National Theatre",
                            Description = "The most beautiful theatre in Bulgaria"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Cathedral Saint Alexandar Nevski",
                            Description = "The church was built as a memorial to the 200,000 Russian soldiers who died in the Russo-Turkish Liberation War"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Plovdiv",
                    Description = "The second largest city in Bulgaria",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Ethnographic Museum",
                            Description = "The best museum in Plovidv"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Plovdiv Old Town",
                            Description = "Bulgaria's second city, Plovdiv has 19th century houses and Roman ruins, including a Roman amphitheater in use today."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Samokov",
                    Description = "The most beautiful city in Bulgaria",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Historical Museum",
                            Description = "If you want to see the cultural heritage of Samokov presented in several themed displays, then head to the Historical Museum, located in the center of the town. "
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Tsari Mali Grad",
                            Description = "Tsari Mali Grad in Samokov is an awesome place for people who are interested in ruins, castles, history, and archaeology."
                        }
                    }
                }
            };
        }
    }
}
