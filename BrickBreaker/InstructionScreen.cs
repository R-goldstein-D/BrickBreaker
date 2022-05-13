using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class InstructionScreen : UserControl
    {
        public InstructionScreen()
        {
            InitializeComponent();

            instructionLabel.Text = "Instructions";

            instructionLabel.ForeColor = Color.Yellow;

            instructionLabel.Text += "\n\nControls";
            instructionLabel.Text += "\nUse Arrow Keys to move the paddle left or right.";
            instructionLabel.Text += "\n\nGoal";
            instructionLabel.Text += "\nYour goal is to break all bricks on screen by bouncing " +
                "the ball off of the paddle to hit the bricks.";
            instructionLabel.Text += "\n\nPower Ups";
            instructionLabel.Text += "\nWhen a brick is broken there is a chance for a power up to spawn.";
            instructionLabel.BackColor = Color.Transparent;

            returnButton.Text = "Return";
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            MenuScreen ms = new MenuScreen();
            Form form = this.FindForm();

            form.Controls.Add(ms);
            form.Controls.Remove(this);

            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
        }
    }
}
