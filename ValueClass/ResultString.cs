using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessTheNumber.Interfaces;

namespace GuessTheNumber.ValueClass
{
    class ResultString : IResult
    {
        private string _resultMes;

        public ResultString(string resultMes)
        {
            _resultMes = resultMes;
        }

        public void Write()
        {
            Console.Write(_resultMes);
        }
    }
}
