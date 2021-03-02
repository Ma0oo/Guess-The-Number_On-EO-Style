using System;
using GuessTheNumber.Attemps;
using GuessTheNumber.Interfaces;

namespace GuessTheNumber.Messange
{
    class AttempMessange : IMessange
    {
        private Attempt _attempt;

        public AttempMessange(Attempt attempt)
        {
            _attempt = attempt;
        }

        public void Say(bool delay)
        {
            _attempt.GetResultAttempt().Write();
            if(delay)
                Console.ReadKey();
        }
    }
}
