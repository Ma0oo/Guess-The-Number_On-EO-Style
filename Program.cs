using System;
using GuessTheNumber.Attemps;
using GuessTheNumber.Messange;
using GuessTheNumber.Messange.Decorates;
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

            FactoryResultDifferent factoryResult = new FactoryResultDifferent();

            new AttempMessange(
                new Attempt(
                    new Different(
                        new Secret(
                            new Random(), 
                                min, 
                                max, 
                                new ForgeColorDecorateIMessange(
                                    new DialogMessange(
                                        $"Загадано число между {min} и {max}"), 
                                    ConsoleColor.Blue)),
                            factoryResult,
                            new  ForgeColorDecorateGuess(
                                ConsoleColor.Yellow,
                                new BeforeMessageDecorateGues(
                                    $"\nПопробуйте угадать число, вводить только цифры {min}-{max}", 
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