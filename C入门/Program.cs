using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace C入门
{
    class Program
    {
        delegate Double processDelegate(double param1, double param2);
        static double multiply(double param1, double param2)
        {
            return param1 * param2;
        }
        static double divide(double param1, double param2)
        {
            return param1 / param2;
        }
        static void Main(string[] args)
        {
          Console.WriteLine("Create an Array type collection of Animal " +"objects and use it:");
          animal[] animalArray = new animal[2];
          cow myCow1 = new cow("Deirdre");
         animalArray[0] = myCow1;
         animalArray[1] = new Chicken("Ken");
         foreach (animal myAnimal in animalArray)
          {
           Console.WriteLine("New {0} object added to Array collection, " +"Name = {1}", myAnimal.ToString(), myAnimal.Name);
          }
          Console.WriteLine("Array collection contains {0} objects.",animalArray.Length);animalArray[0].Feed();
          ((Chicken)animalArray[1]).LayEgg();
          Console.WriteLine();
          Console.WriteLine("Create an ArrayList type collection of Animal " +"objects and use it:");
          ArrayList animalArrayList = new ArrayList();
          cow myCow2 = new cow("Hayley");
          animalArrayList.Add(myCow2);
          animalArrayList.Add(new Chicken("Roy"));
          foreach (animal myAnimal in animalArrayList)
          {
            Console.WriteLine("New {0} object added to ArrayList collection," +" Name = {1}", myAnimal.ToString(), myAnimal.Name);
          }
            Console.WriteLine("ArrayList collection contains {0} objects.",animalArrayList.Count);
            ((animal)animalArrayList[0]).Feed();
            ((Chicken)animalArrayList[1]).LayEgg();
            Console.WriteLine();
            Console.WriteLine("Additional manipulation of ArrayList:");
            animalArrayList.RemoveAt(0);
           ((animal)animalArrayList[0]).Feed();
            animalArrayList.AddRange(animalArray);
           ((Chicken)animalArrayList[2]).LayEgg();
            Console.WriteLine("The animal called {0} is at index {1}.",
            myCow1.Name, animalArrayList.IndexOf(myCow1));
            myCow1.Name = "Janice";
            Console.WriteLine("The animal is now called {0}.",
            ((animal)animalArrayList[1]).Name);
            string myString = "This is a test.";
            char[] separator = { ' ' };
            string[] myWords;
            myWords = myString.Split(separator);
            foreach (string word in myWords)
            {
                Console.WriteLine("{0}", word);
            }
            processDelegate process;
            Console.WriteLine("Enter 2 numbers separated with a comma:");
            string input = Console.ReadLine();
            int commaPos = input.IndexOf(',');
            double param1 = Convert.ToDouble(input.Substring(0, commaPos));
            double param2 = Convert.ToDouble(input.Substring(commaPos + 1, input.Length - commaPos - 1));
            Console.WriteLine("Enter M to multiply or D to divide:");
            input = Console.ReadLine();
            if (input == "M")
                process = new processDelegate(multiply);
            else
                process = new processDelegate(divide);
            Console.WriteLine("result:{0}", process(param1, param2));
            Console.ReadKey();
}
}
}
