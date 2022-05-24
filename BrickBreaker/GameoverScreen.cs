﻿/*  Created by: Ria, Charles, Owen, Joey, Hewan, David
 *  Project: Brick Breaker
 *  Date: May 25, 2021
 */
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
    public partial class GameoverScreen : UserControl
    {
        public GameoverScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameoverScreen_Load(object sender, EventArgs e)
        {
            int score = Form1.scoreList.Count - 1;
            highscoreLabel.Text = $"{score}";

            // add score to scorelist and refresh scorelist
            Form1.scoreList.Add(score);
            Form1.scoreList.Sort();
            Form1.scoreList.Reverse();

            //if scorelist is longer than five scores, get rid of lowest scores
            if (Form1.scoreList.Count() > 5)
            {
                Form1.scoreList.RemoveRange(5, (Form1.scoreList.Count() - 5));
            }

            for (int i = 0; i < Form1.scoreList.Count; i++)
            {
                highscoreLabel.Text += $"\n{Form1.scoreList[i]}";
            }
        }
    }
}
