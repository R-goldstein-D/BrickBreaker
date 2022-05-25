namespace BrickBreaker
{
    partial class GameoverScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.yousuckLabel = new System.Windows.Forms.Label();
            this.highscoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(312, 293);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(194, 77);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // yousuckLabel
            // 
            this.yousuckLabel.AutoSize = true;
            this.yousuckLabel.Location = new System.Drawing.Point(296, 96);
            this.yousuckLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yousuckLabel.Name = "yousuckLabel";
            this.yousuckLabel.Size = new System.Drawing.Size(228, 13);
            this.yousuckLabel.TabIndex = 3;
            this.yousuckLabel.Text = "You don\'t mind watching someone eat do you?";
            // 
            // highscoreLabel
            // 
            this.highscoreLabel.AutoSize = true;
            this.highscoreLabel.Location = new System.Drawing.Point(369, 164);
            this.highscoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.highscoreLabel.Name = "highscoreLabel";
            this.highscoreLabel.Size = new System.Drawing.Size(56, 13);
            this.highscoreLabel.TabIndex = 4;
            this.highscoreLabel.Text = "high score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "High Scores";
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.White;
            this.restartButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(312, 208);
            this.restartButton.Margin = new System.Windows.Forms.Padding(4);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(194, 77);
            this.restartButton.TabIndex = 6;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // GameoverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.highscoreLabel);
            this.Controls.Add(this.yousuckLabel);
            this.Controls.Add(this.exitButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameoverScreen";
            this.Size = new System.Drawing.Size(854, 542);
            this.Load += new System.EventHandler(this.GameoverScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label yousuckLabel;
        private System.Windows.Forms.Label highscoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button restartButton;
    }
}
