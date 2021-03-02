using System;
using GuessTheNumber.Attemps;
using GuessTheNumber.Messange;
using GuessTheNumber.Messange.Decorates;
using GuessTheNumber.ValueClass;
using GuessTheNumber.ValueClass.DecoratesGuess;
using GuessTheNumber.Interfaces;


namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 100;
            int countTry = 5;

            new AttempMessange(
                new Attempt(
                    new Different(
                        new Secret(new Random(), min, max),
                            new  ForgeColorDecorateGuess(ConsoleColor.Cyan,
                                new BeforeMessageDecorateGues($"Попробуйте угадать число. В водить только цифры {min}-{max}. У вас {countTry} попыток.", 
                                    new Guess(
                                        new CheckInt(min, max)
                                        )
                                    )
                                )
                            ), countTry
                        )   
                    ).Say(true);
        }
    }

    public enum ResultDifenet
    {
        More, Less, Equally
    }
}
