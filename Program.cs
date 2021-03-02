using System;
using GuessTheNumber.Messange;
using GuessTheNumber.Messange.Decorates;


namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 100;
            int countTry = 100;

            Random random = new Random();
            Secret secret = new Secret(random, min, max);

            new AttempForgeColorDecorate(
                new AttempMessange(
                    new Attempt(
                        new Different(
                            secret,
                            new Guess(
                                new CheckInt(min, max)
                            )
                        ), countTry
                    )
                ), ConsoleColor.Cyan).Say(true);
    }
    }

    public enum ResultDifenet
    {
        More, Less, Equally
    }
}
