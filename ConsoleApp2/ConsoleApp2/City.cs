using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class City
    {
        public int cityId { get; set; }
        public string cityName { get; set; }
        public static List<City> getAllCityHigherCurfew()
        {

            List<City> listStudents = new List<City>
        {
            new City
            {
                cityId = 1,
                cityName = "Riyadh",
            },
                  new City
            {
                cityId = 2,
                cityName = "Medina",
            },
                        new City
            {
                cityId = 3,
                cityName = "Mecca",
            },

        };





            return listStudents;




        }
        public static List<City> getAllCityLowerCurfew()
        {

            List<City> listStudents = new List<City>
        {
            new City
            {
                cityId = 4,
                cityName = "Jeddah",
            },
                  new City
            {
                cityId = 5,
                cityName = "Tabuk",
            },
                        new City
            {
                cityId = 6,
                cityName = "Dammam",
            },

        };





            return listStudents;




        }

    }
}
