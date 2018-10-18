using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Ricepot
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.SetWindowSize(100, 40);
            Random rand = new Random();
            ConsoleColor[] Color = {ConsoleColor.Blue, ConsoleColor.Cyan,
            ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green,
            ConsoleColor.Magenta, ConsoleColor.Gray };

            System.Console.WriteLine("Git Hub");

            while (true)
            {
                Console.Clear();
                for(int i = 0; i < 30; i++)
                {
                    System.Console.ForegroundColor = Color[rand.Next(7)];
                    System.Console.SetCursorPosition(rand.Next(100), rand.Next(40));
                    System.Console.Write("Hello World!");
                }
                Thread.Sleep(200);
                //밥솥 
            }
        }
    }
}
