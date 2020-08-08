using System;
using System.Collections.Generic;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            //create buildings:
            var building123 = new Building("123 Linden Ave", "Building123") //ANCA: why start with the class name rather than var?????(in the example in the exercise!)
            {
                Width = 200,
                Depth = 200,
                Stories = 2
            };

            var building456 = new Building("456 12th Ave S", "Building456")
            {
                Width = 100,
                Depth = 100,
                Stories = 1
            };

            var building789 = new Building("789 Broadway", "Building789")
            {
                Width = 150,
                Depth = 150,
                Stories = 4
            };


            //construct the buildings:
            building123.Construct();
            building456.Construct();
            building789.Construct();

            //initial code printing the individual building info to the console - refactored below in the foreach loop:
            building123.Purchase("Lamar Alexander");
            building456.Purchase("Jim Cooper");
            building789.Purchase("Nashville Symphony");

            building123.Describe();


            //creating a new city instance:
            var mainCity = new City();
            Console.WriteLine($"{mainCity._name} was established in {mainCity._charteredYear} and is currently led by Mayor {mainCity.Mayor}.");

            var buildingCollection = new List<object> { building123, building456, building789 };

            mainCity.CityBuildings = buildingCollection;

            //initial code adding my 3 buildings to the collection of Nashville buildings:
            //mainCity.AddBuilding(Building123);
            //mainCity.AddBuilding(Building456);
            //mainCity.AddBuilding(Building789);

            Console.WriteLine($"{mainCity.ListBuildings()}");
            Console.WriteLine($"{mainCity._name} has the following buildings: {mainCity.ListBuildings()}");

            int count = 0;

            foreach (var item in mainCity.CityBuildings)
            {
                Console.WriteLine($"{item}");
                count++;
            }


        }
    }
}
