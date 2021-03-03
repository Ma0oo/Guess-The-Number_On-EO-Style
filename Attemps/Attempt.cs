using System;
using GuessTheNumber.Interfaces;
using GuessTheNumber.Messange;
using GuessTheNumber.Messange.Decorates;
using GuessTheNumber.ValueClass;
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

        public IMessange GetResultAttempt()
        {
            for (int currentTry = 0; currentTry < _countTry; currentTry++)
            {
                ResultDiferent result = _different.Difference();
                if (result.Equals(_factoryResult.MakeResultDifferentOfEqules("")))
                    return new ForgeColorDecorateIMessange(
                        new DialogMessange($"Вы угадали число за {currentTry + 1} попыток"), 
                        ConsoleColor.Green);
                else
                    Console.WriteLine($"Вы не угадали число, число оставшихся попыток = {_countTry - currentTry - 1}. Число - {result}");
            }
            return new ForgeColorDecorateIMessange(
                new DialogMessange($"Вы проиграли и не угадали число за {_countTry} ходов"), 
                ConsoleColor.Red);
        }
    }
}
