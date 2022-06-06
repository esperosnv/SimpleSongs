using System;
using System.Collections.Generic;
using System.Linq;
using SimpleSongs.Views.Interfaces;
using SimpleSongs.Data.Entities;

namespace SimpleSongs.Views
{
    public class SongConsoleView : IView<Song>
    {
        public void DisplayAll(List<Song> entities)
        {
            entities.ForEach(DisplaySingle);
        }

        public void DisplaySingle(Song entity)
        {
            Console.WriteLine($"Song title: {entity.Title}, Author: {entity.Author}, AlbumName: {entity.AlbumName}, Length: {entity.Length}");
        }
    }
}
