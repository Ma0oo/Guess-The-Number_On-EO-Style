using System;
using GuessTheNumber.Messange;
using GuessTheNumber.Messange.Decorates;
using GuessTheNumber.Interfaces;

namespace GuessTheNumber
{
    class CheckInt
    {
        int _min, _max;
        public CheckInt(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public bool TryParserToInt(string str, ref int valueResult, out IMessange erroMessage)
        {
            if (Int32.TryParse(str, out valueResult))
            {
                if (valueResult <= _max && valueResult >= _min)
                {
                    erroMessage = new ForgeColorDecorateIMessange(new DialogMessange("Удачно \n"), ConsoleColor.Green);
                    return true;
                }
                else
                {
                    erroMessage = new ForgeColorDecorateIMessange(
                        new DialogMessange("Число выходит за пределы значения \n"), 
                        ConsoleColor.Red);
                    return false;
                }
            }
            else
            {
                erroMessage = new ForgeColorDecorateIMessange(
                    new DialogMessange("Это не число \n"), 
                    ConsoleColor.Red);
                return false;
            }
        }
    }
}
