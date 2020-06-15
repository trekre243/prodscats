using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProdsCats.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        [MinLength(5)]
        public string Description { get; set; }

        [Required]
        [Range(0, System.Double.MaxValue)]
        public double Price { get; set; }

        public List<Association> Associations { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}