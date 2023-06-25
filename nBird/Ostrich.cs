﻿namespace nBird
{
    class Ostrich : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                eggs[i] = new Egg(i, Bird.Randomizer.NextDouble() + 12, "speckled");
            }
            return eggs;
        }
    }
}
