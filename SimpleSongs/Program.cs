using SimpleSongs.Controllers;

namespace SimpleSongs
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            AppHandler appHandler = new();
            appHandler.Run();
        }
    }
}