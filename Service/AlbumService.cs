using Microsoft.EntityFrameworkCore;
using Model;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<Album> GetAll()
        {
            var result = new List<Album>();

            try
            {
                result = context.Album.OrderByDescending(x => x.CreatedAt)
                    .ToList();
            }
            catch (Exception e)
            {
            }

            return result;
        }
    }
}
