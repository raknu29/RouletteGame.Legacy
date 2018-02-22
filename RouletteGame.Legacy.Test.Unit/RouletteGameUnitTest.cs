using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace RouletteGame.Legacy.Test.Unit
{
    [TestFixture]
    class RouletteGameUnitTest
    {
        private IRoulette _roulette;
        private RouletteGame _uut;
        private IFieldBet _fieldBet;

        [SetUp]
        public void Setup()
        {
            _roulette = Substitute.For<IRoulette>();
            _uut = new RouletteGame(_roulette);
            _roulette.GetResult().Returns(new Field(2, Field.Black));
            _fieldBet = Substitute.For<IFieldBet>();
            _fieldBet.PlayerName.Returns("TestPlayer");
        }

        [Test]
        public void OpenBets_IsRoundOpen_True()
        {
            _uut.OpenBets();
            Assert.That(_uut.RoundIsOpen, Is.True);
        }

        [Test]
        public void CloseBets_isRoundOpen_False()
        {
            _uut.CloseBets();
            Assert.That(_uut.RoundIsOpen, Is.False);
        }

        [Test]
        public void PlaceBet_OpenForBets_Succes()
        {
            _uut.OpenBets();
            _uut.PlaceBet(_fieldBet);
            Assert.That(_uut.Bets.Last().PlayerName, Is.EqualTo(_fieldBet.PlayerName));
            // Could also assert on length of list 
        }

        [Test]
        public void PlaceBet_ClosedForBets_Failure()
        {
            _uut.CloseBets();
            Assert.Throws<RouletteGameException>((() => _uut.PlaceBet(_fieldBet)));
        }
    }
}
