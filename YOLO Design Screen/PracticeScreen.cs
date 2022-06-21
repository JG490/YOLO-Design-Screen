using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YOLO_Design_Screen.Properties
{
    public partial class Instructions : UserControl
    {
        Random random = new Random();
        Particle p1 = new Particle(300, 200, 50);

        List<Obstacle> obstacles = new List<Obstacle>();

        int tutorialLevel = 0;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool spaceDown = false;
        public Instructions()
        {
            InitializeComponent();
            InitializeGame();
        }
        public void InitializeGame()
        {
            Form1.score = 0;
            tutorialLevel = 0;
        }

        private void Instructions_Load(object sender, EventArgs e)
        {

        }

        private void Instructions_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
            }
        }

        private void Instructions_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
            }
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            if (spaceDown == true)
            {
                tutorialLevel++;
            }
            // to allow the player to play through tutorial
            if (tutorialLevel == 0)
            {
                outputLabel.Text = $"You Only Live Once. Remember that, particle. You have one purpose, and that is to fly. \n Press Space to continue";
            }
            else if (tutorialLevel == 1)
            {
                outputLabel.Text = $"Use the arrow keys to move up and down. This is how you fly, Particle. \n When you have tried that, we will continue,";
            }
            else if (tutorialLevel == 2)
            {
                outputLabel.Text = $"The abyss is a dangerous place, Particle. You will face many obstacles when you try to escape the inescapable place.";
            }
            else if (tutorialLevel == 3)
            {
                outputLabel.Text = $"Debris from a lost Particle. Avoid it!";
                Obstacle Tutorial = new Obstacle (820, 489, Width, Height);
                int width = random.Next(10, 50);
                int height = random.Next(20, 60);
                Tutorial.Collide(p1);
                if (Tutorial.Collide(p1) == true)
                {
                    outputLabel.Text = "You fool! That was pathetic.";
                    p1.lives = 1;
                }
                else
                {
                    outputLabel.Text = "Good job. But you still have much to learn about the nature of the Abyss.";
                }
            }
            else if (tutorialLevel == 4)
            {
                outputLabel.Text = "Look at your structural integrity gauge above. If that reaches 0, it is over. And you don't want it to be over, do you?";
            }
            else if (tutorialLevel == 5)
            {
                outputLabel.Text = "Play wisely. You only live once. Now, we can practice for a little longer if you like, or you can try the real thing. Just remember, YOLO";
            }
            else if (tutorialLevel == 6)
            {
                Form1.score++;
            }
            liveLabel.Text = $"{p1.lives}";
            //create obstacles 
            if (Form1.score % 10 == 0)
            {
                int y = random.Next(1, 489);
                int width = random.Next(10, 50);
                int height = random.Next(20, 60);
                Obstacle barrier = new Obstacle(820, y, width, height);
                obstacles.Add(barrier);
            }
            //move obstacles
            foreach (Obstacle obstacle in obstacles)
            {
                obstacle.Move();
                obstacle.Collide(p1);
                if (obstacle.Collide(p1) == true || p1.lives > 1)
                {
                    p1.lives--;
                }
            }
            //move particle up and down.
            if (upArrowDown == true)
            {
                p1.Move("up");
            }
            if (downArrowDown == true)
            {
                p1.Move("down");
            }
            Refresh();
        }

        private void Instructions_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DarkGoldenrod, p1.x, p1.y, p1.width, p1.height);
            foreach (Obstacle o in obstacles)
            {
                e.Graphics.FillRectangle(Brushes.White, o.x, o.y, o.width, o.height);
            }
        }
    }
}
