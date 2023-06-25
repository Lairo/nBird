using System;

namespace nBird
{
    class BrokenEgg : Egg
    {
        public BrokenEgg(int number, string color) : base(number, double.NegativeInfinity, $"broken {color}")
        {
            Console.WriteLine($"Pigeon bird laid a broken egg");
        }
    }
}