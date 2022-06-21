using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace YOLO_Design_Screen
{
    public partial class GameScreen : UserControl
    {
        Random random = new Random();
        Particle p1 = new Particle(300, 200, 50);

        List<Obstacle> obstacles = new List<Obstacle>();
        List<HighScore> scores = new List<HighScore>();

        bool upArrowDown = false;
        bool downArrowDown = false;

        SoundPlayer explosion = new SoundPlayer (Properties.Resources.Damage);
        
        public GameScreen()
        {
            InitializeComponent();
            InitializeGame();
        }
        public void InitializeGame()
        {
            Form1.score = 0;
            scoreLabel.Text = $"{Form1.score}";
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DarkGoldenrod, p1.x, p1.y, p1.width, p1.height);
            foreach (Obstacle o in obstacles)
            {
                e.Graphics.FillRectangle(Brushes.White, o.x, o.y, o.width, o.height);
            }
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }
        private void gametimer_Tick_1(object sender, EventArgs e)
        {
            liveLabel.Text = $"{p1.lives}";
            //score
            Form1.score++; 
            scoreLabel.Text = $"{Form1.score}";
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
                if (obstacle.Collide(p1) == true)
                {
                    p1.lives--;
                    explosion.Play();
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
            //life lost/gameover conditions
            if (p1.lives <= 0)
            {
                gametimer.Stop();
                Form1.ChangeScreen(this, new GameOver());
            }
            //make the game more difficult as it goes on
            if (Form1.score % 100 == 0)
            {
                foreach (Obstacle obstacle in obstacles)
                {
                    obstacle.speed++;
                }
            }
            Refresh();
        }
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }
        }
    }
}
