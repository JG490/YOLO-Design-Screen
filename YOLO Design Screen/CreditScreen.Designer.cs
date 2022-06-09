namespace YOLO_Design_Screen
{
    partial class CreditScreen
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
            this.joeyLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.creditLabel.Location = new System.Drawing.Point(268, 41);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(268, 66);
            this.creditLabel.TabIndex = 1;
            this.creditLabel.Text = "CRED1T";
            // 
            // joeyLabel
            // 
            this.joeyLabel.AutoSize = true;
            this.joeyLabel.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joeyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.joeyLabel.Location = new System.Drawing.Point(40, 134);
            this.joeyLabel.Name = "joeyLabel";
            this.joeyLabel.Size = new System.Drawing.Size(748, 66);
            this.joeyLabel.TabIndex = 2;
            this.joeyLabel.Text = "A JOEY GERBER GAME";
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.returnButton.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(301, 245);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(208, 58);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "RETURN";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // CreditScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.joeyLabel);
            this.Controls.Add(this.creditLabel);
            this.Name = "CreditScreen";
            this.Size = new System.Drawing.Size(816, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Label joeyLabel;
        private System.Windows.Forms.Button returnButton;
    }
}
