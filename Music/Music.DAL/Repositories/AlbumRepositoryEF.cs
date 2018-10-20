using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Music.Entities;

namespace Music.DAL.Repositories
{
    public class AlbumRepositoryEF : IAlbumRepository
    {
        private readonly MusicContext _context;

        public AlbumRepositoryEF()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<MusicContext>();
            var connString = configuration.GetConnectionString("default");
            builder.UseSqlServer(connString);
            _context = new MusicContext(builder.Options);
        }

        public IEnumerable<Album> GetAllAsync()
        {
            return _context.Albumes.ToList();
        }
    }
}
