using System;
using GuessTheNumber.Interfaces;
using GuessTheNumber.ValueClass;


namespace GuessTheNumber.ValueClass.DecoratesGuess
{
    class ForgeColorDecorateGuess : IGuess
    {
        private ConsoleColor _color;
        private IGuess _guess;

        public ForgeColorDecorateGuess(ConsoleColor color, IGuess guess)
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
