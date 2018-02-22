using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame.Legacy.Test.Unit
{
    class FakeRoulette : IRoulette
    {
        private Field _result;

        public FakeRoulette()
        {
            //TODO
        }

        public void Spin()
        {
            //ToDO
        }

        public Field GetResult()
        {
            //TODO
            return _result;
        }
    }
}
