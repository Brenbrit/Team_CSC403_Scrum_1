using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private FrmDeath death_window;
    public Enemy enemy;
    private Player player;
    private SoundPlayer battleSound;
    private SoundPlayer worldSound;
    private SoundPlayer crashSound;
    private Boolean playMusic;

    private FrmBattle() {
      InitializeComponent();
      player = Game.player;
      lblFleeStatus.Text = "";
    }

    public async void Setup(Boolean PlayMusic) {
      // update for this enemy
      picEnemy.BackgroundImage = enemy.Img;
      picEnemy.Refresh();
      BackColor = enemy.Color;
      picBossBattle.Visible = false;

      // Observer pattern
      enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;

      this.playMusic = PlayMusic;

      // Has enemy been hit by car?
      if (player.InCar) {
        // disable buttons
        btnAttack.Enabled = false;
        btnFlee.Enabled = false;

        crashSound = new SoundPlayer(Resources.car_crash);
        playMusic = false;
        // Wait for sound to finish playing
        await Task.Run(() => { crashSound.PlaySync(); });
        player.OnAttack(-4);
        playMusic = PlayMusic;

        // re-enable buttons
        btnAttack.Enabled = true;
        btnFlee.Enabled = true;
      }

      if (playMusic) {
        battleSound = new SoundPlayer(Resources.battle_music);
        battleSound.PlayLooping();
      }

      // show health
      UpdateHealthBars();
    }

    public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;

      SoundPlayer simpleSound = new SoundPlayer(Resources.iesb_boss);
      simpleSound.Play();

      tmrFinalBattle.Enabled = true;
    }

    public static FrmBattle GetInstance(Enemy enemy, Boolean PlayMusic) {
      if (instance == null) {
        instance = new FrmBattle();
        instance.enemy = enemy;
        instance.Setup(PlayMusic);
      }
      return instance;
    }

    private void UpdateHealthBars() {
      float playerHealthPer = player.Health / (float)player.MaxHealth;
      float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
      lblEnemyHealthFull.Text = enemy.Health.ToString();
    }

    private void PlayDeathSound() {
      SoundPlayer deathSound = new SoundPlayer(Resources.death_music);
      deathSound.Play();
    }

    private void PlayWorldSound() {
      worldSound = new SoundPlayer(Resources.world_music);
      worldSound.PlayLooping();
    }

    private void ShowDeathWindow() {
      death_window = FrmDeath.GetInstance();
      death_window.FormClosed += gameOver;
      death_window.ShowDialog();
    }

    private void StopBattleSound() {
      if (playMusic) {
        battleSound.Stop();
      }
    }

    private void btnAttack_Click(object sender, EventArgs e) {
      lblFleeStatus.Text = "";

      player.OnAttack(-4);
      //SoundPlayer attackSound = new SoundPlayer(Resources.attack_sound1);
      //attackSound.Play();
      if (enemy.Health > 0)
      {
        enemy.OnAttack(-2);
      }

      UpdateHealthBars();
      if (player.Health <= 0)
      {
        StopBattleSound();
        PlayDeathSound();
        instance = null;
        Close();
        ShowDeathWindow();
      }

      if (enemy.Health <= 0)
      {
        StopBattleSound();
        //SoundPlayer winSound = new SoundPlayer(Resources.win_music);
        //winSound.Play();
        instance = null;
        Close();
        PlayWorldSound();
      }
    }

    private void gameOver(object sender, FormClosedEventArgs e) {
      Application.Exit();
    }

    private void EnemyDamage(int amount) {
      enemy.AlterHealth(amount);
    }

    private void PlayerDamage(int amount) {
      player.AlterHealth(amount);
    }

    private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
    }

    private void button1_Click(object sender, EventArgs e) {
      double fleeChance = 0.5f;
      Random random = new Random();

      if (random.NextDouble() < fleeChance) {
        // flee!
        lblFleeStatus.Text = "Flee successful!";
        StopBattleSound();
        instance = null;
        Close();
        PlayWorldSound();
      } else {
        // Flee failed.
        lblFleeStatus.Text = "Failed to flee!";

        if (enemy.Health > 0) {
          enemy.OnAttack(-2);
        }

        UpdateHealthBars();
        // We don't need to check for enemy health because the enemy cannot
        // be damaged if we are fleeing.
        if (player.Health <= 0) {
          StopBattleSound();
          PlayDeathSound();
          instance = null;
          Close();
          ShowDeathWindow();
        }
      }
    }
  }
}
