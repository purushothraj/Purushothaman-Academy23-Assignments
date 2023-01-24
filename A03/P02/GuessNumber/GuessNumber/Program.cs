using System;

namespace GuessNumber
{
   internal class Program
   {
      static void Main(string[] args)
      {
         double value = 0, counter = 0;
         Console.WriteLine("think of a number from 0 to 127\n");
         Console.WriteLine("Press 'y' for yes any other key to no");
         for(int i = 1; i < 8; i++)
         {
            Console.WriteLine("Is the remainder divided by " + Math.Pow(2,i) + " is greater than " + (Math.Pow(2,i-1)-1) + "?");
            string temp = Console.ReadLine();
            if (temp.Equals("y"))
            {
               value = value + Math.Pow(2, counter);
            }
            counter++;
         }
         Console.WriteLine("the number is " + value);
      }
   }
}