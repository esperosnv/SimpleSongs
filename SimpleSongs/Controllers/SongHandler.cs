using System;
using System.Collections.Generic;
using SimpleSongs.Data.DAL;
using SimpleSongs.Views;
using SimpleSongs.Controllers.Utils;
using SimpleSongs.Data.Entities;
using SimpleSongs.Views.Interfaces;
using SimpleSongs.Data.DAL;

namespace SimpleSongs.Controllers
{
    public class SongHandler : BaseHandler<Song>
    {
        private readonly IBaseRepository<Song> _songRepository;
        private readonly SongFactory _songFactory;




        public SongHandler(IBaseRepository<Song> songRepository, IInputSystem inputSystem, IView<Song> view, IMenuDisplay display) : base(inputSystem, view, display)
        {
            _songRepository = songRepository;
            _songFactory = new SongFactory(inputSystem);

        }

        public List<Song> GetAllSongs()
        {
            var classes = _songRepository.GetAll();
            return classes;
        }
        public Song CreateSong()
        {
            var newSong = _songFactory.GetNewSong();
            _songRepository.Add(newSong);
            _songRepository.Save();
            return newSong;
        }
        public Song DeleteSong()
        {
            Song selectedSong = GetSong("delete");
            _songRepository.Delete(selectedSong);
            _songRepository.Save();
            return selectedSong;
        }

        public Song GetSong(string action)
        {
            ShowSongsList(GetAllSongs());
            Song selectSong;
            do
            {
                try
                {
                    string songName = _inputSystem.FetchStringValue($"Enter the name of class you want to {action}").Trim();
                    selectSong = _songRepository.GetSingle(song => song.Title == songName);
                    break;
                }
                catch (Exception ex) { _display.PrintMessage(ex.Message); }
            } while (true);
            Console.WriteLine(selectSong.Title);
            return selectSong;
        }

        public Song UpdateSong()
        {
            Song selectedSong = GetSong("update");
            string selectedOption = _inputSystem.FetchStringValue("What do you want update: \n1. Title\n2. Author\n3. Album name\n4. Length");

            switch (selectedOption)
            {
                case "1":
                    selectedSong.Title = _inputSystem.FetchStringValue("Enter new title for song:").Trim();
                    break;
                case "2":
                    selectedSong.Author = _inputSystem.FetchStringValue("Enter new author for song:").Trim();
                    break;
                case "3":
                    selectedSong.AlbumName = _inputSystem.FetchStringValue("Enter new album name for song:").Trim();
                    break;
                case "4":
                    selectedSong.Length = _inputSystem.FetchDoubleValue("Enter new length for song:");
                    break;
                default:
                    _display.PrintMessage("Wrong option");
                    break;
            }

            _songRepository.Edit(selectedSong);
            _songRepository.Save();
            return selectedSong;
        }


        //public void CRUD_SongData(string partNumber)
        //{
        //    switch (partNumber)
        //    {
        //        case "1":
        //            selectedSong.Title = _inputSystem.FetchStringValue("Enter new title for song:").Trim();
        //            break;
        //        case "2":
        //            selectedSong.Author = _inputSystem.FetchStringValue("Enter new author for song:").Trim();
        //            break;
        //        case "3":
        //            selectedSong.AlbumName = _inputSystem.FetchStringValue("Enter new album name for song:").Trim();
        //            break;
        //        case "4":
        //            selectedSong.Length = _inputSystem.FetchDoubleValue("Enter new length for song:");
        //            break;
        //        default:
        //            _display.PrintMessage("Wrong option");
        //            break;
        //    }
        //}




        public void ShowSongsList(List<Song> songsList)
        {
            _view.DisplayAll(songsList);
        }
        public void ShowOneSong(Song song)
        {
            _view.DisplaySingle(song);
        }

        public override void RunFeatureBasedOn(string userInput)
        {
            throw new NotImplementedException();
        }
    }
}
