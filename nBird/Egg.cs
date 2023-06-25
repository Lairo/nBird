using System;

namespace nBird
{
    class Egg
    {
        public double Size { get; private set; }
        public string Color { get; private set; }
        public int Number { get;}
        public Egg(int number, double size , string color)
        {
            Number = number + 1;
            Size = size;
            Color = color;
        }
        public string Description
        {
            get { return $"{Number}# {Size:0.0}cm {Color} egg"; }
        }
    }
}
