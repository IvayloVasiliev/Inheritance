﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animal06.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender)
            : base(name, age, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
