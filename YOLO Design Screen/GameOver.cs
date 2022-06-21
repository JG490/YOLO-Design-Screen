using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YOLO_Design_Screen
{
    public partial class GameOver : UserControl
    {
        public GameOver()
        {
            InitializeComponent();

            scoreLabel.Text = $"Score: {Form1.score}";
            List <HighScore> scores = new List<HighScore>();
            // list to store all values from object list as strings 
            List<string> tempList = new List<string>();

            // Add all info from each HighScore object to temp list 
            foreach (HighScore hs in scores)
            {
                tempList.Add(hs.name);
                tempList.Add(Convert.ToString(hs.score));
            }

            File.WriteAllLines("highscoreFile.txt", tempList);


            //read Highscores. 
            List<string> scoreList = File.ReadAllLines("HighscoreFile.txt").ToList();
            highScoreLabel.Text = $"Highscore: {scoreList.Count.ToString()}";

            for (int i = 0; i < scoreList.Count; i += 2)
            {
                string name = scoreList[i];
                int score = Convert.ToInt32(scoreList[i + 1]);

                HighScore hs = new HighScore(name, score);
                scores.Add(hs);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            //returns to main menu
            Form1.ChangeScreen(this, new MainMenu());
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            //plays again
            Form1.ChangeScreen(this, new GameScreen());
        }
    }
}
