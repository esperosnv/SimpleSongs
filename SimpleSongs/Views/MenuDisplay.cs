using SimpleSongs.Views.Interfaces;

namespace SimpleSongs.Views
{
    internal class MenuDisplay : IMenuDisplay
    {
        public void ClearScreen()
        {
            Console.Clear();
        }

        public void PrintMany<T>(List<T> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintMessage(string content)
        {
            Console.WriteLine(content);
        }

        public void PrintOptions(List<string> options)
        {
            Console.WriteLine("~~~~~~ Options available ~~~~~~");
            options.ForEach(Console.WriteLine);
        }
    }
}
