using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Music.Entities;

namespace Music.DAL.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        
        public IEnumerable<Album> GetAllAsync()
        {
            List<Album> albumes = new List<Album>();

           albumes.Add(new Album { AlbumId = 1, Nombre = "The Beatles......."});
           return albumes;
        }
    }
}
