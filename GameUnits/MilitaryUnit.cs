using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        public MilitaryUnit(int movement, int health, int attackPower) 
        : base(movement, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }



        public void Attack(Unit target)
        {

        }
    }
}