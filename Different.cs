using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Different
    {
        private Secret _secret;
        private Guess _guess;

        public Different(Secret secret, Guess guess)
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
