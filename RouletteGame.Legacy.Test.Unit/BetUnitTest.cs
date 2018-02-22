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
    public class BetUnitTest
    {
        private IFieldBet _fieldBet;
        private IColorbet _colorBet;
        private IEvenOddBet _evenOddBetBet;
        [SetUp]
        public void Setup()
        {
            _fieldBet = Substitute.For<IFieldBet>();
            _colorBet = Substitute.For<IColorbet>();
            _evenOddBetBet = Substitute.For<IEvenOddBet>();
        }

        //[Test]
        //public void tes1()
        //{

        //    _fieldBet.WonAmount().Returns
        //}
    }
}
