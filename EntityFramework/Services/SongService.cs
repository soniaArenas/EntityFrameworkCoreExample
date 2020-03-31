using EntityFramework.Context;
using EntityFramework.Models;

namespace EntityFramework.Services
{
    public class SongService: ISongService
    {
        private readonly IContextDb _contextDb;
        public SongService (IContextDb contextDb)
        {
            _contextDb = contextDb;
        }

        public void AddSong(Song song)
        {
            _contextDb.Songs.Add(song);

            _contextDb.SaveChanges();
        }
    }
}
