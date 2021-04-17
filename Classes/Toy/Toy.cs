using System;
using System.Collections.Generic;
using System.Text;

namespace Toy
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Notes { get; set; }

        public Toy()
        {
            Manufacturer = "Mattel";
            Name = "Barbie Doll";
            Price = 10.50;
            Notes = "For ages 6 and up";
        }

        public string GetAisle()
        {
            Random rand = new Random();
            int randomNum = rand.Next(1, 25);

            return "\nManufacturer: " +Manufacturer.Substring(0,1) + randomNum 
                + "\nName: " + Name + "\nPrice: " + Price.ToString("C") + "\nNotes: " + Notes;
        }
    }
}
