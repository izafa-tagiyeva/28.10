using Core.helper.enums;
using Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.models
{
    public class Country
    {
        public static int Id { get; set; }
        private int _id=0;
        public string CountryName { get; set; }
        public double Area { get; set; }
        public string Anthem { get; set; }
        public Region region { get; set; }

        public Country(string name, double area,string anthem, Region regions)
        {
            Id = ++_id;
            CountryName = name;
            Area = area;
            Anthem = anthem;
            region = regions;
        }

      


    }
}

/*
CreateCountry()
UpdateCountry()
RemoveCountry()
GetAllCountries()
GetCountryByRegion()

CreatePlanet()
UpdatePlanet()
RemovePlanet()
GetAllPlanets()
*/






/*
Country Class
=================
CountryId
CountryName
Area
Anthem
Region(ENUM)
*/