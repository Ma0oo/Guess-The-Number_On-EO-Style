using System;
using GuessTheNumber.Interfaces;
using GuessTheNumber.ValueClass;


namespace GuessTheNumber.ValueClass.DecoratesGuess
{
    class ForgeColorDecorateIntInput : IIntInput
    {
        private ConsoleColor _color;
        private IIntInput _guess;

        public ForgeColorDecorateIntInput(ConsoleColor color, IIntInput guess)
        {
            _color = color;
            _guess = guess;
        }

        public int GetIntFromInput()
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = _color;
            int result = _guess.GetIntFromInput();
            Console.ForegroundColor = temp;
            return result;
        }
    }
}
