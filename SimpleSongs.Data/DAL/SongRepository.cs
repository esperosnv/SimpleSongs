using System;
using System.Collections.Generic;
using System.Linq;
using SimpleSongs.Data.Context;
using SimpleSongs.Data.Entities;

namespace SimpleSongs.Data.DAL
{
    public class SongRepository : IBaseRepository<Song>
    {

        private SongsContext _songsContext;
        public SongRepository()
        {
            _songsContext = new SongsContext();
        }
        public void Add(Song entity)
        {
            _songsContext.Songs.Add(entity);
        }

        public void Delete(Song entity)
        {
            _songsContext.Songs.Remove(entity);
        }

        public void Edit(Song entity)
        {
            _songsContext.Songs.Update(entity);
        }

        public List<Song> GetAll()
        {
            return _songsContext.Songs.ToList();
        }
 

        public Song GetSingle(Func<Song, bool> condition)
        {
            return _songsContext.Songs.Where(condition).First();
        }

        public void Save()
        {
            _songsContext.SaveChanges();
        }
    }
}
