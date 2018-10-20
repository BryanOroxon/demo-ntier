using Music.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Music.Entities
{
    public interface IAlbumServiceRepository
    {
        IEnumerable<Album> Get();
    }
}
