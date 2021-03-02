using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.ValueClass
{
    class Guess
    {
        private CheckInt _checkInt;

        public Guess(CheckInt checkInt)
        {
            _checkInt = checkInt;
        }

        public int GetIntFromInput()
        {
            int result = int.MinValue;
            Console.WriteLine("Введите число");
            while (_checkInt.TryParserToInt(Console.ReadLine(), ref result) == false)
            {
                Console.WriteLine("Некоректный ввод");
                Console.WriteLine("Введите число ещё раз \n");
            }
            return result;
        }
    }
}
