using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.ValueClass
{
    class ResultDiferet
    {
        private string _typeDiferet;
        private string _message;

        public ResultDiferet(string typeDiferent, string message)
        {
            _typeDiferet = typeDiferent;
            _message = message;
        }

        public override string ToString()
        {
            return _message;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            return ((ResultDiferet)obj)._typeDiferet == this._typeDiferet;
        }
    }
}
