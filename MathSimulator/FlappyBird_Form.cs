using MathSimulator.Logics;
using MathSimulator.Logics.Flappy_Bird;
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
    public partial class FlappyBird_Form : Form
    {
        Player bird;
        List<Obstacles> Obstaclesses = new List<Obstacles>();
        Obstacles highObstacles;
        Obstacles bottomObstacles;
        float gravity;

        private void EstablishObstaclesses()
        {
            int j = 0;
            for(int i = 0; i < 10; i+=2)
            {
                Obstaclesses.Add(new Obstacles(400+j,-80,true));
                Obstaclesses.Add(new Obstacles(400+j, -250));
                j += 100;
            }
        }

        private void MoveOstaclesses()
        {
            for (int i = 0; i < 10; i += 2)
            {
                Obstaclesses[i].X += -4;
                Obstaclesses[i+1].X += -4;
                CreateObstacles(Obstaclesses[i], Obstaclesses[i + 1]);
            }
        }

        private void CreateObstacles(Obstacles obstacles1,Obstacles obstacles2)
        {
            if (obstacles1.X < bird.X - 100)
            {
                Random rand = new Random();
                int y1 = rand.Next(-140, 0);

                obstacles1 = new Obstacles(400, y1, true);
                obstacles2 = new Obstacles(400, y1 + 300);
                Score_Lbl.Text = (++bird.score).ToString();
            }
        }

        private void InitObstacles(Obstacles obstacles1, Obstacles obstacles2)
        {
            bird = new Player(100, 200);
            obstacles1 = new Obstacles(400, -80, true);
            obstacles2 = new Obstacles(400, 250);
            gravity = 0;
            Flappy_Tmr.Start();
        }

        public FlappyBird_Form()
        {
            InitializeComponent();
            Flappy_Tmr.Tick += new EventHandler(Update);
            
            Init();
            Invalidate();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        private void Init()
        {
            bird = new Player(100,200);
            highObstacles = new Obstacles(400, -110, true);
            bottomObstacles = new Obstacles(400, 290);

            gravity = 0;
            Flappy_Tmr.Start();

        }

        private void FlappyBird_Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawImage(bird.birdImg, bird.X, bird.Y,bird.size,bird.size);

            graphics.DrawImage(highObstacles.obstaclesImg, highObstacles.X, highObstacles.Y, highObstacles.Weight, highObstacles.Height);
            graphics.DrawImage(bottomObstacles.obstaclesImg, bottomObstacles.X, bottomObstacles.Y, bottomObstacles.Weight, bottomObstacles.Height);

            //Graphics graphics = e.Graphics;
            //graphics.DrawImage(bird.birdImg, bird.X, bird.Y, bird.size, bird.size);
            //for (int i = 0; i < Obstaclesses.Count; i += 2)
            //{
            //    graphics.DrawImage(Obstaclesses[i].obstaclesImg, Obstaclesses[i].X, Obstaclesses[i].Y, Obstaclesses[i].Weight, Obstaclesses[i].Height);
            //    graphics.DrawImage(Obstaclesses[i + 1].obstaclesImg, Obstaclesses[i + 1].X, Obstaclesses[i + 1].Y, Obstaclesses[i + 1].Weight, Obstaclesses[i + 1].Height);
            //}
        }

        private void Update(Object sender, EventArgs e)
        {
            if (Collide(bird, highObstacles ) | bird.Y+bird.size > this.Height | bird.Y< -10)
            {
                bird.isAlive = false;
                Flappy_Tmr.Stop();
                Init();
            }
            if (bird.gravityValue != 0.1f)
            {
                bird.gravityValue += 0.005f;
            }
            gravity += bird.gravityValue;
            bird.Y += gravity;
            if (bird.isAlive)
            {
                MovePipes();
            }
            Invalidate();
        }

        private bool Collide(Player _bird,Obstacles _obstacles)
        {
            if ((_bird.size + _bird.X) >= _obstacles.X & (_obstacles.X + _obstacles.Weight) > _bird.X)
                if (_bird.Y+bird.size < (_obstacles.Height - (_obstacles.Y * -1)) | _bird.Y > _obstacles.Y+ _obstacles.Height+70)
                    return true;
                return false;
        }
        private void MovePipes()
        {
            highObstacles.X += -4;
            bottomObstacles.X += -4;
            CreatePipes();
        }

        private void CreatePipes()
        {
            if (highObstacles.X < bird.X-200)
            {
                Random rand = new Random();
                int y1= rand.Next(-140, 0);

                highObstacles = new Obstacles(400, y1, true);
                bottomObstacles = new Obstacles(400, y1+400);
                Score_Lbl.Text=(++bird.score).ToString();
            }
        }
        private void Force_Btn_Click(object sender, EventArgs e)
        {
            if (bird.isAlive)
            {
                bird.gravityValue = -0.075f;
            }
        }
    }
}
