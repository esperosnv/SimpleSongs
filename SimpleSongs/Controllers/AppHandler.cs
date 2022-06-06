using System;
using SimpleSongs.Views.Interfaces;
using SimpleSongs.Controllers.Utils;



namespace SimpleSongs.Controllers
{
    public class AppHandler
    {
        private readonly IInputSystem _inputSystem;
        private readonly IMenuDisplay _display;

        public AppHandler()
        {
            _inputSystem = new ConsoleInputSystem();
          //  _display = 
        }


        public void Run()
        {
            Console.WriteLine("Hello!");
        }
    }
}
