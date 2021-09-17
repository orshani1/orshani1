using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalShapeGame
{
    class Rectangle : Shape
    {
        public override int width { get; set; }
        public override int height { get; set; }
        public override void Draw()
        {
            string shape = "=";
            Random ran = new Random();
            height = ran.Next(1, 35);
            width = ran.Next(1, 24);
            int i = 0;
            while (i <= ran.Next(1, 15))
            {
                if (ScreenValidation.IsThisPlaceFree() == true)
                {
                    Console.SetCursorPosition(width, height);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(shape);
                    i++;
                    height++;
                    ScreenValidation.screenArray[width, height] = 1;
                }
                 else
                {
                    if(width == 25)
                    {
                        width = 20;
                    }
                    if (width < 23)
                    {
                        width++;
                    }
                    else if(width > 0)
                    {
                        width++;
                    }
                }
            }


        }
    }
}
