using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSimulator.Logics.Flappy_Bird
{
    class Obstacles
    {
        public int X;
        public int Y;
        public Image obstaclesImg;

        public int Weight;
        public int Height;

        public Obstacles(int x, int y,bool isRotatedImage=false)
        {
            obstaclesImg = new Bitmap(Resource.Pipe);
            X = x;
            Y = y;
            Weight = 50; 
            Height = 300;
            if (isRotatedImage)
            {
                obstaclesImg.RotateFlip(RotateFlipType.Rotate180FlipX);
            }
        }
    }
}
