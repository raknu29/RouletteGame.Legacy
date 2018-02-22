using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame.Legacy
{
    class Randomizer : IRandomizer
    {
        public uint GetNext()
        {
            return (uint)new Random().Next(0, 37);
        }
    }
}
