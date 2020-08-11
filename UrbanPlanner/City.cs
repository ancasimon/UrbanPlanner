using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner
{
    class City
    {
        //private fields:
        public string _name = "Nashville";
        public int _charteredYear = 1806;

        //public properties:
        public string Mayor { get; set; } = "John Cooper";
        //public List<string> CityBuildings { get; set; } = new List<string> { "Ryman Auditorium", "AT&T Building - aka Batman Building", "Union Station", "Parthenon" };

        //a collection of all the buildings in the city.
        //public List<Building> CityBuildings { get; set; }

        //constructor - let's use the default constructor for now;


        //methods:
        //public string ListBuildings() => string.Join(", ", CityBuildings);

        //public void AddBuilding(Building newBuilding)
        //{
        //    CityBuildings?.Add(newBuilding);
        //    Console.WriteLine($"Updated list of Nashville buildings includes: {CityBuildings}.");
        //}




    }
}
