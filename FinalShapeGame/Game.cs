using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalShapeGame
{
    class Game
    {
        public static int Count { get; set; }
        public void Run()
        {
            Shape triangle = new Triangle();
            Shape square = new Square();    
            Shape rectangle = new Rectangle();
            Player myplayer = new Player();
            rectangle.Draw();
            triangle.Draw();
            square.Draw();
            myplayer.DrawPlayer();
            Console.ReadKey(true);
        }
        public static void Level2()
        {
            Count++;
            Console.WriteLine("Welcome To Finale More Drawing Will Occure in this matter\nPress Enter To Advance\nESC for Exit");
            var command = Console.ReadKey().Key;
            if (command == ConsoleKey.Enter)
            {


                Shape triangle = new Triangle();
                Shape rectangle = new Rectangle();
                Shape square = new Square();
                square.Draw();
                square.Draw();
                rectangle.Draw();
                rectangle.Draw();
                triangle.Draw();
                triangle.Draw();
            }
            if (command == ConsoleKey.Escape)
            {
                return;
            }
            if (Count > 4)
            {
                Console.Clear();
                Console.WriteLine($"The Game Was Ended You Completed {Count} Rounds");
                Console.ReadKey(false);
               
            }

        }
    }
}
