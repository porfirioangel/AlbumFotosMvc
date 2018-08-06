using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;

namespace Model
{
    public class AlbumDbContext: DbContext
    {
        public AlbumDbContext(DbContextOptions<AlbumDbContext> options): base(options)
        {

        }

        public DbSet<Album> Album { get; set; }
    }
}
