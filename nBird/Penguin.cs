using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nBird
{
    class Penguin : Bird
    {
        public override void Fly()
        {
            Console.Error.WriteLine("Warning");
            Console.Error.WriteLine("FLying Penguin Alert");
        }
    }
}
