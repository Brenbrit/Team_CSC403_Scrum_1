namespace Fall2020_CSC403_Project
{
    partial class FrmKillOrSpare
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Kill = new System.Windows.Forms.Button();
            this.Spare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kill or Spare\r\nyour foe?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Kill
            // 
            this.Kill.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kill.ForeColor = System.Drawing.Color.Red;
            this.Kill.Location = new System.Drawing.Point(100, 225);
            this.Kill.Name = "Kill";
            this.Kill.Size = new System.Drawing.Size(125, 50);
            this.Kill.TabIndex = 1;
            this.Kill.Text = "KILL";
            this.Kill.UseVisualStyleBackColor = true;
            // 
            // Spare
            // 
            this.Spare.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spare.ForeColor = System.Drawing.Color.Red;
            this.Spare.Location = new System.Drawing.Point(360, 225);
            this.Spare.Name = "Spare";
            this.Spare.Size = new System.Drawing.Size(125, 50);
            this.Spare.TabIndex = 2;
            this.Spare.Text = "SPARE";
            this.Spare.UseVisualStyleBackColor = true;
            // 
            // FrmKillOrSpare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Spare);
            this.Controls.Add(this.Kill);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "FrmKillOrSpare";
            this.Text = "Choose...";
            this.Load += new System.EventHandler(this.FrmKillOrSpare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Kill;
        private System.Windows.Forms.Button Spare;
    }
}