using GuessTheNumber.ValueClass;
using GuessTheNumber.Interfaces;

namespace GuessTheNumber
{
    class Different
    {
        private Secret _secret;
        private IGuess _guess;

        public Different(Secret secret, IGuess guess)
        {
            _secret = secret;
            _guess = guess;
        }

        public ResultDifenet Difference()
        {
            int guess = _guess.GetIntFromInput();
            if (_secret.IsMore(guess))
                return ResultDifenet.More;
            else if (_secret.IsLess(guess))
                return ResultDifenet.Less;
            else
                return ResultDifenet.Equally;
        }
    }
}
