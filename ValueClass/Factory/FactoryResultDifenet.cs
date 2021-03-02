using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.ValueClass.Factory
{
    class FactoryResultDifenet
    {
        public ResultDiferet MakeResultDifferentOfMore(string mes)
        {
            return new ResultDiferet("More", mes);
        }

        public ResultDiferet MakeResultDifferentOfLess(string mes)
        {
            return new ResultDiferet("Less", mes);
        }

        public ResultDiferet MakeResultDifferentOfEqules(string mes)
        {
            return new ResultDiferet("Equlis", mes);
        }
    }
}
