using System;

namespace nBird
{
    class Pigeon : Bird
    {
        const int MAXIMUMEGGS = 2;
        public override Egg[] LayEggs(int numberOfEggs)
        {
            if (numberOfEggs > MAXIMUMEGGS)
            {
                numberOfEggs = MAXIMUMEGGS;
                Console.WriteLine("Pigeons can only lay between 1-2eggs at a time");
            }

            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                if (Bird.Randomizer.Next(4) == 0)
                    eggs[i] = new BrokenEgg("white");
                else
                    eggs[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, "white");
            }
            return eggs;

        }
    }
}
