﻿using GuessTheNumber.Interfaces;


namespace GuessTheNumber.Messange.Decorates
{
    class AttempForgeColorDecorate : IMessange
    {
        private IMessange _messange;
        private System.ConsoleColor _color;

        public AttempForgeColorDecorate(IMessange messanger, System.ConsoleColor color)
        {
            _messange = messanger;
            _color = color;
        }

        public void Say(bool delay)
        {
            System.ConsoleColor temp = System.Console.ForegroundColor;
            System.Console.ForegroundColor = _color;
            _messange.Say(delay);
            System.Console.ForegroundColor = temp;

        }
    }
}
