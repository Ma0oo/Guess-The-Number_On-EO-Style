using System;
using GuessTheNumber.Interfaces;
using GuessTheNumber.Messange;
using GuessTheNumber.Messange.Decorates;

namespace GuessTheNumber.ValueClass
{
    class FreeIntInput : IIntInput
    {
        public int GetIntFromInput()
        {
            int result = int.MinValue;
            while(Int32.TryParse(Console.ReadLine(), out result) == false)
            {
                new ForgeColorDecorateIMessange(
                    new DialogMessange("Неправильный ввод числа: Вы ввели не число\n"),
                    ConsoleColor.Red).Say(false);
            }
            new ForgeColorDecorateIMessange(
                    new DialogMessange("Вы ввели коректное число\n"),
                    ConsoleColor.Green).Say(false);
            return result;
        }
    }
}
