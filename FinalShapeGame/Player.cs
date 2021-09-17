using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalShapeGame
{
    class Player
    {
        public static int flag = 0;
        public static void Write(char toWrite, int x = 0, int y = 0)
        {
            try
            {
                if (x >= 0 && y >= 0) // 0-based
                {

                    Console.SetCursorPosition(x, y);
                    if (ScreenValidation.screenArray[x, y] == 0)
                    {
                        Console.Write(toWrite);
                    }
                    else
                    {
                        Console.Clear();
                        Console.Out.WriteLine("You Lost .. Loading Level2");
                        flag = 1;
                        if (flag == 1)
                        {
                            Game.Level2();
                            flag = 0;
                        }


                    }

                }
            }
            catch (Exception)
            {
            }
        }
        public void DrawPlayer()
        {
            const char toWrite = '*'; // Character to write on-screen.

            int x = 0, y = 0; // Contains current cursor position.
            Write(toWrite);
            while (true)
            {

                if (Console.KeyAvailable)
                {
                    var command = Console.ReadKey().Key;

                    switch (command)
                    {
                        case ConsoleKey.DownArrow:
                            y++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (y > 0)
                            {
                                y--;
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            if (x > 0)
                            {
                                x--;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            x++;
                            break;
                    }
                    if (ScreenValidation.PlayerIsThisPlaceFree(x, y) == true)
                    {
                        Write(toWrite, x, y);
                        ScreenValidation.screenArray[x, y] = 1;

                    }



                }
                else
                {

                }

            }
        }
    }
}
