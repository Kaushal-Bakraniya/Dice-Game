using System;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            int playDice;
			int jackDice;
			
			int playerPoints = 0;
			int jackPoints = 0;
			
			Console.ForegroundColor  = ConsoleColor.Yellow;
			
			Random random = new Random();
			
			Console.WriteLine("\nJack's Dice");
			
			Console.Write("\nEnter Your Name : ");
			string nm = Console.ReadLine();

			Console.Write("\nWelcome, " + nm);

			for(int i=0;i<10;i++)
			{
				Console.WriteLine("\n\nPress Any Key To Roll The Dice.");
				
				Console.ReadKey();
				
				playDice = random.Next(1,7);
				
				Console.WriteLine("\nYou Rolled " + playDice);
				
				Console.WriteLine("\n.....");
				
				System.Threading.Thread.Sleep(1000);
				
				jackDice = random.Next(1,7);
				
				Console.WriteLine("\nJack Rolled " + jackDice);
			
				if(playDice > jackDice)
				{
					playerPoints++;
					Console.WriteLine("\n" + nm + " Win This Round!");
				}
				else if(playDice < jackDice)
				{
					jackPoints++;
					Console.WriteLine("\nJack Win This Round!");
				}
				else
				{
					Console.WriteLine("\nDraw!");
				}
				
				Console.WriteLine("\nScore board : " + nm + " : " + playerPoints + ", Jack : " + jackPoints);
			}

			Console.WriteLine("\n\n-------------------------------------------");
			
			if(playerPoints > jackPoints)
			{
				Console.WriteLine("\nCongratulations " + nm + ", You Win This Game");
			}
			else if(playerPoints < jackPoints)
			{
				Console.WriteLine("\nJack Is Winner");
				Console.WriteLine("\nYou Lose This Game");
			}
			else
			{
				Console.WriteLine("\nIt is a Draw");
			}
			
			Console.WriteLine("\n-------------------------------------------");

			Console.ReadKey();
        }
    }
}
