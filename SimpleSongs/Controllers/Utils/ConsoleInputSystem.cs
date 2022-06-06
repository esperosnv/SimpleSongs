

namespace SimpleSongs.Controllers.Utils
{
    internal class ConsoleInputSystem : IInputSystem
    {
        public string FetchStringValue(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
