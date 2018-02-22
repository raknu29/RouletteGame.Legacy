using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame.Legacy
{
    public interface IBet
    {


        string PlayerName { get; }
        uint Amount { get; }

        uint WonAmount(Field field);

    }

    public interface IFieldBet : IBet
    {

    }

    public interface IColorbet : IBet
    {

    }

    public interface IEvenOddBet : IBet
    {

    }
}
