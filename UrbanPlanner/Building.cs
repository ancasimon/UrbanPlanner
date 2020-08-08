using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner  //ANCA: Note: Initially, I had Building as a folder name too > which made it a namespace - it did't like that there was a namespace and a class with the same name and could not use the class/type!!
{
    class Building
    {
        //private fields:
        public string _designer = "Anca";
        public DateTime _dateConstructed;  //ANCA: This gets set by the Construct() method below!
        public string _address;
        public string _owner;

        //public properties:
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume {                                    //Anca's note: Volume has to be of the type double because it uses double in its calculation!
            get { return Width * Depth * (3 * Stories); }
                }

        //constructor:
        public Building(string address)
        {
            _address = address;
            Console.WriteLine($"Instantiated a new building: {_address}.");
        }


        //public methods:
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
            Console.WriteLine($"{_address} was built on {_dateConstructed}.");
        }

        public void Purchase(string owner)
        {
            _owner = owner;
            Console.WriteLine($@"
{_address}
Designed by {_designer}
Constructed on {_dateConstructed}
Owned by {_owner}
{Volume} cubic meters of space
");
        }


    }
}
