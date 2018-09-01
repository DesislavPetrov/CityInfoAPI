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
                    Description = "The capital of Bulgaria"
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Plovdiv",
                    Description = "The second largest city in Bulgaria"
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Samokov",
                    Description = "The most beautiful city in Bulgaria"
                }
            };
        }
    }
}
