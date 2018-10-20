using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Music.DAL
{
    public class MusicDbContexFactory : IDesignTimeDbContextFactory<MusicContext>
    {
        public MusicContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<MusicContext>();
            var connString = configuration.GetConnectionString("default");
            builder.UseSqlServer(connString);
            return new MusicContext(builder.Options);

        }
    }
}
