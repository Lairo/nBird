﻿using System;

namespace nBird
{
    abstract class Bird
    {
        public static Random Randomizer = new Random();
        public abstract Egg[] LayEggs(int numberOfEggs);
        
    }
}
