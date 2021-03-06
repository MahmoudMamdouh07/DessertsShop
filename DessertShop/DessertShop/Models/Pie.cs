﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DessertShop.Models
{
    public class Pie
    {
        [Key]
        public Guid PieId { get; set; }
        [StringLength(50)]
        public string PieName { get; set; }
        [NotMapped]
        public IFormFile PiePhotoName { get; set; }
        [StringLength(1000)]
        public string PiePhoto{ get; set; }
        [StringLength(50)]
        public string ShortDescreption { get; set; }
        [StringLength(1000)]
        public string LongDescreption { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
        public bool PiesOfTheWeek { get; set; }
    }
}
