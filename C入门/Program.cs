using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Diagnostics;
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
            /*
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
             */
            int[] testArray = { 4,7,4,2,7,3,7,8,3,9,1,9};
            int[] maxValIndices;
            int maxVal = Maxima(testArray, out maxValIndices);
            Console.WriteLine("Maximum value {0} found at element indices:",maxVal);
            foreach (int index in maxValIndices)
            {
                Console.WriteLine(index);
            }
            Console.ReadKey();
  }
   static int Maxima(int[] integers,out int[]indices)
  {
            Debug.WriteLine("maximum value search started.");
            indices = new int[1];
            int maxVal = integers[0];
            indices[0] = 0;
            int count = 1;
            Debug.WriteLine(string.Format("Maximum value initialized to {0}, at element index 0.", maxVal));
            for (int i = 1; i < integers.Length; i++)
            {
                Debug.WriteLine(string.Format("Now looking at element at index {0}.", i));
                if (integers[i] > maxVal)
                {
                    maxVal = integers[i];
                    count = 1;
                    indices = new int[1];
                    indices[0] = i;
                    Debug.WriteLine(string.Format("New maximum found. New value is {0}, at element index {1}.", maxVal, i));
                }
                else
                {
                    if (integers[i] == maxVal)
                    {
                        count++;
                        int[] oldIndices = indices;
                        indices = new int[count];
                        oldIndices.CopyTo(indices, 0);
                        indices[count - 1] = i;
                        Debug.WriteLine(string.Format("Duplicate maximum found at element index {0}.", i));

                    }
                }
            }
        Trace.WriteLine(string.Format("Maximum value {0} found, with {1} occurrences.", maxVal, count));
        Debug.WriteLine("Maximum value search completed.");
        return maxVal;
   }
 }
}
