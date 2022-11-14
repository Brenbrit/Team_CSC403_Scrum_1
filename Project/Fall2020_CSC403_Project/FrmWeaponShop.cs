using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Media;
using Fall2020_CSC403_Project.Properties;

namespace Fall2020_CSC403_Project
{
    public partial class FrmWeaponShop : Form
    {
        private Player player;
        public static FrmWeaponShop instance = null;
        private SoundPlayer shopMusic;

        public FrmWeaponShop(Player shopDweller) {
            InitializeComponent();
            this.player = shopDweller;
            shopMusic = new SoundPlayer(Resources.hotlineshop);
        }

        public static FrmWeaponShop GetInstance(Player shopDweller) { 
            if (instance == null)
                instance = new FrmWeaponShop(shopDweller);

            instance.playShopMusic();
            return instance;
        }

        private void playShopMusic() {
            shopMusic.PlayLooping();
        }

        private void FrmItemShop_Load(object sender, EventArgs e) {

            if (player.hasEnergySword) {
                energySwordLabel.Text = "Energy Sword (sold)";
                energySwordButton.Enabled = false;
                energySwordButton.Visible = false;
            }
            if (player.hasRayGun) {
                rayGunLabel.Text = "Ray Gun (sold)";
                rayGunButton.Enabled = false;
                rayGunButton.Visible = false;
            }
            if (player.hasTNT) {
                tntLabel.Text = "TNT (sold)";
                tntButton.Enabled = false;
                tntButton.Visible = false;
            }
        }

        private void energySwordButton_Click(object sender, EventArgs e) {
            if (player.showMoney() >= 200) { 
                player.hasEnergySword = true;
                player.giveMoney(-200);
                energySwordLabel.Text = "Energy Sword (sold)";
                energySwordButton.Enabled = false;
                energySwordButton.Visible = false;
                this.moneyLabel.Text = "$" + player.showMoney();
            }
            else {
                MessageBox.Show("Hey don't sweat it. Not having a lot of money means you don't have a lot of problems. Keep the struggle up.", "CHURRY SAYS");
            }
        }

        private void rayGunButton_Click(object sender, EventArgs e) {
            if (player.showMoney() >= 100) { 
                player.hasRayGun = true;
                player.giveMoney(-100);
                rayGunLabel.Text = "Ray Gun (sold)";
                rayGunButton.Enabled = false;
                rayGunButton.Visible = false;
                this.moneyLabel.Text = "$" + player.showMoney();  
            }
            else {
                MessageBox.Show("Hey don't sweat it. Not having a lot of money means you don't have a lot of problems. Keep the struggle up.", "CHURRY SAYS");
            }
        }

        private void tntButton_Click(object sender, EventArgs e) {
            player.hasTNT = true;
            tntLabel.Text = "TNT (sold)";
            tntButton.Enabled = false;
            tntButton.Visible = false;
        }

        private void onMouseEnterEnergySwordButton(object sender, EventArgs e) {
            energySwordButton.BackColor = Color.LimeGreen;
        }

        private void onMouseLeaveEnergySwordButton(object sender, EventArgs e) {
            energySwordButton.BackColor = Color.Green;
        }

        private void onMouseEnterRayGunButton(object sender, EventArgs e) {
            rayGunButton.BackColor = Color.LimeGreen;
        }

        private void onMouseLeaveRayGunButton(object sender, EventArgs e) {
            rayGunButton.BackColor = Color.Green;
        }

        private void onMouseEnterTNTButton(object sender, EventArgs e) {
            tntButton.BackColor = Color.LimeGreen;
        }

        private void onMouseLeaveTNTButton(object sender, EventArgs e) {
            tntButton.BackColor = Color.Green;
        }
        public void updateMoneyLabel() {
            this.moneyLabel.Text = "$" + player.showMoney();
        }

        private void leaveButton_Click(object sender, EventArgs e) {
            MessageBox.Show("Churry along now I have plenty of customers waiting!", "CHURRY SAYS");
            this.Close();
        }

        private void weaponShopClosed(object sender, FormClosedEventArgs e) { 
            shopMusic.Stop();
        }
    }
}
