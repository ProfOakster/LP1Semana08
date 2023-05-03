using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Numerics;

namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;

        public virtual int Health { get; set; }

        public abstract float Cost{ get; }


        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }


        public void Move()
        {
            Console.WriteLine($"Unit moved {movement} tiles.");
        }

        public override string ToString()
        {
            return String.Format(
                "{0}:  HP={1:d} COST={2:f2}",this.GetType().Name,Health,Cost);
        }
    }
}