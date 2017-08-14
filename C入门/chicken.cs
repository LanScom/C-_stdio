using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C入门
{
    public class Chicken : animal
    {
        public void LayEgg()
        {

            Console.WriteLine("{0} has laid an egg.", name);
        }
        public Chicken(string newName)
            : base(newName)
        {
        }
    }
}
