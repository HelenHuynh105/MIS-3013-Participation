using System;
using System.Collections.Generic;
using System.Text;

namespace ToyBox
{
    class ToyBox
    {
        public List<Toy> Toys { get; set; }

        public string Owner { get; set; }

        public string Location { get; set; }

        public ToyBox()
        {
            Toys = new List<Toy>();

            Owner = "";

            Location = "";

        }

        public string GetRandomToy()
        {

            Random rand = new Random();
            int RandomToyIndex = rand.Next(0, Toys.Count);
            string RandomToy = Toys[RandomToyIndex];
            return RandomToy;
        }
    }
}
