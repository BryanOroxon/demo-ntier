using Music.DAL.Repositories;
using Music.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Music.BLL
{
    public class AlbumService : IAlbumServiceRepository
    {
        private readonly IAlbumRepository _albumRepo;
        

        public AlbumService()
        {
            _albumRepo = new AlbumRepositoryEF();
        }

        public IEnumerable<Album> Get()
        {
            return _albumRepo.GetAllAsync();
        }
    }
}
