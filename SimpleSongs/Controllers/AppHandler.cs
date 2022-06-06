using SimpleSongs.Views;
using SimpleSongs.Views.Interfaces;
using SimpleSongs.Controllers.Interfaces;
using SimpleSongs.Controllers.Utils;



namespace SimpleSongs.Controllers
{
    public class AppHandler
    {
        private readonly IInputSystem _inputSystem;
        private readonly IMenuDisplay _display;
        private IUserDataManager _userHandler;


        public AppHandler()
        {
            _inputSystem = new ConsoleInputSystem();
            _display = new MenuDisplay();
            _userHandler = new UserHandler(_inputSystem, _display);
        }

     

        public void Run()
        {
            Console.WriteLine("Hello!");
            _userHandler.Run(); 
        }
    }
}
