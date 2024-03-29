﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogFall.Models
{
    [Table("Categories")]
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Kategori Adı")]
        public string CategoryName { get; set; }

        [StringLength(200)]
        [Display(Name = "Url")]
        public string Slug { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}