using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;

namespace RouletteGame.Legacy.Test.Unit
{
    [TestFixture]
    class RouletteUnitTest
    {
        private IFieldFactory _fieldFactory;
        private IRandomizer _randomizer;
        private Roulette _uut;

        [SetUp]
        public void Setup()
        {
            _fieldFactory = new FakeFieldFactory();
            _randomizer = Substitute.For<IRandomizer>();
            _randomizer.GetNext().Returns((uint)2);
            _uut = new Roulette(_fieldFactory, _randomizer);
        }

        [Test]
        public void Spin_SpinRoulette_CorrectResult()
        {
            Field expectedResult = new Field(2, Field.Black);
            _uut.Spin();
            Assert.That(_uut.GetResult().ToString(), Is.EqualTo(expectedResult.ToString()));
        }
    }
}
