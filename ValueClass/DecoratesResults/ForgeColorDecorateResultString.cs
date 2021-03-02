using GuessTheNumber.Interfaces;

namespace GuessTheNumber.ValueClass.DecoratesResults
{
    class ForgeColorDecorateResultString : IResult
    {
        private IResult _result;
        private System.ConsoleColor _color;

        public ForgeColorDecorateResultString(IResult result, System.ConsoleColor color)
        {
            _result = result;
            _color = color;
        }


        public void Write()
        {
            System.ConsoleColor temp = System.Console.ForegroundColor;
            System.Console.ForegroundColor = _color;
            _result.Write();
            System.Console.ForegroundColor = temp;
        }
    }
}
