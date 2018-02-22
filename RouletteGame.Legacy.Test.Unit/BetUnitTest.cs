using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouletteGame.Legacy;
using NUnit.Framework;
using NSubstitute;

namespace RouletteGame.Legacy.Test.Unit
{
    [TestFixture]
    public class FieldBetUnitTest
    {
        private IFieldBet _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new FieldBet("TestPlayer", 10, 2);
        }

        [Test]
        public void WonAmount_winningField_WonAmountCorrect()
        {
            Assert.That(_uut.WonAmount(new Field(2, Field.Black)), Is.EqualTo(360));
        }

        [Test]
        public void WonAmount_losingField_WonAmountCorrect()
        {
            Assert.That(_uut.WonAmount(new Field(4, Field.Black)), Is.EqualTo(0));
        }
    }
}
