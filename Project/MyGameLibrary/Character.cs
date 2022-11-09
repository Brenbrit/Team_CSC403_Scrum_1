using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Character {
    private int Go_Inc = 3;
    
    private const int CarGo_Inc = 5;

    public Vector2 MoveSpeed { get; private set; }
    public Vector2 LastPosition { get; private set; }
    public Vector2 Position { get; private set; }
    public Collider Collider { get; set; }
    public Boolean InCar { get; set; }

    public void BoardCar() {
      Go_Inc = CarGo_Inc;
      InCar = true;
    }

    public Character(Vector2 initPos, Collider collider) {
      Position = initPos;
      Collider = collider;
      InCar = false;
    }

    public void Move() {
      LastPosition = Position;
      Position = new Vector2(Position.x + MoveSpeed.x, Position.y + MoveSpeed.y);
      Collider.MovePosition((int)Position.x, (int)Position.y);
    }

    public void MoveBack() {
      Position = LastPosition;
    }

    public void GoVector(Vector2 MoveDir) {
      MoveSpeed = new Vector2(Go_Inc * MoveDir.x, Go_Inc * MoveDir.y);
    }

    public void ResetMoveSpeed() {
      MoveSpeed = new Vector2(0, 0);
    }
  }
}
