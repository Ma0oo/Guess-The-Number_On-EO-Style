using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 5000;
            int countTry = 100;
            Random random = new Random();

            Secret secret = new Secret(random, min, max);

            new Messange(
                new Attempt(
                    new Different(
                        secret,
                        new Guess(
                            new CheckInt(min, max)
                            )
                        ), countTry
                    )
                ).Say();
        }
    }

    class Secret
    {
        private int _number;

        public Secret(Random random, int min, int max)
        {
            _number = random.Next(min, max);
            Console.WriteLine($"Число загадано между {min} и {max}");
        }

        public bool IsMore(int compareInt)
        {
            return _number > compareInt;
        }
        public bool IsLess(int compareInt)
        {
            return _number < compareInt;
        }
    }

    class Guess
    {
        private CheckInt _checkInt;

        public Guess(CheckInt checkInt)
        {
            _checkInt = checkInt;
        }

        public int GetIntFromInput()
        {
            int result = int.MinValue;
            Console.WriteLine("Введите число");
            while (_checkInt.TryParserToInt(Console.ReadLine(), ref result) == false)
            {
                Console.WriteLine("Некоректный ввод");
                Console.WriteLine("Введите число ещё раз \n");
            }
            return result;
        }
    }

    class CheckInt
    {
        int _min, _max;
        public CheckInt(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public bool TryParserToInt(string str, ref int result)
        {
            if (Int32.TryParse(str, out result))
            {
                if (result <= _max && result >= _min)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
    }

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

    class Attempt
    {
        private int _countTry;
        private Different _different;

        public Attempt(Different different, int countTry)
        {
            _countTry = countTry;
            _different = different;
        }

        public string GetResult()
        {
            for (int currentTry = 0; currentTry < _countTry; currentTry++)
            {
                ResultDifenet result = _different.Difference();
                if (result == ResultDifenet.Equally)
                    return $"Вы угадали число за {currentTry + 1} попыток";
                else
                    Console.WriteLine($"Вы не угадали число, число попыток = {_countTry-currentTry-1}. Число - {result}");
            }
            return $"Вы проиграли и не угадали число за {_countTry} ходов";
        }
    }

    class Messange
    {
        private Attempt _attempt;

        public Messange (Attempt attempt)
        {
            _attempt = attempt;
        }

        public void Say()
        {
            Console.WriteLine(_attempt.GetResult());
            Console.ReadKey();
        }
    }

    public enum ResultDifenet
    {
        More, Less, Equally
    }
}
