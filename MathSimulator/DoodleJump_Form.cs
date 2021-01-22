using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathSimulator.Logics.Doodle_Jump;
using System.Windows.Forms;

namespace MathSimulator
{
    public partial class DoodleJump_Form : Form
    {
        Player player;
        Timer timer;
        public DoodleJump_Form()
        {
            InitializeComponent();
            
            Init();
            timer = new Timer();
            timer.Interval = 15;
            timer.Tick += new EventHandler(Update);
            timer.Start();
            //KeyDown += new KeyEventHandler(OnKeyboardPressed);
            //KeyUp += new KeyEventHandler(OnKeyboardUp);
            BackgroundImage = Resource.background_doodle_jump;
            Height = 600;
            Paint += new PaintEventHandler(OnRepaint);
        }

        public void Init()
        {
            PlatformController.platforms = new List<Platform>();
            PlatformController.AddPlatform(new PointF(100, 400));
            PlatformController.startPlatformPosY = 400;
            PlatformController.score = 0;
            player = new Player();
        }

        private void OnKeyboardUp(object sender,KeyEventArgs e)
        {
            player.physics.dx = 0;
        }

        private void OnKeyboardPressed(object sender,KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    player.physics.dx = 6;
                    break;
                case "Left":
                    player.physics.dx = -6;
                    break;
            }

        }

        private void Update(object sender, EventArgs e)
        {
            if(!Score_Tbx.Focused)
                Score_Tbx.Focus();
            
            Score_Tbx.Text = PlatformController.score.ToString();
            if (player.physics.transform.position.Y >= PlatformController.platforms[0].transform.position.Y + 200)
            {
                Init();
            }
            player.physics.ApplyPhysics();
            FollowPlayer();
            Invalidate();
        }

        public void FollowPlayer()
        {
            int offset = 400 - (int)player.physics.transform.position.Y;
            player.physics.transform.position.Y += offset;
            for(int i = 0; i < PlatformController.platforms.Count; i++)
            {
                var platform = PlatformController.platforms[i];
                platform.transform.position.Y += offset;
            }
        }
        private void OnRepaint(object sender,PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (PlatformController.platforms.Count > 0)
            {
                for(int i = 0; i < PlatformController.platforms.Count; i++)
                {
                    PlatformController.platforms[i].DrawSprite(g);
                }
            }
            player.DrawSprite(g);
        }

   
    }
}
