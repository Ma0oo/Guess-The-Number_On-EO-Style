using System;
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
            Console.WriteLine(_attempt.GetResult());
            if(delay)
                Console.ReadKey();
        }
    }
}
