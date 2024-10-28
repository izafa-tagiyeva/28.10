using Core.data;
using Core.helper.enums;
using Core.models;
using System;
using static System.Formats.Asn1.AsnWriter;

public class Program
{
    static void Main()
    {
        Country country;
        Planet planet;



       
       do {
            Console.WriteLine("Welcome");
            Console.WriteLine("1. Country menu");
            Console.WriteLine("2. Planet menu");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CountryMenu();
                    break;
                case "2":
                    PlanetMenu();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        } while (true) ;
        /*Planet Menu
       1.planet yarat
       2.Butun Planetleri gor
       3.Planet sec (planetin adini daxil ederek secilecek)
       0.Exit*/
        static void PlanetMenu()
        {

            do
            {
                Console.WriteLine("Welcome");
                Console.WriteLine("1.planet yarat");
                Console.WriteLine("2.Butun Planetleri gor");
                Console.WriteLine("3.Planet sec (planetin adini daxil ederek secilecek)");
                Console.WriteLine("0. Exit");

                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CreatePlanet();
                        break;
                    case "2":
                        ShowAllPlanets();
                        break;
                    case "3":
                        SelectPlanet();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            } while (true);

     
        }
       /*Country Menu
           1.olke yarat
           2.olke gor
           4.Evvelki menuya qayit.
           0.Exit*/


  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static void CountryMenu()
            {
            do
            {
                Console.WriteLine("Welcome");
                Console.WriteLine("1.olke yarat");
                Console.WriteLine("2.olke gor");
                Console.WriteLine("4.Evvelki menuya qayit.");
                Console.WriteLine("0. Exit");

                Console.Write("Choose an option: ");

              
                string choiche = int.TryParse(Console.ReadLine());
                switch (choiche)
                {
                    case "1":
                        CreateCountry();
                        break;
                    case "2":
                        ShowAllPlanets();
                        break;
                    case "4":
                        PlanetMenu();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            } while (!choiche);

            }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
   

         static void CreatePlanet()
        {
          

            Console.Write("Planet Name: ");
            string name = Console.ReadLine();

            Console.Write("Area: ");
            double area = double.Parse(Console.ReadLine());

            var planet = new Planet( name, area);
            AppDbContext.CreatePlanet(planet);

            Console.WriteLine("Planet created successfully!");
        }

         static void ShowAllPlanets()
        {
            var planets = AppDbContext.GetAllPlanets();
            foreach (var planet in planets)
                Console.WriteLine($"{planet.Name} (Area: {planet.Area})");
        }
        
        static void SelectPlanet()
        {
            Console.Write("Enter the Planet Name: ");
            string name = Console.ReadLine();

            var selectedPlanet = AppDbContext.GetPlanetByName(name);
            if (selectedPlanet != null)
                Console.WriteLine($"Selected Planet: {selectedPlanet}");
            else
                Console.WriteLine("Planet not found.");
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
          static void CreateCountry()
        {
            Console.Write("Country Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Country Name: ");
            string name = Console.ReadLine();

            Console.Write("Area: ");
            double area = double.Parse(Console.ReadLine());

            Console.Write("Anthem: ");
            string anthem = Console.ReadLine();

            Console.WriteLine("Region (0 - Europe, 1 - Asia, 2 - Africa, 3 - America, 4 - Oceania): ");
            Region region = (Region)int.Parse(Console.ReadLine());

            var country = new Country(  name, area, anthem, region);
            AppDbContext.CreateCountry(country);

            Console.WriteLine("Country created successfully!");
        }

          static void ShowAllCountries()
        {
            var countries = AppDbContext.GetAllCountries();
            foreach (var country in countries)
                Console.WriteLine($" {country.CountryName} (Region: {country.region}, Area: {country.Area})");
        }







    }
}


/*******Menu******

1.Country menu
2.Planet menu
0.Cixis

Planet Menu
1.planet yarat
2.Butun Planetleri gor
3.Planet sec (planetin adini daxil ederek secilecek)
0.Exit

Country Menu
1.olke yarat
2.olke gor
4.Evvelki menuya qayit.
0.Exit
*/