using System;
using System.Collections.Generic;

namespace SimpleSongs.Data.Entities
{
    public class Song
    {
        public Guid SongId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string AlbumName { get; set; }
        public double Length { get; set; }

    }
}
