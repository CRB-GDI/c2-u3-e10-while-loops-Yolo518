using System.Net.Security;
using System.Threading.Channels;

namespace Exercise10_
{
    internal class Program
    {
        static void Main(string[] args)
        { //Problem 1 Makeing a menu
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("**************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");
            Console.WriteLine();
            int playerChoice=int.Parse(Console.ReadLine());
            while(playerChoice>5 || playerChoice < 1 )
            {
                Console.WriteLine("Please enter 1-4");
                Console.WriteLine("**************");
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("**************");
                 playerChoice = int.Parse(Console.ReadLine());
               
            }
           if(playerChoice==1)
            {
                Console.WriteLine("Make new World");
            }
            if(playerChoice==2)
            {
                Console.WriteLine("loading ...");
            }
            if(playerChoice==3)
            {
                Console.WriteLine("Volume 100%");
                Console.WriteLine("Difuclty:Normal");
            }
            if(playerChoice ==4)
            {
                
            }
        }
    }
}