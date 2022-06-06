using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleSongs.Data.Entities;

namespace SimpleSongs.Controllers.Utils
{
    internal class SongFactory
    {
        private readonly IInputSystem _inputSystem;

        public SongFactory(IInputSystem inputSystem)
        {
            _inputSystem = inputSystem;
        }

        public Song GetNewSong()
        {
            Guid songId = Guid.NewGuid();
            string title = _inputSystem.FetchStringValue("Provide title: ").Trim();
            string author = _inputSystem.FetchStringValue("Provide author: ").Trim();

            string albumName = _inputSystem.FetchStringValue("Provide album name: ").Trim();
            double length = _inputSystem.FetchDoubleValue("Provide length: ");


            return new Song
            {
                SongId = songId,    
                Title = title,
                Author = author,
                AlbumName = albumName,
                Length = length,
            };
        }
    }
}
