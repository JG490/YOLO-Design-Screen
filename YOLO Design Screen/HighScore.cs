using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace YOLO_Design_Screen
{
    internal class HighScore
    {
        public string name;
        public int score;

        public HighScore(string _name, int _score)
        {
            name = _name;
            score = _score;
        }

    }
}
