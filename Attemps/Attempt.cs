using System;
using GuessTheNumber.Interfaces;
using GuessTheNumber.ValueClass;
using GuessTheNumber.ValueClass.DecoratesResults;

namespace GuessTheNumber.Attemps
{
    class Attempt : IAttempt
    {
        private int _countTry;
        private Different _different;

        public Attempt(Different different, int countTry)
        {
            _countTry = countTry;
            _different = different;
        }

        public IResult GetResultAttempt()
        {
            for (int currentTry = 0; currentTry < _countTry; currentTry++)
            {
                ResultDifenet result = _different.Difference();
                if (result == ResultDifenet.Equally)
                    return new ForgeColorDecorateResultString(
                        new ResultString($"Вы угадали число за {currentTry + 1} попыток"), 
                        ConsoleColor.Green);
                else
                    Console.WriteLine($"Вы не угадали число, число попыток = {_countTry - currentTry - 1}. Число - {result}");
            }
            return new ForgeColorDecorateResultString(
                new ResultString($"Вы проиграли и не угадали число за {_countTry} ходов"), 
                ConsoleColor.Red);
        }
    }
}
