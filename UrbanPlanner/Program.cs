using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            //create buildings:
            var Building123 = new Building("123 Linden Ave") //ANCA: why start with the class name rather than var?????(in the example int he exercise!)
            {
                Width = 200,
                Depth = 200,
                Stories = 2
            };

            var Building456 = new Building("456 12th Ave S")
            {
                Width = 100,
                Depth = 100,
                Stories = 1
            };

            var Building789 = new Building("789 Broadway")
            {
                Width = 150,
                Depth = 150,
                Stories = 4
            };


            //construct the buildings:
            Building123.Construct();
            Building456.Construct();
            Building789.Construct();

            Building123.Purchase("Lamar Alexander");
            Building456.Purchase("Jim Cooper");
            Building789.Purchase("Nashville Symphony");




        }
    }
}
