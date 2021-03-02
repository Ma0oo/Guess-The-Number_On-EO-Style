using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Attempt
    {
        private int _countTry;
        private Different _different;

        public Attempt(Different different, int countTry)
        {
            _countTry = countTry;
            _different = different;
        }

        public string GetResult()
        {
            for (int currentTry = 0; currentTry < _countTry; currentTry++)
            {
                ResultDifenet result = _different.Difference();
                if (result == ResultDifenet.Equally)
                    return $"Вы угадали число за {currentTry + 1} попыток";
                else
                    Console.WriteLine($"Вы не угадали число, число попыток = {_countTry - currentTry - 1}. Число - {result}");
            }
            return $"Вы проиграли и не угадали число за {_countTry} ходов";
        }
    }
}
