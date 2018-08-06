using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface IAlbumService
    {
        bool Create(Album album);
    }
}
