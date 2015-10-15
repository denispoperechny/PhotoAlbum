using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoLibrary.Common;

namespace PhotoAlbum.Library
{
    public class PhotoLibrary
    {
        private readonly string _photoStorageRootPath;

        public PhotoLibrary(string photoStorageRootPath)
        {
            if (photoStorageRootPath == null)
                throw new ArgumentNullException("photoStorageRootPath");

            _photoStorageRootPath = photoStorageRootPath;
            State = LibraryState.Unknown;
        }

        public LibraryState State { get; private set; }

        public ICollection<PhotoId> GetFullPhotoCollection()
        {
            throw new NotImplementedException();
        }

        public ICollection<PhotoId> GetPhotosByTag(params PhotoTag [] tags)
        {
            throw new NotImplementedException();
        }

        public ICollection<PhotoTag> GetAllTags()
        {
            throw new NotImplementedException();
        }

        public void AddTag(PhotoTag newTag)
        {
            throw new NotImplementedException();
        }

        public void RemoveTag(PhotoTag tag)
        {
            throw new NotImplementedException();
        }
    }
}
