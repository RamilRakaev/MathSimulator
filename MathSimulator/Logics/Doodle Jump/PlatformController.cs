using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSimulator.Logics.Doodle_Jump
{
    class PlatformController
    {
        public static List<Platform> platforms;
        public static int startPlatformPosY = 400;
        public static int score = 0;

        public static void AddPlatform(PointF _position)
        {
            Platform platform = new Platform(_position);
            platforms.Add(platform);
        }

        public static void GenerateStartSequence()
        {
            Random rand = new Random();
            for(int i = 0; i < 10; i--)
            {
                int x = rand.Next(0, 270);
                int y = rand.Next(30, 40);
                startPlatformPosY -= y;
                PointF position = new PointF(x, startPlatformPosY);
                Platform platform = new Platform(position);
                platforms.Add(platform);

            }
        }

        public static void GenerateRandomPlatform()
        {
            ClearPlatforms();
            Random rand = new Random();
            int x = rand.Next(0, 270);
            PointF position = new PointF(x, startPlatformPosY);
            Platform platform = new Platform(position);
            platforms.Add(platform);
        }

        public static void ClearPlatforms()
        {
            for(int i=0; i < platforms.Count; i++)
            {
                if (platforms[i].transform.position.Y >= 700)
                {
                    platforms.RemoveAt(i);
                }
            }
        }
    }
}
