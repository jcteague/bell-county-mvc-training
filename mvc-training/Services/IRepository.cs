using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Xml.Serialization;
using mvc_training.Domain;

namespace MvcTraining.Services
{
    public interface IRepository<T>
    {
        IEnumerable<T>Get();
        void Save(T item);
    }

    public class SongRepostiory : IRepository<Song>
    {
        public IEnumerable<Song> Get()
        {
            return Database.Songs;
        }

        public void Save(Song item)
        {
            Database.Songs.Add(item);
        }
    }
    public class AlbumRepository :IRepository<Album>
    {
        public IEnumerable<Album> Get()
        {
            return Database.Albums;
        }

        public void Save(Album item)
        {
            Database.Albums.Add(item);
        }
    }



    
}