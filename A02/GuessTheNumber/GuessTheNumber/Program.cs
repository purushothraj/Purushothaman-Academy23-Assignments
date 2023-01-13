using System;

Console.WriteLine("Think of a number from 0 to 128 and press enter");
int mNum = 64,lLimNum=0,uLimNum = 128;
Console.WriteLine($"Is your number {mNum}?");
Console.WriteLine($"select from below options \n 1:Correct\n 2:Higher than {mNum}\n 3:Lower than {mNum}");
string a = Console.ReadLine();
Console.WriteLine($"Entrered option is {a}");
for (int guessCount = 1; guessCount <= 8 ; guessCount++ )
{
   switch (a)
   {
      case "1":
         {
            Console.WriteLine($"The number is {mNum}");
            break;
         }
      case "2":
         {
            lLimNum = mNum;
            mNum = (lLimNum + uLimNum) / 2;
            Console.WriteLine($"Is your number {mNum}?");
            Console.WriteLine($"select from below options \n 1:Correct\n 2:Higher than {mNum}\n 3:Lower than {mNum}");
            a = Console.ReadLine();
            break;
         }
      case "3":
         {
            uLimNum = mNum;
            mNum = (lLimNum + uLimNum) / 2;
            Console.WriteLine($"Is your number {mNum}?");
            Console.WriteLine($"select from below options \n 1:Correct\n 2:Higher than {mNum}\n 3:Lower than {mNum}");
            a = Console.ReadLine();
            break;
         }
      default:
         {
            Console.WriteLine("Enter a valid option");
            break;
         }
   }
   if (a == "1")
   {
      Console.WriteLine($"The number is {mNum} with {guessCount} guess.");
      break;
   }
   if (guessCount > 7)
   {
      Console.WriteLine("Some options entered wrongly ! Cant find your number");
      break;
   }
}
