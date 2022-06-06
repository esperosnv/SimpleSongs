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



        public SongHandler(IBaseRepository<Song> songRepository, IInputSystem inputSystem, IView<Song> view, IMenuDisplay display) : base(inputSystem, view, display)
        {
            _songRepository = songRepository;
        }

        public List<Song> GetAllSongs()
        {
            var classes = _songRepository.GetAll();
            return classes;
        }

        public void ShowSongsList(List<Song> songsList)
        {
            _view.DisplayAll(songsList);
        }

        public override void RunFeatureBasedOn(string userInput)
        {
            throw new NotImplementedException();
        }
    }
}
