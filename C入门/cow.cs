using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C入门
{
    class cow:animal
    {
       public void MILK()
        {
            Console.WriteLine("{0}HashSet been milked", name);
        }
       public cow(string newName): base(newName)
       {

       }
    }
}
