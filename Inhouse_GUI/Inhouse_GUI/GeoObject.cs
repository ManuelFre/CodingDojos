using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhouse_GUI
{
    class GeoObject
    {
        
        public String Shape { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public GeoObject(string shape, int posX, int posY, int width, int height)
        {
            Shape = shape;
            PosX = posX;
            PosY = posY;
            Width = width;
            Height = height;
        }



    }
}
