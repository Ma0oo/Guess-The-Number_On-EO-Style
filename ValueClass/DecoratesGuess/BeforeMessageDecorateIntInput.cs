using System;
using GuessTheNumber.Interfaces;
using GuessTheNumber.ValueClass;

namespace GuessTheNumber.ValueClass.DecoratesGuess
{
    class BeforeMessageDecorateIntInput : IIntInput
    {
        private string _messge;
        private IIntInput _guess;

        public BeforeMessageDecorateIntInput(string mes, IIntInput guess)
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
