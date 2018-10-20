using Microsoft.EntityFrameworkCore;
using Music.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Music.DAL
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options):base(options)
        {

        }



        public DbSet<Album> Albumes { get; set; }
        public DbSet<Autor> Autores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Album>().HasData(new Album { AlbumId = 1, Nombre = "The beatles" });
            
            
        }
    }
}
