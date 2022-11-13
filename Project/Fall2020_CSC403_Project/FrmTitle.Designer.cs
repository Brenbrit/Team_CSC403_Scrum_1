namespace Fall2020_CSC403_Project
{
    partial class FrmTitle
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
            this.title = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            this.subtitle2 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Desktop;
            this.title.Location = new System.Drawing.Point(172, 80);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(476, 85);
            this.title.TabIndex = 1;
            this.title.Text = "Sic Semper Tyrannis";
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Location = new System.Drawing.Point(301, 398);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(207, 13);
            this.note.TabIndex = 2;
            this.note.Text = "Basic design (to be changed if i have time)";
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.Location = new System.Drawing.Point(94, 165);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(619, 19);
            this.subtitle.TabIndex = 3;
            this.subtitle.Text = "A philisophical journey into the phyche of the etherial plane";
            // 
            // subtitle2
            // 
            this.subtitle2.AutoSize = true;
            this.subtitle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle2.Location = new System.Drawing.Point(329, 184);
            this.subtitle2.Name = "subtitle2";
            this.subtitle2.Size = new System.Drawing.Size(164, 20);
            this.subtitle2.TabIndex = 4;
            this.subtitle2.Text = "(jk its just a random game)";
            // 
            // Play
            // 
            this.Play.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.Location = new System.Drawing.Point(218, 278);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(100, 50);
            this.Play.TabIndex = 5;
            this.Play.Text = "PLAY";
            this.Play.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(480, 278);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 50);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // FrmTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.subtitle2);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.note);
            this.Controls.Add(this.title);
            this.Name = "FrmTitle";
            this.Text = "once upon a time there was a very bored college professor...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Label subtitle2;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Exit;
    }
}