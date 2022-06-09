namespace YOLO_Design_Screen
{
    partial class GameOver
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
            this.creditLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.liveLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.ForeColor = System.Drawing.Color.Red;
            this.creditLabel.Location = new System.Drawing.Point(206, 9);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(388, 66);
            this.creditLabel.TabIndex = 2;
            this.creditLabel.Text = "GAME 0VER";
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.returnButton.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(295, 379);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(222, 81);
            this.returnButton.TabIndex = 4;
            this.returnButton.Text = "RETURN";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // liveLabel
            // 
            this.liveLabel.AutoSize = true;
            this.liveLabel.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveLabel.ForeColor = System.Drawing.Color.Red;
            this.liveLabel.Location = new System.Drawing.Point(219, 66);
            this.liveLabel.Name = "liveLabel";
            this.liveLabel.Size = new System.Drawing.Size(348, 66);
            this.liveLabel.TabIndex = 5;
            this.liveLabel.Text = "L1ves: 0";
            this.liveLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.playAgainButton.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainButton.ForeColor = System.Drawing.Color.White;
            this.playAgainButton.Location = new System.Drawing.Point(295, 279);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(222, 79);
            this.playAgainButton.TabIndex = 6;
            this.playAgainButton.Text = "D1E AGA1N";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Red;
            this.scoreLabel.Location = new System.Drawing.Point(219, 132);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(428, 66);
            this.scoreLabel.TabIndex = 7;
            this.scoreLabel.Text = "Score: 756";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.highScoreLabel.Location = new System.Drawing.Point(87, 198);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(628, 66);
            this.highScoreLabel.TabIndex = 8;
            this.highScoreLabel.Text = "Highscore: More";
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.liveLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.creditLabel);
            this.Name = "GameOver";
            this.Size = new System.Drawing.Size(816, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label liveLabel;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label highScoreLabel;
    }
}
