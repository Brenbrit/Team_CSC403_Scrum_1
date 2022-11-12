namespace Fall2020_CSC403_Project {
  partial class FrmLevelIESB {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.lblInGameTime = new System.Windows.Forms.Label();
      this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
      this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
      this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
      this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
      this.picBossKoolAid = new System.Windows.Forms.PictureBox();
      this.picPlayer = new System.Windows.Forms.PictureBox();
      this.picWall5 = new System.Windows.Forms.PictureBox();
      this.picWall4 = new System.Windows.Forms.PictureBox();
      this.picWall10 = new System.Windows.Forms.PictureBox();
      this.picWall6 = new System.Windows.Forms.PictureBox();
      this.picWall9 = new System.Windows.Forms.PictureBox();
      this.picWall0 = new System.Windows.Forms.PictureBox();
      this.picWall7 = new System.Windows.Forms.PictureBox();
      this.picWall8 = new System.Windows.Forms.PictureBox();
      this.picWall1 = new System.Windows.Forms.PictureBox();
      this.picWall2 = new System.Windows.Forms.PictureBox();
      this.picWall3 = new System.Windows.Forms.PictureBox();
      this.heal1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.heal1)).BeginInit();
      this.SuspendLayout();
      // 
      // lblInGameTime
      // 
      this.lblInGameTime.AutoSize = true;
      this.lblInGameTime.BackColor = System.Drawing.Color.Black;
      this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblInGameTime.ForeColor = System.Drawing.Color.White;
      this.lblInGameTime.Location = new System.Drawing.Point(12, 9);
      this.lblInGameTime.Name = "lblInGameTime";
      this.lblInGameTime.Size = new System.Drawing.Size(46, 18);
      this.lblInGameTime.TabIndex = 2;
      this.lblInGameTime.Text = "label1";
      this.lblInGameTime.Click += new System.EventHandler(this.lblInGameTime_Click);
      // 
      // tmrUpdateInGameTime
      // 
      this.tmrUpdateInGameTime.Enabled = true;
      this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
      // 
      // tmrPlayerMove
      // 
      this.tmrPlayerMove.Enabled = true;
      this.tmrPlayerMove.Interval = 10;
      this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
      // 
      // picEnemyCheeto
      // 
      this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
      this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.anky;
      this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picEnemyCheeto.Location = new System.Drawing.Point(468, 146);
      this.picEnemyCheeto.Name = "picEnemyCheeto";
      this.picEnemyCheeto.Size = new System.Drawing.Size(144, 103);
      this.picEnemyCheeto.TabIndex = 5;
      this.picEnemyCheeto.TabStop = false;
      // 
      // picEnemyPoisonPacket
      // 
      this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
      this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.guice;
      this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picEnemyPoisonPacket.Location = new System.Drawing.Point(399, 493);
      this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
      this.picEnemyPoisonPacket.Size = new System.Drawing.Size(153, 157);
      this.picEnemyPoisonPacket.TabIndex = 4;
      this.picEnemyPoisonPacket.TabStop = false;
      // 
      // picBossKoolAid
      // 
      this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
      this.picBossKoolAid.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.question_mark;
      this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picBossKoolAid.Location = new System.Drawing.Point(105, 100);
      this.picBossKoolAid.Name = "picBossKoolAid";
      this.picBossKoolAid.Size = new System.Drawing.Size(157, 118);
      this.picBossKoolAid.TabIndex = 1;
      this.picBossKoolAid.TabStop = false;
      // 
      // picPlayer
      // 
      this.picPlayer.BackColor = System.Drawing.Color.Transparent;
      this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.MrPeanut;
      this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picPlayer.Location = new System.Drawing.Point(949, 530);
      this.picPlayer.Name = "picPlayer";
      this.picPlayer.Size = new System.Drawing.Size(54, 106);
      this.picPlayer.TabIndex = 0;
      this.picPlayer.TabStop = false;
      // 
      // picWall5
      // 
      this.picWall5.BackColor = System.Drawing.Color.Transparent;
      this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.popcorn;
      this.picWall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall5.Location = new System.Drawing.Point(2, 656);
      this.picWall5.Name = "picWall5";
      this.picWall5.Size = new System.Drawing.Size(358, 67);
      this.picWall5.TabIndex = 6;
      this.picWall5.TabStop = false;
      // 
      // picWall4
      // 
      this.picWall4.BackColor = System.Drawing.Color.Transparent;
      this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.popcorn;
      this.picWall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall4.Location = new System.Drawing.Point(2, 386);
      this.picWall4.Name = "picWall4";
      this.picWall4.Size = new System.Drawing.Size(82, 271);
      this.picWall4.TabIndex = 7;
      this.picWall4.TabStop = false;
      // 
      // picWall10
      // 
      this.picWall10.BackColor = System.Drawing.Color.Transparent;
      this.picWall10.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.popcorn;
      this.picWall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall10.Location = new System.Drawing.Point(740, 270);
      this.picWall10.Name = "picWall10";
      this.picWall10.Size = new System.Drawing.Size(241, 182);
      this.picWall10.TabIndex = 8;
      this.picWall10.TabStop = false;
      // 
      // picWall6
      // 
      this.picWall6.BackColor = System.Drawing.Color.Transparent;
      this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.popcorn;
      this.picWall6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall6.Location = new System.Drawing.Point(357, 656);
      this.picWall6.Name = "picWall6";
      this.picWall6.Size = new System.Drawing.Size(358, 67);
      this.picWall6.TabIndex = 9;
      this.picWall6.TabStop = false;
      // 
      // picWall9
      // 
      this.picWall9.BackColor = System.Drawing.Color.Transparent;
      this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.popcorn;
      this.picWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall9.Location = new System.Drawing.Point(180, 270);
      this.picWall9.Name = "picWall9";
      this.picWall9.Size = new System.Drawing.Size(274, 182);
      this.picWall9.TabIndex = 10;
      this.picWall9.TabStop = false;
      // 
      // picWall0
      // 
      this.picWall0.BackColor = System.Drawing.Color.Transparent;
      this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.popcorn;
      this.picWall0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall0.Location = new System.Drawing.Point(2, 1);
      this.picWall0.Name = "picWall0";
      this.picWall0.Size = new System.Drawing.Size(82, 388);
      this.picWall0.TabIndex = 12;
      this.picWall0.TabStop = false;
      // 
      // picWall7
      // 
      this.picWall7.BackColor = System.Drawing.Color.Transparent;
      this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.popcorn;
      this.picWall7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall7.Location = new System.Drawing.Point(714, 656);
      this.picWall7.Name = "picWall7";
      this.picWall7.Size = new System.Drawing.Size(380, 67);
      this.picWall7.TabIndex = 14;
      this.picWall7.TabStop = false;
      // 
      // picWall8
      // 
      this.picWall8.BackColor = System.Drawing.Color.Transparent;
      this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.popcorn;
      this.picWall8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall8.Location = new System.Drawing.Point(1100, 1);
      this.picWall8.Name = "picWall8";
      this.picWall8.Size = new System.Drawing.Size(75, 722);
      this.picWall8.TabIndex = 15;
      this.picWall8.TabStop = false;
      // 
      // picWall1
      // 
      this.picWall1.BackColor = System.Drawing.Color.Transparent;
      this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.popcorn;
      this.picWall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall1.Location = new System.Drawing.Point(83, 1);
      this.picWall1.Name = "picWall1";
      this.picWall1.Size = new System.Drawing.Size(469, 67);
      this.picWall1.TabIndex = 13;
      this.picWall1.TabStop = false;
      // 
      // picWall2
      // 
      this.picWall2.BackColor = System.Drawing.Color.Transparent;
      this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.popcorn;
      this.picWall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall2.Location = new System.Drawing.Point(551, 1);
      this.picWall2.Name = "picWall2";
      this.picWall2.Size = new System.Drawing.Size(553, 67);
      this.picWall2.TabIndex = 16;
      this.picWall2.TabStop = false;
      // 
      // picWall3
      // 
      this.picWall3.BackColor = System.Drawing.Color.Transparent;
      this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.popcorn;
      this.picWall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall3.Location = new System.Drawing.Point(449, 270);
      this.picWall3.Name = "picWall3";
      this.picWall3.Size = new System.Drawing.Size(296, 182);
      this.picWall3.TabIndex = 17;
      this.picWall3.TabStop = false;
      // 
      // heal1
      // 
      this.heal1.BackColor = System.Drawing.Color.Transparent;
      this.heal1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.health;
      this.heal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.heal1.Location = new System.Drawing.Point(1026, 74);
      this.heal1.Name = "heal1";
      this.heal1.Size = new System.Drawing.Size(68, 71);
      this.heal1.TabIndex = 18;
      this.heal1.TabStop = false;
      // 
      // FrmLevelIESB
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.IESB;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1176, 726);
      this.Controls.Add(this.heal1);
      this.Controls.Add(this.picWall3);
      this.Controls.Add(this.picWall2);
      this.Controls.Add(this.picWall8);
      this.Controls.Add(this.picWall7);
      this.Controls.Add(this.lblInGameTime);
      this.Controls.Add(this.picWall1);
      this.Controls.Add(this.picWall0);
      this.Controls.Add(this.picWall9);
      this.Controls.Add(this.picWall6);
      this.Controls.Add(this.picWall10);
      this.Controls.Add(this.picWall4);
      this.Controls.Add(this.picWall5);
      this.Controls.Add(this.picEnemyCheeto);
      this.Controls.Add(this.picEnemyPoisonPacket);
      this.Controls.Add(this.picBossKoolAid);
      this.Controls.Add(this.picPlayer);
      this.DoubleBuffered = true;
      this.Name = "FrmLevelIESB";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Explore";
      this.Load += new System.EventHandler(this.FrmLevel_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
      ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.heal1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.PictureBox picBossKoolAid;
    private System.Windows.Forms.Label lblInGameTime;
    private System.Windows.Forms.Timer tmrUpdateInGameTime;
    private System.Windows.Forms.Timer tmrPlayerMove;
    private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
    private System.Windows.Forms.PictureBox picEnemyCheeto;
    private System.Windows.Forms.PictureBox picWall5;
    private System.Windows.Forms.PictureBox picWall4;
    private System.Windows.Forms.PictureBox picWall10;
    private System.Windows.Forms.PictureBox picWall6;
    private System.Windows.Forms.PictureBox picWall9;
    private System.Windows.Forms.PictureBox picWall0;
    private System.Windows.Forms.PictureBox picWall7;
    private System.Windows.Forms.PictureBox picWall8;
    private System.Windows.Forms.PictureBox picWall1;
    private System.Windows.Forms.PictureBox picWall2;
    private System.Windows.Forms.PictureBox picWall3;
    public System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox heal1;
    }
}

