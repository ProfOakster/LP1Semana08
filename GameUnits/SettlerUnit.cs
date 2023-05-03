using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public override float Cost
        {
            get => 5f;
        }
        public SettlerUnit() : base(movement, health)
        {
            movement = 1;
            health = 2;
        }

    }
}