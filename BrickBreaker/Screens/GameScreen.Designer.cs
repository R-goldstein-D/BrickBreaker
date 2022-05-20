namespace BrickBreaker
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.powerUpTimerLabel = new System.Windows.Forms.Label();
            this.livesLabel = new System.Windows.Forms.Label();
            this.lifeCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // powerUpTimerLabel
            // 
            this.powerUpTimerLabel.AutoSize = true;
            this.powerUpTimerLabel.ForeColor = System.Drawing.Color.White;
            this.powerUpTimerLabel.Location = new System.Drawing.Point(621, 723);
            this.powerUpTimerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.powerUpTimerLabel.Name = "powerUpTimerLabel";
            this.powerUpTimerLabel.Size = new System.Drawing.Size(51, 20);
            this.powerUpTimerLabel.TabIndex = 0;
            this.powerUpTimerLabel.Text = "label1";
            this.powerUpTimerLabel.Visible = false;
            // 
            // livesLabel
            // 
            this.livesLabel.AutoSize = true;
            this.livesLabel.ForeColor = System.Drawing.Color.White;
            this.livesLabel.Location = new System.Drawing.Point(1053, 723);
            this.livesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(60, 20);
            this.livesLabel.TabIndex = 1;
            this.livesLabel.Text = "LIVES:";
            // 
            // lifeCount
            // 
            this.lifeCount.AutoSize = true;
            this.lifeCount.ForeColor = System.Drawing.Color.White;
            this.lifeCount.Location = new System.Drawing.Point(1158, 723);
            this.lifeCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lifeCount.Name = "lifeCount";
            this.lifeCount.Size = new System.Drawing.Size(60, 20);
            this.lifeCount.TabIndex = 2;
            this.lifeCount.Text = "LIVES:";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lifeCount);
            this.Controls.Add(this.livesLabel);
            this.Controls.Add(this.powerUpTimerLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1281, 813);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label powerUpTimerLabel;
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Label lifeCount;
    }
}
