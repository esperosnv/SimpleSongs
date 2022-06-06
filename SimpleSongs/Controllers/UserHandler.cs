using SimpleSongs.Controllers.Utils;
using SimpleSongs.Data.Entities;
using SimpleSongs.Views.Interfaces;

namespace SimpleSongs.Controllers
{
    public class UserHandler : BaseHandler<User>
    {
        public UserHandler(IInputSystem inputSystem, IMenuDisplay display) : base(inputSystem, display)
        {
            _availableCommands = new string[] { "1.  ", "2."};

        }

        public override void RunFeatureBasedOn(string userInput)
        {
        }
    }
}
