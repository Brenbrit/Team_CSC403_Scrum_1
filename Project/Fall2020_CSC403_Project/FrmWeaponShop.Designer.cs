using System.Windows.Forms.VisualStyles;

namespace Fall2020_CSC403_Project
{
    partial class FrmWeaponShop
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
            this.energySwordButton = new System.Windows.Forms.Button();
            this.energySwordLabel = new System.Windows.Forms.Label();
            this.rayGunLabel = new System.Windows.Forms.Label();
            this.tntLabel = new System.Windows.Forms.Label();
            this.rayGunButton = new System.Windows.Forms.Button();
            this.tntButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.leaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // energySwordButton
            // 
            this.energySwordButton.BackColor = System.Drawing.Color.Green;
            this.energySwordButton.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energySwordButton.Location = new System.Drawing.Point(732, 661);
            this.energySwordButton.Name = "energySwordButton";
            this.energySwordButton.Size = new System.Drawing.Size(156, 71);
            this.energySwordButton.TabIndex = 1;
            this.energySwordButton.Text = "$200";
            this.energySwordButton.UseVisualStyleBackColor = false;
            this.energySwordButton.Click += new System.EventHandler(this.energySwordButton_Click);
            this.energySwordButton.MouseEnter += new System.EventHandler(this.onMouseEnterEnergySwordButton);
            this.energySwordButton.MouseLeave += new System.EventHandler(this.onMouseLeaveEnergySwordButton);
            // 
            // energySwordLabel
            // 
            this.energySwordLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.energySwordLabel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energySwordLabel.Location = new System.Drawing.Point(652, 533);
            this.energySwordLabel.Name = "energySwordLabel";
            this.energySwordLabel.Size = new System.Drawing.Size(340, 97);
            this.energySwordLabel.TabIndex = 2;
            this.energySwordLabel.Text = "Energy Sword";
            this.energySwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rayGunLabel
            // 
            this.rayGunLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rayGunLabel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rayGunLabel.Location = new System.Drawing.Point(1059, 533);
            this.rayGunLabel.Name = "rayGunLabel";
            this.rayGunLabel.Size = new System.Drawing.Size(362, 97);
            this.rayGunLabel.TabIndex = 3;
            this.rayGunLabel.Text = "Ray Gun";
            this.rayGunLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tntLabel
            // 
            this.tntLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tntLabel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tntLabel.Location = new System.Drawing.Point(1480, 533);
            this.tntLabel.Name = "tntLabel";
            this.tntLabel.Size = new System.Drawing.Size(330, 97);
            this.tntLabel.TabIndex = 4;
            this.tntLabel.Text = "TNT";
            this.tntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rayGunButton
            // 
            this.rayGunButton.BackColor = System.Drawing.Color.Green;
            this.rayGunButton.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rayGunButton.Location = new System.Drawing.Point(1163, 661);
            this.rayGunButton.Name = "rayGunButton";
            this.rayGunButton.Size = new System.Drawing.Size(168, 71);
            this.rayGunButton.TabIndex = 5;
            this.rayGunButton.Text = "$100";
            this.rayGunButton.UseVisualStyleBackColor = false;
            this.rayGunButton.Click += new System.EventHandler(this.rayGunButton_Click);
            this.rayGunButton.MouseEnter += new System.EventHandler(this.onMouseEnterRayGunButton);
            this.rayGunButton.MouseLeave += new System.EventHandler(this.onMouseLeaveRayGunButton);
            // 
            // tntButton
            // 
            this.tntButton.BackColor = System.Drawing.Color.Green;
            this.tntButton.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tntButton.Location = new System.Drawing.Point(1584, 661);
            this.tntButton.Name = "tntButton";
            this.tntButton.Size = new System.Drawing.Size(146, 71);
            this.tntButton.TabIndex = 6;
            this.tntButton.Text = "$0";
            this.tntButton.UseVisualStyleBackColor = false;
            this.tntButton.Click += new System.EventHandler(this.tntButton_Click);
            this.tntButton.MouseEnter += new System.EventHandler(this.onMouseEnterTNTButton);
            this.tntButton.MouseLeave += new System.EventHandler(this.onMouseLeaveTNTButton);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.welcomeLabel.Font = new System.Drawing.Font("Constantia", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.welcomeLabel.Location = new System.Drawing.Point(-8, -1);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(700, 165);
            this.welcomeLabel.TabIndex = 8;
            this.welcomeLabel.Text = "Welcome to Churry\'s Weapon Shop";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moneyLabel
            // 
            this.moneyLabel.BackColor = System.Drawing.Color.ForestGreen;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.moneyLabel.Location = new System.Drawing.Point(1428, 58);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(196, 81);
            this.moneyLabel.TabIndex = 9;
            this.moneyLabel.Text = "$";
            // 
            // leaveButton
            // 
            this.leaveButton.BackColor = System.Drawing.Color.Red;
            this.leaveButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveButton.Location = new System.Drawing.Point(69, 768);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(408, 110);
            this.leaveButton.TabIndex = 10;
            this.leaveButton.Text = "LEAVE ";
            this.leaveButton.UseVisualStyleBackColor = false;
            this.leaveButton.MouseEnter += new System.EventHandler(this.onMouseEnterLeaveButton);
            this.leaveButton.MouseLeave += new System.EventHandler(this.onMouseLeaveTheLeaveButton);
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // FrmWeaponShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.itemshop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1822, 956);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.tntButton);
            this.Controls.Add(this.rayGunButton);
            this.Controls.Add(this.tntLabel);
            this.Controls.Add(this.rayGunLabel);
            this.Controls.Add(this.energySwordLabel);
            this.Controls.Add(this.energySwordButton);
            this.Name = "FrmWeaponShop";
            this.Text = "FrmItemShop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.shopClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button energySwordButton;
        private System.Windows.Forms.Label energySwordLabel;
        private System.Windows.Forms.Label rayGunLabel;
        private System.Windows.Forms.Label tntLabel;
        private System.Windows.Forms.Button rayGunButton;
        private System.Windows.Forms.Button tntButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Button leaveButton;
    }
}