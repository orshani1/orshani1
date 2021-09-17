using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalShapeGame
{
    abstract class Shape : IShapeDetails
    {
        abstract public int width { get; set; }
        abstract public int height { get; set; }
        public abstract void Draw();
  

    }
}
