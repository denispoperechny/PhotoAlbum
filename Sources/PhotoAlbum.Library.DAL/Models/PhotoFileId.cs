﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbum.Library.DAL.Models
{
    public class PhotoFileId
    {
        [Column(Order = 0), Required]
        public Guid Id { get; set; }

        [Column(Order = 1), Key]
        public int Length { get; set; }

        [Column(Order = 2), Key]
        public string Name { get; set; }
    }
}
