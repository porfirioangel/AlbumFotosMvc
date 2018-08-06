using Microsoft.EntityFrameworkCore;
using Model;
using Model.Models;
using System;

namespace Service
{
    public class AlbumService : IAlbumService
    {
        private readonly AlbumDbContext context;

        public AlbumService(AlbumDbContext context)
        {
            this.context = context;
        }

        public bool Create(Album album)
        {
            try
            {
                album.CreatedAt = DateTime.Now;
                context.Entry(album).State = EntityState.Added;
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
