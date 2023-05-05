using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit : XPUnit
    {
        public override int Health
        {
            get => base.Health + XP;

            set => base.Health = value;
        }
        public override float Cost
        {
            get => AttackPower + XP;
        }
        public int AttackPower { get; }
    

        public MilitaryUnit(int movement, int health, int attackPower)
        : base(movement, health)
        {
            AttackPower = attackPower;
        }



        public void Attack(Unit target)
        {
            XP++;
            target.Health--;
        }


        public override string ToString()
        {
            return base.ToString() + String.Format(" AP={0}",AttackPower);
        }



    }
}