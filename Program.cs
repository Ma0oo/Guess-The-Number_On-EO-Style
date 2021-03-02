using System;
using GuessTheNumber.Attemps;
using GuessTheNumber.Messange;
using GuessTheNumber.ValueClass;
using GuessTheNumber.ValueClass.DecoratesGuess;
using GuessTheNumber.ValueClass.Factory;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 100;
            int countTry = 8;

            FactoryResultDifenet factoryResult = new FactoryResultDifenet();

            new AttempMessange(
                new Attempt(
                    new Different(
                        new Secret(new Random(), min, max),
                            factoryResult,
                                new  ForgeColorDecorateGuess(ConsoleColor.Cyan,
                                    new BeforeMessageDecorateGues($"Попробуйте угадать число, вводить только цифры {min}-{max}", 
                                        new Guess(
                                            new CheckInt(min, max)
                                        )
                                    )
                                )
                            ), 
                    countTry,
                    factoryResult
                        )   
                    ).Say(true);
        }
    }
}