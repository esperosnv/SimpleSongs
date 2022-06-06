using SimpleSongs.Controllers.Utils;
using SimpleSongs.Data.Entities;
using SimpleSongs.Views.Interfaces;

namespace SimpleSongs.Controllers
{
    public class UserHandler : BaseHandler<User>
    {
        private readonly SongHandler _songHandler;


        public UserHandler(SongHandler songHandler, IInputSystem inputSystem, IView<User> view, IMenuDisplay display) : base(inputSystem, view, display)
        {
            _songHandler = songHandler;
            _availableCommands = new string[] { "1. Show all songs ", "2."};

        }

        public void GetSongs()
        {
            List<Song> songsList = _songHandler.GetAllSongs();
            _songHandler.ShowSongsList(songsList);

        }

        public override void RunFeatureBasedOn(string userInput)
        {
            string nextUserInput;
            switch (userInput)
            {
                case "1":
                    GetSongs();
                    break;
                default:
                    Console.WriteLine("User");
                    break;
            }
            //GetSongs();
        }
    }
}
