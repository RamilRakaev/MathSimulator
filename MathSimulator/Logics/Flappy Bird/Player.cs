using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSimulator.Logics
{
    class Player
    {
        public float X;
        public float Y;
        public Image birdImg;

        public ulong score=0;
        public int size;

        public bool isAlive;

        public float gravityValue;
        public Player(int x,int y)
        {
            birdImg = new Bitmap(Resource.Bird);
            X = x;
            Y = y;
            size = 50;
            gravityValue = 0.7f;
            isAlive = true;
        }
    }
}
