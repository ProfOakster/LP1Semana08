using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit : Unit
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
        public int XP { get; private set; }


        public MilitaryUnit(int movement, int health, int attackPower)
        : base(movement, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }



        public void Attack(Unit target)
        {
            XP++;
            target.Health--;
        }


        public override string ToString()
        {
            return base.ToString() + String.Format(" AP={0,1} XP={1,1}",AttackPower,XP);
        }



    }
}