﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Foods
{
    public class Mushroom : Food
    {
        private const int happiness = -10;
        public Mushroom() : base(happiness)
        {
        }
    }
}
