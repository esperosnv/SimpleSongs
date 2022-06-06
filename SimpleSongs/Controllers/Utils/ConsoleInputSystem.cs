using System;


namespace SimpleSongs.Controllers.Utils
{
    internal class ConsoleInputSystem : IInputSystem
    {
        public string FetchStringValue(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public double FetchDoubleValue(string prompt)
        {
            Console.WriteLine(prompt);
            double valueResult = 0;
            bool isResultString = true;

            while (isResultString)
            {
                if (double.TryParse(Console.ReadLine().Trim(), out valueResult) && valueResult > 0) isResultString = false;
                else Console.WriteLine("Invalid input");
            }
            return valueResult;
        }
    }
}
