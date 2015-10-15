using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoAlbum.Library.DAL.Models;

namespace PhotoAlbum.Library.DAL.Context
{
    public class PhotoLibraryContext : DbContext
    {
        public DbSet<LibraryStatus> LibraryStatus { get; set; }
        //public DbSet<LibraryStatuses> LibraryStatuses { get; set; } // TODO: Enum ?
        public DbSet<PhotoFile> PhotoFiles { get; set; }
        public DbSet<PhotoFileId> PhotoFileIds { get; set; }
        public DbSet<Tag> Tags { get; set; }
    } 
}
