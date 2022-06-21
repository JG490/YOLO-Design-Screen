namespace YOLO_Design_Screen.Properties
{
    partial class Instructions
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
            this.liveLabel = new System.Windows.Forms.Label();
            this.structuralLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // liveLabel
            // 
            this.liveLabel.AutoSize = true;
            this.liveLabel.BackColor = System.Drawing.Color.Transparent;
            this.liveLabel.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveLabel.ForeColor = System.Drawing.Color.Red;
            this.liveLabel.Location = new System.Drawing.Point(104, 15);
            this.liveLabel.Name = "liveLabel";
            this.liveLabel.Size = new System.Drawing.Size(88, 13);
            this.liveLabel.TabIndex = 8;
            this.liveLabel.Text = "liveLabel";
            // 
            // structuralLabel
            // 
            this.structuralLabel.AutoSize = true;
            this.structuralLabel.BackColor = System.Drawing.Color.Transparent;
            this.structuralLabel.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.structuralLabel.ForeColor = System.Drawing.Color.Red;
            this.structuralLabel.Location = new System.Drawing.Point(3, 15);
            this.structuralLabel.Name = "structuralLabel";
            this.structuralLabel.Size = new System.Drawing.Size(97, 13);
            this.structuralLabel.TabIndex = 9;
            this.structuralLabel.Text = "Integrity:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.outputLabel.Location = new System.Drawing.Point(3, 134);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(781, 13);
            this.outputLabel.TabIndex = 10;
            this.outputLabel.Text = "You Only Live Once. Remember that, particle. You have one purpose, and that is to" +
    " fly.";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.structuralLabel);
            this.Controls.Add(this.liveLabel);
            this.Name = "Instructions";
            this.Size = new System.Drawing.Size(816, 489);
            this.Load += new System.EventHandler(this.Instructions_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Instructions_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Instructions_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Instructions_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label liveLabel;
        private System.Windows.Forms.Label structuralLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Timer gametimer;
    }
}
