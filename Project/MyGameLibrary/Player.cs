using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {

        private Int32 money;
    public Player(Vector2 initPos, Collider collider) : base(initPos, collider) {
        money = 0;
    }

    public Int32 showMoney() { 
        return money;
    }

    public void giveMoney(Int32 mo_money) {
        money += mo_money;
    }
  }
}
