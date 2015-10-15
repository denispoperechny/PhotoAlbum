using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbum.Library.DAL.Models
{
    public class PhotoFile
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Id")]
        public PhotoFileId PhotoFileId { get; set; }

        [Required]
        public string Path { get; set; }

        public List<Tag> Tags { get; set; }
    }
}
