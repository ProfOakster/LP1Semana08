﻿using System;

namespace Polimorfismo
{
    public class Program
    {
        private static void Main()
        {
            Animal a0 = new Animal();
            Animal a1 = new Dog();
            Animal a2 = new Cat();

            Console.WriteLine($"a0 sound : {a0.Sound()}");
            Console.WriteLine($"a1 sound : {a1.Sound()}");
            Console.WriteLine($"a2 sound : {a2.Sound()}");
        }
    }
}
