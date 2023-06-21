namespace nBird
{
    internal class Pigeon : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                eggs[i] = new Egg(Randomizer.NextDouble() * 2 + 10, "white");
            }
            return eggs;
        }
    }
}
