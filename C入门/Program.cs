using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace C入门
{
    class Program
    {
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
          Console.WriteLine("Array collection contains {0} objects.",
          animalArray.Length);
          animalArray[0].Feed();
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


          double firstNumber, secondNumber;
          String userName;
          Console.WriteLine("ENTER your name");
          userName = Console.ReadLine();
          Console.WriteLine("welcome{0}!", userName);
          Console.WriteLine("now give me a number");
          firstNumber = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("now give me another number");
          secondNumber = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("the sum of {0} and {1}is{2}", firstNumber, secondNumber, firstNumber + secondNumber);
          Console.WriteLine("the result of subtracting{0}from{1}is{2}",secondNumber,firstNumber,firstNumber-secondNumber);
          Console.WriteLine("the product of{0} and {1}is{2}", firstNumber, secondNumber, firstNumber *secondNumber);
          Console.WriteLine("the result of dividing{0} by {1} is{2}", firstNumber, secondNumber, firstNumber * secondNumber);
          Console.WriteLine("the remainder after dividing {0}by{1}is{2}.", firstNumber, secondNumber, firstNumber % secondNumber);

          Console.WriteLine("Enter an integer:");
          int myInt = Convert.ToInt32(Console.ReadLine());
          bool isLessthan10 = myInt < 10;
          bool isBetweenOAnd5=(0<=myInt)&&(myInt<=5);
          Console.WriteLine("integer less than 10?{0}", isLessthan10);
          Console.WriteLine("integer between 0 and 5?{0}", isBetweenOAnd5);
          Console.WriteLine("Exactly one of the above is true?{0}",isLessthan10^isBetweenOAnd5);
          Console.ReadKey();
        }
}
}
