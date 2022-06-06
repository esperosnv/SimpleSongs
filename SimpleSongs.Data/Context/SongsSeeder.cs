using System;
using System.Collections.Generic;
using System.Linq;
using SimpleSongs.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace SimpleSongs.Data.Context
{
    public static class SongsSeeder
    {
        public static void SeedDatabase(this ModelBuilder builder)
        {
            List<Song> songs = new();

            songs.Add(new Song()
            {
                SongId = Guid.NewGuid(),
                Title = "Imagine",
                Author = "John Lennon",
                AlbumName = "Imagine",
                Length = 3.05
            });
            songs.Add(new Song()
            {
                SongId = Guid.NewGuid(),
                Title = "Yesterday",
                Author = "The Beatles",
                AlbumName = "Help!",
                Length = 2.05
            });
            songs.Add(new Song()
            {
                SongId = Guid.NewGuid(),
                Title = "Smells Like Teen Spirit",
                Author = "Nirvana",
                AlbumName = "Nevermind",
                Length = 5.02
            });
            songs.Add(new Song()
            {
                SongId = Guid.NewGuid(),
                Title = "Bohemian Rhapsody",
                Author = "Queen",
                AlbumName = "A Night at the Opera",
                Length = 5.92
            });
            songs.Add(new Song()
            {
                SongId = Guid.NewGuid(),
                Title = "Earth Song",
                Author = "Michael Jackson",
                AlbumName = "HIStory: Past, Present and Future, Book I",
                Length = 6.92
            });
            songs.Add(new Song()
            {
                SongId = Guid.NewGuid(),
                Title = "Frozen",
                Author = "Madonna",
                AlbumName = "Ray of Light",
                Length = 6.20
            });

            builder.Entity<Song>().HasData(songs);

        }
    }
}
