using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalShapeGame
{
    class ScreenValidation
    {
       public static int[,] screenArray = new int[121,121];
        public static bool IsThisPlaceFree()
        {
           
            for (int i = 0; i < screenArray.GetLength(1); i++)
            {
                for (int j = 0; j < screenArray.GetLength(0); j++)
                {
                    if(screenArray[i,j] == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool PlayerIsThisPlaceFree(int x,int y)
        {
            

            for (int i = 0; i <= screenArray.GetLength(1); i++)
            {
                for (int j = 0; j <= screenArray.GetLength(0); j++)
                {
                    if (screenArray[i, j] == 0)
                    {
                        return true;

                    }

                    else
                    {
                        return false;
                    }

                }
                
            }
            return false;

        }
       
    }
}
