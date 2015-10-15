using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoLibrary.Common
{
    public struct PhotoTag : IComparable<PhotoTag>
    {
        public string Name { get; set; }

        public int CompareTo(PhotoTag other)
        {
            throw new NotImplementedException();
        }
    }
}
