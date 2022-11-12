/*
author: john doherty
project: CSC 403 Sprint #1
desc: Windows form to present user with a choice between four different characters: Mr Peanut, Martin the Gecko (From geico), Toucan Sam, and the Pillsbury Doughboy.

note:
Each button to select a character has its own function. The function begins a new instance of the FrmLevel class, shows it, and then sets the character 
image to the correct character based on which button was pressed.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
  public partial class FrmCharSelect : Form
  {
    public FrmCharSelect()
    {
      InitializeComponent();
    }

    private void FrmCharSelect_Load(object sender, EventArgs e)
    {

    }
    //Doughboy Button
    private void Doughboy_Click(object sender, EventArgs e)
    {
      FrmLevelBakery game = new FrmLevelBakery(); // create new instance of FrmLevel
      game.FormClosed += gameclosed;
      game.Show(); //Show it
      this.Hide();
      game.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Doughboy; //change the character image used
      game.picPlayer.Refresh(); //Refresh the character to ensure the change was visible.

    }
    //Martin Button
    private void Martin_Click(object sender, EventArgs e)
    {
      FrmLevelCity game = new FrmLevelCity(); // create new instance of FrmLevel
      game.FormClosed += gameclosed;
      game.Show(); //Show it
      this.Hide();
      game.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Martin; //change the character image used
      game.picPlayer.Refresh(); //Refresh the character to ensure the change was visible.
    }
    //MrPeanut Button
    private void MrPeanut_Click(object sender, EventArgs e)
    {
      picCarPlayer game = new picCarPlayer(); // create new instance of FrmLevel
      game.FormClosed += gameclosed;
      game.Show(); //Show it
      this.Hide();
      game.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.MrPeanut; //change the character image used
      game.picPlayer.Refresh(); //Refresh the character to ensure the change was visible.
    
    }
    //ToucanSam Button
    private void ToucanSam_Click(object sender, EventArgs e)
    {
      aaa game = new aaa(); // create new instance of FrmLevel
      game.FormClosed += gameclosed;
      game.Show(); //Show it
      this.Hide();
      game.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Toucan_Sam; //change the character image used
      game.picPlayer.Refresh(); //Refresh the character to ensure the change was visible.
    }
    //Exit Button
    private void ExitButton_Click(object sender, EventArgs e)
    {
      this.Close(); //close the window
    }

    private void gameclosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }
  }    
}


