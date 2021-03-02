using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class CheckInt
    {
        int _min, _max;
        public CheckInt(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public bool TryParserToInt(string str, ref int result)
        {
            if (Int32.TryParse(str, out result))
            {
                if (result <= _max && result >= _min)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
    }
}
