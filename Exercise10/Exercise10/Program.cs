using System.Net.Security;
using System.Threading.Channels;

namespace Exercise10_
{
    internal class Program
    {
        static void Main(string[] args)
        { //Problem 1 Makeing a menu
            int exit = 0;
            int playerChoice = 0;
            while (playerChoice > 5 || playerChoice < 1)
            {
                while (exit == 99 || exit <= 99)
                {
                    Console.WriteLine("**************");
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1 - New Game");
                    Console.WriteLine("2 - Load Game");
                    Console.WriteLine("3 - Options");
                    Console.WriteLine("4 - Quit");
                    Console.WriteLine("**************");
                    playerChoice = int.Parse(Console.ReadLine());
                    if (playerChoice == 1)
                    {
                        //Choice 1
                        Console.WriteLine("Make new World");
                        exit = int.Parse(Console.ReadLine());
                    }
                    if (playerChoice == 2)
                    {
                        //Choice 2
                        Console.WriteLine("loading ...");
                        exit = int.Parse(Console.ReadLine());
                    }
                    if (playerChoice == 3)
                    {
                        //Choice 3
                        Console.WriteLine("Volume 100%");
                        Console.WriteLine("Difuclty:Normal");
                        exit = int.Parse(Console.ReadLine());
                    }
                    if (playerChoice == 4)
                    {
                        //Choice 4
                        Console.WriteLine("Thank you for playing see you later");
                        exit = 100;
                    }

                }

            }
            


        }
    }
}