using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.ValueClass.Factory
{
    class FactoryResultDifferent
    {
        public ResultDiferent MakeResultDifferentOfMore(string mes)
        {
            return new ResultDiferent("More", mes);
        }

        public ResultDiferent MakeResultDifferentOfLess(string mes)
        {
            return new ResultDiferent("Less", mes);
        }

        public ResultDiferent MakeResultDifferentOfEqules(string mes)
        {
            return new ResultDiferent("Equlis", mes);
        }
    }
}
