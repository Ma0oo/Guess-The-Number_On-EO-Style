using System;
using GuessTheNumber.Interfaces;

namespace GuessTheNumber.Messange.Decorates
{
    class EndlessRepetitionWithExitDecorateIMessange : IMessange
    {
        private IMessange _decorateMessange;
        private IMessange _dialogMessange;
        private IIntInput _input;
        private int _numberToExit;

        public EndlessRepetitionWithExitDecorateIMessange(IMessange decorateMessange, IIntInput intInput, IMessange dialogMessange, int numberToExit)
        {
            _decorateMessange = decorateMessange;
            _input = intInput;
            _dialogMessange = dialogMessange;
            _numberToExit = numberToExit;
        }

        public void Say(bool delay)
        {
            while (true)
            {
                _decorateMessange.Say(delay);
                Console.Clear();
                _dialogMessange.Say(false);
                if (_input.GetIntFromInput() == _numberToExit)
                    break;
            }
        }
    }
}
