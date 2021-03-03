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
            new EndlessRepetitionWithExitDecorateIMessange(
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
                                new  ForgeColorDecorateIntInput(
                                    ConsoleColor.Yellow,
                                    new BeforeMessageDecorateIntInput(
                                        $"\nПопробуйте угадать число, вводить только цифры {min}-{max}", 
                                        new BoundedIntInput(
                                            new CheckInt(min, max)
                                            )
                                        )
                                    )
                                ), 
                        countTry,
                        factoryResult
                        )  
                    ),
                new FreeIntInput(),
                new ForgeColorDecorateIMessange(
                    new DialogMessange("Введите 0 для выхода. Другое число продолжит игру\n"),
                    ConsoleColor.Magenta), 
                0).Say(true);
        }
    }
}