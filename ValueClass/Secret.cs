using System;

namespace GuessTheNumber.ValueClass
{
    class Secret
    {
        private int _number;

        public Secret(Random random, int min, int max)
        {
            _number = random.Next(min, max);
            Console.WriteLine($"Число загадано между {min} и {max}");
        }

        public bool IsMore(int compareInt)
        {
            return _number > compareInt;
        }
        public bool IsLess(int compareInt)
        {
            return _number < compareInt;
        }
    }
}
