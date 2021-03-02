using System;
using GuessTheNumber.Attemps;
using GuessTheNumber.Interfaces;


namespace GuessTheNumber.Messange
{
    class DialogMessange : IMessange
    {
        private string _messamge;

        public DialogMessange(string messange)
        {
            _messamge = messange;
        }

        public void Say(bool delay)
        {
            Console.Write(_messamge);
        }
    }
}
