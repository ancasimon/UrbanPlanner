using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            //create buildings:
            var Building123 = new Building("123 Linden Ave", "building123") //ANCA: why start with the class name rather than var?????(in the example in the exercise!)
            {
                Width = 200,
                Depth = 200,
                Stories = 2
            };

            var Building456 = new Building("456 12th Ave S", "building456")
            {
                Width = 100,
                Depth = 100,
                Stories = 1
            };

            var Building789 = new Building("789 Broadway", "building789")
            {
                Width = 150,
                Depth = 150,
                Stories = 4
            };


            //construct the buildings:
            Building123.Construct();
            Building456.Construct();
            Building789.Construct();

            //initial code printing the individual building info to the console - refactored below in the foreach loop:
            Building123.Purchase("Lamar Alexander");
            Building456.Purchase("Jim Cooper");
            Building789.Purchase("Nashville Symphony");


            //creating a new city instance:
            var mainCity = new City();
            Console.WriteLine($"{mainCity}");

            //Console.WriteLine($"{mainCity._name} has the following buildings: {mainCity.ListBuildings()}");

            //initial code adding my 3 buildings to the collection of Nashville buildings:
            //mainCity.AddBuilding(Building123);
            //mainCity.AddBuilding(Building456);
            //mainCity.AddBuilding(Building789);
            //Console.WriteLine($"{mainCity}");

            foreach (var item in mainCity.CityBuildings)
            {
                Console.WriteLine($"{item}");
            }


        }
    }
}
