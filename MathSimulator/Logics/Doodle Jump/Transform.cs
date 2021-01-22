using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSimulator.Logics.Doodle_Jump
{
    class Transform
    {
        public PointF position;
        public Size size;

        
        public Transform(PointF _position, Size _size)
        {
            position = _position;
            size = _size;
        }
    }
}
