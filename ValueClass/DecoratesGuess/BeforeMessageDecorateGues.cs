using System;
using GuessTheNumber.Interfaces;
using GuessTheNumber.ValueClass;

namespace GuessTheNumber.ValueClass.DecoratesGuess
{
    class BeforeMessageDecorateGues : IGuess
    {
        private string _messge;
        private IGuess _guess;

        public BeforeMessageDecorateGues(string mes, IGuess guess)
        {
            _messge = mes;
            _guess = guess;
        }

        public int GetIntFromInput()
        {
            Console.WriteLine(_messge);
            return _guess.GetIntFromInput();
        }
    }
}
