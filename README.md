## Documentation

### Death Sequence - Kennedy

When the player dies, a window will pop up letting the user know that they have lost the game. They will also be prompted with two options: A button to restart the game and a button to quit the game. For future additions, I would like to add customized death images that will be displayed based on what character the player is playing as. I would also like to customize the UI more.

<br/>

### Enemy Instance Removal Upon Death - Josh

Ingame enemies are now removed from the game when their health is less than or equal to zero. Three functions were created in `FrmLevel.cs` to implement this capability. 

#### private bool enemyIsDead(Enemy enemy)

Takes in a `Enemy.cs` instance as an input and checks if its health is less than or equal to zero, and if so, return true. Otherwise, if the enemy's health is above zero, return false. 

#### private void removeEnemy(Enemy enemy)
Takes in a `Enemy.cs` instance as an input and sets the instance to null. Furthermore, the PictureBox image that is attached to the enemy instance (as a collider) is set to be invisible. 

#### private void battleOver(object sender, FormClosedEventArgs e)
Closed EventHandler for `FrmBattle` instance frmBattle created in `Fight` function. This function is called when the frmBattle window is closed. Inside the function is a call to the `enemyIsDead` function to check if the enemy from the battle is dead. If this function returns true, the enemy instance is passed into the `removeEnemy` function and is removed from the game.

<br/>

### Ingame Pause Window - Josh

Created a new Windows Forms class that acts as the pause menu for the game called `FrmPause.cs`. A `FrmPause` instance is initiated and shown when the player presses the escape button. Unlike a `FrmBattle` instance, a player can not continue to play the game while a `FrmPause` window is shown. The reason is because inside `FrmLevel.cs`, frmBattle, an instance of `FrmBattle.cs`, uses `frmBattle.show()` to show the window while frmPause, an instance of `FrmPause.cs`, uses `frmPause.ShowDialog()` which does not allow the player to access any other windows while frmPause is shown. 

A boolean class variable inside of `FrmLevel.cs` called isPaused was created solely for the purpose of stopping the ingame timer. isPaused's value is initially set to false. When the escape key is hit, the isPaused variable is set to true, and when the frmPause window is closed, isPaused is set back to false. More on pausing the ingame timer is discussed below.

#### `FrmPause.cs` Functionality 

`FrmPause.cs` contains three buttons: `resumeButton`, `startOverButton`, and `quitButton`. For each button, there is a Click `EventHandler` inside `FrmPause.Designer.cs` that triggers each of the `[button]_Click` functions inside `FrmPause.cs` in the event that any one of the buttons are clicked.

#### Resume Button

When clicked, the `FrmPause.cs` instance frmPause inside `FrmLevel.cs` is closed and the game is resumed. 

#### Start Over Button 

When clicked, the entire Windows Forms application is restarted and the game starts over completely. 

#### Quit Button 

When clicked, the entire Window Forms application is closed, quitting the game entirely. 

#### `FrmPause.cs` Design

The buttons were implemented using the Windows Forms Toolbox. The background photo in the window, named `pauseMenuBackground.jpg` can be found in the `Team_CSC403_Scrum_1/Properties/` folder inside the file `Resources.resx `. The `pauseMenuBackground.jpg` photo was uploaded to `Resources.resx` from the `Team_CSC403_Scrum_1/Data/` folder (`pauseMenuBackground.jpg` was uploaded manually to this folder). 

#### Pausing Ingame Timer
In order to pause the timer found inside of the game, a Stopwatch instance named timer was created inside `FrmLevel.cs` (replacing the old DateTime instance startTime). The timer is started when the game is first loaded. When the isPaused variable is true, the timer is stopped. The timer can only be started again when the isPaused variable is set back to true, which only happens when the frmPause window is closed. 

<br/>

### Fleeing from battle - Brendan
Battle fleeing was implemented using a button below Attack labeled "Flee" in `FrmBattle`. Once clicked, this button chooses between two options: closing the window as if the fight has ended (successful flee), or allowing the enemy to attack the player (failed flee). The success chance of fleeing is set at 50%. Changes confined to `FrmBattle.cs` and `FrmBattle.Designer.cs`.

<br/>

### In-game music and sounds - Kennedy

Created or obtained game music and sound effects for a multitude of scenarios. Some are played only once, and some are loops which is continuously played.
Below, There is a list of all of the sounds and music that were added, their purpose, and if they were created or obtained from the internet. (Any music that was created was created by Kennedy Ford)

<br/>

#### Currently Implemented Sounds / Music:
<hr/>

#### world_music.waw
- Created as a loop to give a particular ambiance to the level map.

#### battle_music.wav
- Created as a loop to enhance the battle experience with a sense of urgency.

#### death_music.wav
- Created as a sound to be played once when the player is killed in battle (not looped).

<br/><br/>

#### Sounds / Music to Be Implemented:
<hr/>

#### win_music.wav
- Created as a sound to be played when the player wins a battle (not looped).

#### pause_sound.wav
- Obtained from the internet for when the user clicks the Escape key to pull up the pause menu (originally from Mario 64) (not looped).

#### oof_sound.mp3
- Obtained from the internet for when the user is hit (not looped) (this sound can be found in many different games).

