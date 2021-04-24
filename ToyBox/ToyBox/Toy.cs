using System;
using System.Collections.Generic;
using System.Text;

namespace ToyBox
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Notes { get; set; }

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Notes = "";
        }

        public string GetAisle()
        {
            Random rand = new Random();
            int randomNum = rand.Next(1, 25);

            return "\nManufacturer: " + Manufacturer.Substring(0, 1) + randomNum
                + "\nName: " + Name + "\nPrice: " + Price.ToString("C") + "\nNotes: " + Notes;
        }


    }
}
