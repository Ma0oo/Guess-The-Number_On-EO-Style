using System;
using GuessTheNumber.Interfaces;

namespace GuessTheNumber.ValueClass
{
    class Secret
    {
        private int _number;

        public Secret(Random random, int min, int max, IMessange message)
        {
            _number = random.Next(min, max);
            message.Say(false);
        }

        public bool More(int compareInt)
        {
            return _number > compareInt;
        }
        public bool Less(int compareInt)
        {
            return _number < compareInt;
        }
    }
}