#### attack_sound1.wav & attack_sound2.wav
- Obtained from the internet for when the player attacks. (originally from Zelda: Ocarina of Time young Link attack sounds) (not looped)

#### Known Bugs:
- After the user defeats the final boss, the world music will begin to play again. Need to add a success screen that stops the music and gives the user the ability to either end the game or restart the game.

<br/>

### Multi-key movement - Brendan
Originally, players were only able to move with one arrow key at a time. This branch adds the ability to use more than one key (including WASD). This was accomplished by making, mainly, changes to `FrmLevel.cs`. Both KeyDown() and KeyUp() were modified to two only two things: reset player movement and call a new function, `CheckKeys()`. This new function reads a new instance variable `KeyBindings`and checks *individually* for each binding whether or not the key is pressed. This way, any number of keys can be pressed at any time during the level and `CheckKeys()` should never miss any.

`FrmLevel.cs`'s changes required a few more tweaks. 
1. CheckKeys()` requires a few more inputs. 
2. Since `CheckKeys()` determines the player's next movement direction, `Characer.GoUp()`, `Character.GoDown()`, etc. have been consolidated into a single `Character.GoVector(Vector2 MoveDir)` function. `CheckKeys()` simply calls `GoVector()` with its calculated movement vector. 
3. The `Vector2` struct got a few new functions: `static Add(Vector2 VectorA, Vector2 VectorB)`, `NormalizeSquare()`, and `IsZero()`. `Add()` returns a new vector which is a combination of the provided two. `NormalizeSquare()` makes sure that the magnitude of the vector in either the x or y direction is not greater than 1 unit. `IsZero()` is self-explanatory.

Key bindings can be altered by changing the `KeyBindings` array in `FrmLevel.cs`.

<br/>

### New characters and character select screen - John
Users are met with a character select screen when opening the game. Depending on their choice, the character chosen will be used for the duration of their play time. Characters are: MrPeanut, Toucan_Sam, Doughboy, and Martin. `Program.cs` now calls on `FrmCharSelect.cs` rather than `FrmLevel.cs` now. 

<br/>

### Cars - Brendan
Users are able to board and ride around in cars. There is currently no functionality to get out of a car. This is done by adding 8 new pictures to the game: one car for each level and a photoshopped version of that car with the player inside.

When a player hits a car in the level, their image and hitbox is changed to that of the car. Their speed is also increased from 3 to 5. Finally, when players hit enemies while in a car the enemy will take a hit of damage.

`Character.cs` had its attribute `Collider` changed to public. This allowed each FrmLevel to set a different collider. In addition, a new function and two new variables have been added to the same file. `CarGo_Inc` is the speed that the player will move once in the car (currently set to 5) and `InCar` is a boolean which dictates whether or not a player is currently in a car (used for battles). `BoardCar()` simply changes the player's speed and `InCar` value.

`FrmBattle.cs` now checks if a player is in a car at the beginning of the fight. If they are, a crashing sound is played and the enemy is dealt a hit of damage. Note: there is a known bug with this. If the player ends the fight before the crashing sound is over, the program will crash because the background music was ordered to stop when it had, in fact, never started. A hotfix for this would be to add a null check to the function which stops the music, but this just results in the battle music playing in the world.

`FrmLevel.cs`'s variants now have two cars each: Cars and player-cars have been added as PictureBoxes. The player-car on each level is invisible and is used once the player hits the real car.

 <br/>
 
 ### Title Screen - Kennedy
 When the player first starts the game, they were originally thrown straight into the game. Then, we added the character selection feature and started the game with that window. Now, before you get to the character select window, you are greated by a title screen. You can either push the play button and choose your character or you can exit, which will close the entire application's process.

<br/>

### New playable levels
Users will be able to play a different character based on which level they select. Each level has it's own theme and enemies. The levels are as follows: IESB, Jungle, City, and Bakery. 

### Health Packs
When colliding with health packs found on each level of the game, the player will heal 15 hp. 

<br/>

### Player Money - Josh
Players can now earn money after defeating enemies. Each enemy defeated gives the player $100 (non-transferrable to USD as of now). A new class variable was created inside of `Player.cs` appropriately named `private Int32 money`. Two new functions were also added to `Player.cs` to ensure the player's money could be shown, and that in the event of an enemy being defeated, the player could be given money. 

<br/>

### Weapon Shop - Josh
A weapon shop has been added to each level in the game. Players can use money, earned by defeating enemies, to purchase weapons in the shop. A new window, named `FrmWeaponShop.cs` was created to act as the interface for the weapon shop. Players can purchase three weapons from the shop: an energy sword, a ray gun, and TNT. The cost & capabilities of these weapons are as follows:
#### Energy Sword ($200) - Players must defeat two enemies in order to buy this weapon. If used in battle, the enemy will be killed in one hit. However, this weapon can only be used once. 
#### Ray Gun ($100) - Players need only to defeat one enemy to purchase this weapon. When used in battle, it does double the damage of a normal attack. However, the player also loses 2 health each time they use this weapon
#### TNT ($0) - Free does not mean good ;)

When weapons are purchased, they appear inside of the `FrmBattle.cs` window as buttons. Three boolean variables were created inside of `Player.cs` to check if players have any of the three weapons, and if they do, their corresponding button appears during battle. 
