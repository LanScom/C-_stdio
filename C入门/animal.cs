using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C入门
{
    public abstract class animal
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name=value;}
        }       
   
        public animal()
        {
          name ="the animal with no name";

         }
    public animal(String newNme)
    {
        name = newNme;
     }
    public void Feed()
    {
        Console.WriteLine("{0}has been fed",name);
    }
}
}