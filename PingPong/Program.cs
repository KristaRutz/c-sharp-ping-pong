using System;
using PingPong;

class Program
{
  public static Pong pingPong = new Pong();
  public static void Continue() {

   Console.WriteLine("Ready to play Ping-Pong?");
   Console.WriteLine("Please enter a number.");
   string userInputtedValue = Console.ReadLine();
   int userInputtedValueToInt = int.Parse(userInputtedValue);
   pingPong.DeterminePingOrPong(userInputtedValueToInt);
   Console.WriteLine("Do you want to continue playing? ['Y' for yes, or 'Enter' for no.");
   string continuePlaying = Console.ReadLine();
   if((continuePlaying == "y") || (continuePlaying == "Y")) {
     Continue();
   } else {
     Console.WriteLine("Goodbye");
   }
  }
  static void Main()
  {
    Continue();
  }
}