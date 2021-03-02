using System;
using GuessTheNumber.Interfaces;

namespace GuessTheNumber.ValueClass
{
    class Guess : IGuess
    {
        private CheckInt _checkInt;

        public Guess(CheckInt checkInt)
        {
            _checkInt = checkInt;
        }

        public int GetIntFromInput()
        {
            int result = int.MinValue;
            while (_checkInt.TryParserToInt(Console.ReadLine(), ref result, out IMessange errotText) == false)
            {
                errotText.Say(false);
                Console.WriteLine("Введите число ещё раз \n");
            }
            return result;
        }
    }
}
