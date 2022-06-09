using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace YOLO_Design_Screen
{
    internal class Particle
    {
        public int width = 50;
        public int height = 10;
        public int speed = 6;
        public int x, y;
        public int lives = 1;

        public Particle(int _x, int _y, int _lives)
        {
            x = _x;
            y = _y;
            lives = _lives;
        }
        public void Move(string direction)
        {
            if (direction == "up"  && y > 0)
            {
                y -= speed;
            }
            if (direction == "down" && y < 489 - height)
            {
                y += speed;
            }
        }

    }
}
