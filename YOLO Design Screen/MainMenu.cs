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
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Goes to the game screen
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //ends application.
            Application.Exit();
        }

        private void creditButton_Click(object sender, EventArgs e)
        {
            //change to credit screen
            Form1.ChangeScreen(this, new CreditScreen());
        }
    }
}
