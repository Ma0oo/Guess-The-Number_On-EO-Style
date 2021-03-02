using GuessTheNumber.ValueClass;
using GuessTheNumber.Interfaces;
using GuessTheNumber.ValueClass.Factory;

namespace GuessTheNumber
{
    class Different : IDifferent
    {
        private Secret _secret;
        private FactoryResultDifenet _factoryResult;
        private IGuess _guess;

        public Different(Secret secret, FactoryResultDifenet factoryResult ,IGuess guess)
        {
            _secret = secret;
            _guess = guess;
            _factoryResult = factoryResult;
        }

        public ResultDiferet Difference()
        {
            int guess = _guess.GetIntFromInput();
            if (_secret.IsMore(guess))
                return _factoryResult.MakeResultDifferentOfMore(": Число должно быть больше");
            else if (_secret.IsLess(guess))
                return _factoryResult.MakeResultDifferentOfLess(": Число должно быть меньше");
            else
                return _factoryResult.MakeResultDifferentOfEqules(": Число - правильное");
        }
    }
}
