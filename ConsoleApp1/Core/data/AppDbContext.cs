using Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.data
{
   public static class AppDbContext
    {

        static public List<Country> Countries = new List<Country>();
       static public List<Planet> Planets = new List<Planet>();

        public static void CreateCountry(Country country) => Countries.Add(country);

        // UpdateCountry()

        public static void RemoveCountry(Country Country) => Countries.Remove(Country);
        public static List<Country> GetAllCountries() => Countries;

        //GetCountryByRegion()

        public static void CreatePlanet(Planet planet)
        {
            Planets.Add(planet);
            Console.WriteLine(planet);
        }
        //UpdatePlanet()
        public static void RemovePlanet(Planet planet) => Planets.Remove(planet);
        public static List<Planet> GetAllPlanets() => Planets;

        public static string GetPlanetByName(string name)
        {
            foreach (var planet in Planets)
            {
                if (planet.Name == name)
                {
                    return planet.Name;
                }
            }
            return default;
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