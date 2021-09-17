using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalShapeGame
{
    class Square : Shape
    {
        public override int width { get; set; }
        public override int height { get; set; }

        public override void Draw()
        {
            string shape = "O";
            Random ran = new Random();
            width = ran.Next(1, 25);
            int sideLength = ran.Next(1, 11);
            height = ran.Next(1, 35);

            for (int row = 1; row <= sideLength; row++)
            {
                if (ScreenValidation.IsThisPlaceFree() == true)
                {
                    Console.SetCursorPosition(width, height);
                    for (int col = 1; col <= sideLength; col++)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        if (col <= row)
                            Console.Write('O');
                        else
                            Console.Write('#');
                    }
                    height++;
                    ScreenValidation.screenArray[width, height] = 1;
                }
                else
                {
                    Console.SetCursorPosition(width++, height++);
                }
            }
        }
    }
}
