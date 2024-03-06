using System.Threading.Channels;

namespace Exercise10_
{
    internal class Program
    {
        static void Main(string[] args)
        { //Problem 1 Makeing a menu
            Console.WriteLine("**************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");
            Console.WriteLine();
            int playerChoice=int.Parse(Console.ReadLine());
            while(playerChoice>5)
            {
                Console.WriteLine("**************");
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("**************");
                 playerChoice = int.Parse(Console.ReadLine());
               
            }
            while(playerChoice==1)
            {
                Console.WriteLine("Makeing the new world and gods");
                Console.WriteLine("If it is takeing to long to load prees 1");
                Console.ReadLine();
                Console.WriteLine("**************");
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("**************");
                playerChoice = int.Parse(Console.ReadLine());
            }
            while (playerChoice == 2)
            {
                Console.WriteLine("Loading...");
                Console.WriteLine("There seems to have been a promblem loading the game");
                Console.ReadLine();
                Console.WriteLine("**************");
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("**************");
                playerChoice = int.Parse(Console.ReadLine());
                
            }
            while (playerChoice == 3)
            {
                Console.WriteLine("Volume 100%");
                Console.WriteLine("Difficulty: Normal");
                Console.WriteLine("press 2 to exit");
                Console.ReadLine();
                Console.WriteLine("**************");
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("**************");
                playerChoice = int.Parse(Console.ReadLine());
            }
            while (playerChoice == 4)
            {
                Console.WriteLine("Quiting");

            }
        }
    }
}