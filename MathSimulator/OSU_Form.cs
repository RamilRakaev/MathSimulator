using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathSimulator
{
    public partial class OSU_Form : Form
    {
        public Bitmap HandlerTexture = Resource.Cicrle,
            TargetTexture = Resource.Target;
        private Point TargetPosition = new Point(300,300);

        private Point Direction = Point.Empty;

        private int Scope = 0;

        private int maxWidth = 0;
        private int maxHeight = 0;
        public OSU_Form()
        {
            
            InitializeComponent();
            maxWidth = Size.Width-50;
            maxHeight = Size.Height-50;
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            timer2.Interval = rand.Next(25, 1000);
            Direction.X = rand.Next(-1, 2);
            Direction.Y = rand.Next(-1, 2);
        }

        private void OSU_Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            var locPos = this.PointToClient(Cursor.Position);

            TargetPosition.X += Direction.X*10;
            TargetPosition.Y += Direction.Y*10;

            if (TargetPosition.X < 0  || TargetPosition.X > maxWidth)
            {
                Direction.X *= -1;
            } 
            if (TargetPosition.Y < 0  || TargetPosition.Y > maxHeight)
            {
                Direction.Y *= -1;
            }

            Point between = new Point(locPos.X - TargetPosition.X, locPos.Y - TargetPosition.Y);
            float dist =(float) Math.Sqrt(between.X * between.X + between.Y * between.Y);

            if (dist < 20)
            {
                AddScope(20-Convert.ToInt32(dist));
            }

            var targRect = new Rectangle(TargetPosition.X, TargetPosition.Y, 100, 100);
            var handRect = new Rectangle(locPos.X - 50, locPos.Y - 50, 100, 100);
            graphics.DrawImage(HandlerTexture, targRect);

            graphics.DrawImage(TargetTexture, handRect );
        }

        private void OSU_Form_Resize(object sender, EventArgs e)
        {
            maxWidth = Size.Width - 50;
            maxHeight = Size.Height - 50;
        }

        private void AddScope(int _scope)
        {
            Scope += _scope;
            Scope_Lbl.Text = Scope.ToString();
        }
    }
}
