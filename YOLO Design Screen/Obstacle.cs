using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace YOLO_Design_Screen
{
    internal class Obstacle
    {
        Random random = new Random();
        public int width = 50;
        public int height = 10;
        public int speed = 10;
        public int x, y;

        public Obstacle(int _x, int _y, int _width, int _height)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
        }
        public void Move()
        {
            x = x - speed * 2;
        }
        public bool Collide(Particle p)
        {
            Rectangle obstacle = new Rectangle(x, y, width, height);
            Rectangle particle = new Rectangle(p.x,p.y, p.width, p.height);
            if (obstacle.IntersectsWith(particle))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
