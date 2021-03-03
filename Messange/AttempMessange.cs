using System;
using GuessTheNumber.Attemps;
using GuessTheNumber.Interfaces;

namespace GuessTheNumber.Messange
{
    class AttempMessange : IMessange
    {
        private IAttempt _attempt;

        public AttempMessange(IAttempt attempt)
        {
            _attempt = attempt;
        }

        public void Say(bool delay)
        {
            _attempt.GetResultAttempt().Say(false);
            if(delay)
                Console.ReadKey();
        }
    }
}
