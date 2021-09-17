using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalShapeGame
{
    class Triangle : Shape
    {
        public override int width { get ; set; }
        public override int height { get ; set ; }

        public override void Draw()
        {
            string shape = "#";
            Random ran = new Random();
            width = ran.Next(1,25);
            height = ran.Next(1,35);
            
            for (int i = 0; i < ran.Next(1,11); i++)
            {
                if (ScreenValidation.IsThisPlaceFree() == true)
                {
                    Console.SetCursorPosition(width, height);
                    for (int j = 0; j < i; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(shape);
                    }
                    height++;
                    ScreenValidation.screenArray[width,height] = 1;
                }
                else
                {
                    Console.SetCursorPosition(width++, height++);

                }
            }
            
        }

    }
}
