using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame.Legacy.Test.Unit
{
    class FakeFieldFactory : IFieldFactory
    {
        public List<Field> GetFields()
        {
            return new List<Field>
            {
                new Field(0, Field.Green),
                new Field(1, Field.Red),
                new Field(2, Field.Black),
                new Field(3, Field.Red),
                new Field(4, Field.Black)
            };
        }
    }
}
