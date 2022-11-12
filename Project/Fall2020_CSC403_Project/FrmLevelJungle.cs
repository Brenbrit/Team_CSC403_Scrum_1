using Fall2020_CSC403_Project.code;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using Fall2020_CSC403_Project.Properties;
using System.Windows.Input;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevelJungle : Form {
    private Player player;
    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Enemy heal;
    private Character[] walls;
    // private DateTime timeBegin; - never used. From Cherry.
    private FrmBattle frmBattle;
    private SoundPlayer worldSound;
    private SoundPlayer battleSound;

    private bool isPaused;
    private Stopwatch timer;
    private Tuple<Key, Vector2>[] KeyBindings;
    private FrmPause frmPause; 

    public FrmLevelJungle() {
      InitializeComponent();
      worldSound = new SoundPlayer(Resources.world_music);
      worldSound.PlayLooping();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;
      

      
      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
      heal = new Enemy(CreatePosition(heal1), CreateCollider(heal1, PADDING));

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      // Bindings: an array of tuples. Each tuple includes a key
      // and which direction that key should cause the player to move.
      // Tuples are normalized before being applied, so we don't
      // have to worry about adding them.
      KeyBindings = new Tuple<Key, Vector2>[] {
        Tuple.Create(Key.Left,  new Vector2(-1, 0)),
        Tuple.Create(Key.Right, new Vector2(+1, 0)),
        Tuple.Create(Key.Up,    new Vector2(0, -1)),
        Tuple.Create(Key.Down,  new Vector2(0, +1)),
        Tuple.Create(Key.A,     new Vector2(-1, 0)),
        Tuple.Create(Key.D,     new Vector2(+1, 0)),
        Tuple.Create(Key.W,     new Vector2(0, -1)),
        Tuple.Create(Key.S,     new Vector2(0, +1)),
      };

      Game.player = player;
      this.moneyLabel.Text = "$" + player.showMoney();

      isPaused = false;

      // Initiate Stopwatch instance and start the timer 
      timer = new Stopwatch();
      timer.Start();
        }

    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      CheckKeys();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) { 

        // If the pause window is shown then pause the timer 
        if (isPaused)
           timer.Stop();
        else
            timer.Start();

        // Counts how many seconds have passed since the timer first started
        TimeSpan span = timer.Elapsed;
        string time = span.ToString(@"hh\:mm\:ss");
        lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // move player
      player.Move();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

      // check collision with enemies
      if (HitAChar(player, enemyPoisonPacket)) {
        Fight(enemyPoisonPacket);
      }
      else if (HitAChar(player, enemyCheeto)) {
        Fight(enemyCheeto);
      }
      else if (HitAChar(player, heal))
      {
        player.Health += 15;
        heal = null;
        heal1.Visible = false;
      }
      if (HitAChar(player, bossKoolaid)) {
        Fight(bossKoolaid);
      }

      // update player's picture box
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
    }

    private bool HitAWall(Character c) {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++) {
        if (c.Collider.Intersects(walls[w].Collider)) {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other) {

      // If the enemy has not been killed (or deleted) then check for collision
      if (other != null)
        return you.Collider.Intersects(other.Collider);

      // Enemy has been killed therefore there can be no collision 
      return false;
    }

    private void Fight(Enemy enemy) {
      player.ResetMoveSpeed();
      player.MoveBack();
      worldSound.Stop();
      frmBattle = FrmBattle.GetInstance(enemy);

       // battleOver function will be called when frmBattle window is closed
      frmBattle.FormClosed += battleOver;
      frmBattle.picPlayer.BackgroundImage = this.picPlayer.BackgroundImage; //Set character image for the new battle to be the same as the current FrmLevel.
      
      frmBattle.Show();
     

      if (enemy == bossKoolaid) {
        battleSound = new SoundPlayer(Resources.battle_music);
        battleSound.PlayLooping();
      }
    }

    // Function that is called when frmBattle window, created in Fight function, is closed.
    private void battleOver(object sender, FormClosedEventArgs e) { 
        
        // If the enemy has no health after the battle
        if (enemyIsDead(frmBattle.enemy)) { 

            // Remove the enemy from the game
            removeEnemy(frmBattle.enemy); 

            // Giving the player more money (and consequently more problems)
            player.giveMoney(100);

            // Updating the money label to show the player's current amount of money
            this.moneyLabel.Text = "$" + player.showMoney();
        }
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
      CheckKeys();
    }

    private void CheckKeys() {
      // We will add each binding's Vector2 to MovementDirection
      // to obtain the final direction.
      Vector2 MovementDirection = new Vector2(0, 0);

      // Check if we're pressing each bound button
      foreach (Tuple<Key, Vector2> Binding in this.KeyBindings) {
        if (Keyboard.IsKeyDown(Binding.Item1)) {
          MovementDirection = Vector2.Add(MovementDirection, Binding.Item2);
        }
      }

      // Normalize MovementDirection so that the maximum absolute value
      // of either direction is 1
      MovementDirection.NormalizeSquare();

      if (Keyboard.IsKeyDown(Key.Escape)) {

        // Game is paused when the escape key is hit 
        isPaused = true;

        // Get instance of FrmPause window and show it 
        frmPause = FrmPause.GetInstance();

        // ShowDialog() ensures no other windows can be accessed while 
        // frmPause window is shown
        frmPause.ShowDialog();

        // Once frmPause window is closed, the game is no longer paused
        isPaused = false;

      }

      if (MovementDirection.IsZero())
        player.ResetMoveSpeed();
      else
        player.GoVector(MovementDirection);
    }

    // Function that checks if an enemy is dead. If its health is less than or 
    // equal to zero, we say that the enemy is dead.
    private bool enemyIsDead(Enemy enemy) {
        if (enemy.Health <= 0)
            return true;
        else
            return false;
    }

    // Function that removes an enemy from the game by setting its instance to null
    // and making the PictureBox image that it is attached to invisible. 
    private void removeEnemy (Enemy enemy) { 
        if (enemy == enemyPoisonPacket) { 
            enemyPoisonPacket = null;
            picEnemyPoisonPacket.Visible = false;
        }
        else if (enemy == enemyCheeto) {
            enemyCheeto = null;
            picEnemyCheeto.Visible = false;
        }   
        else { 
            bossKoolaid = null;
            picBossKoolAid.Visible = false;
        }
    }

    private void lblInGameTime_Click(object sender, EventArgs e) {
        
    }
  }
}
