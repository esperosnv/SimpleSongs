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
            _availableCommands = new string[] { "1. Show all songs ", "2. Add new song", "3. Delete song", "4. Update song", "5. Sort songs", "6. Select song"};

        }


        public override void RunFeatureBasedOn(string userInput)
        {
            string nextUserInput;
            switch (userInput)
            {
                case "1":
                    GetSongs();
                    break;
                case "2":
                    AddNewSong();
                    break;
                case "3":
                    DeleteSong();
                    break;
                case "4":
                    UpdateSong();
                    break;
                case "5":
                    SortSongs();
                    break;
                case "6":
                    SelectSong();
                    break;
                default:
                    Console.WriteLine("User");
                    break;
            }
        }

        public void GetSongs()
        {
            List<Song> songsList = _songHandler.GetAllSongs();
            _songHandler.ShowSongsList(songsList);

        }

        public void AddNewSong()
        {
            Song newSong = _songHandler.CreateSong();
            _songHandler.ShowOneSong(newSong);
        }
        public void DeleteSong()
        {
            Song deletedSong = _songHandler.DeleteSong();
            Console.WriteLine("This song was deleted:");
            _songHandler.ShowOneSong(deletedSong);
        }
        public void UpdateSong()
        {
            Song updatedSong = _songHandler.UpdateSong();
            _songHandler.ShowOneSong(updatedSong);
        }
        public void SortSongs()
        {
            List<Song> sortedSongs = _songHandler.SortSongs();
            _songHandler.ShowSongsList(sortedSongs);
        }

        public void SelectSong()
        {
            Song selectedSong = _songHandler.GetSong("get");
            _songHandler.ShowOneSong(selectedSong);

        }
    }
}
