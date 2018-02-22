using System;
using System.Collections.Generic;

namespace RouletteGame.Legacy
{
    public class Roulette : IRoulette
    {
        private readonly List<Field> _fields;
        private Field _result;

        private readonly IRandomizer _randomizer;
        //private IFieldFactory _fieldFactory;

        public Roulette(IFieldFactory fieldFactory, IRandomizer randomizer)
        {
            _fields = fieldFactory.GetFields();

            _result = _fields[0];

            _randomizer = randomizer;
        }

        public void Spin()
        {
            var n = _randomizer.GetNext();
            _result = _fields[(int) n];
        }

        public Field GetResult()
        {
            return _result;
        }
    }
}