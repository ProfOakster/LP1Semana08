using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit tank = new MilitaryUnit(6, 10, 5);
            Unit infantry = new SettlerUnit();

            tank.Move();
            infantry.Move();

            Console.WriteLine("Tank HP:{0} Cost:{1}",tank.Health,tank.Cost);
            Console.WriteLine("Infantry HP:{0} Cost:{1}",infantry.Health,infantry.Cost);
        }
    }
}
