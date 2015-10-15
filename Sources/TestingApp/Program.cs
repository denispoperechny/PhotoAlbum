using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoAlbum.Library.DAL.Context;

namespace TestingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var db = new PhotoLibraryContext())
            //{
                var db = new PhotoLibraryContext();
                db.Tags.ToList();
            //}
        }
    }
}
