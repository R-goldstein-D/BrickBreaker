namespace BrickBreaker
{
    partial class InstructionScreen
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
            this.controlInstrctionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // controlInstrctionsLabel
            // 
            this.controlInstrctionsLabel.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlInstrctionsLabel.Location = new System.Drawing.Point(131, 29);
            this.controlInstrctionsLabel.Name = "controlInstrctionsLabel";
            this.controlInstrctionsLabel.Size = new System.Drawing.Size(596, 394);
            this.controlInstrctionsLabel.TabIndex = 0;
            this.controlInstrctionsLabel.Text = "controlInstructionsLabel";
            // 
            // InstructionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlInstrctionsLabel);
            this.Name = "InstructionScreen";
            this.Size = new System.Drawing.Size(850, 550);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label controlInstrctionsLabel;
    }
}
