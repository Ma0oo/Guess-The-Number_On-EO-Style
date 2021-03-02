using System;
using GuessTheNumber.Interfaces;
using GuessTheNumber.ValueClass;
using GuessTheNumber.ValueClass.DecoratesResults;
using GuessTheNumber.ValueClass.Factory;

namespace GuessTheNumber.Attemps
{
    class Attempt : IAttempt
    {
        private int _countTry;
        private IDifferent _different;
        private FactoryResultDifferent _factoryResult;


        public Attempt(IDifferent different, int countTry, FactoryResultDifferent factoryResultDifenet)
        {
            _countTry = countTry;
            _different = different;
            _factoryResult = factoryResultDifenet;
        }

        public IResult GetResultAttempt()
        {
            for (int currentTry = 0; currentTry < _countTry; currentTry++)
            {
                ResultDiferent result = _different.Difference();
                if (result.Equals(_factoryResult.MakeResultDifferentOfEqules("")))
                    return new ForgeColorDecorateResultString(
                        new ResultString($"Вы угадали число за {currentTry + 1} попыток"), 
                        ConsoleColor.Green);
                else
                    Console.WriteLine($"Вы не угадали число, число оставшихся попыток = {_countTry - currentTry - 1}. Число - {result}");
            }
            return new ForgeColorDecorateResultString(
                new ResultString($"Вы проиграли и не угадали число за {_countTry} ходов"), 
                ConsoleColor.Red);
        }
    }
}
