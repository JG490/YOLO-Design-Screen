using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YOLO_Design_Screen
{
    public partial class GameOver : UserControl
    {
        public GameOver()
        {
            InitializeComponent();
            scoreLabel.Text = $"Score: {Form1.score}";
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
