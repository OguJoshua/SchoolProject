using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToyStore_UI.Models
{
    public class Toy
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? YearOfProduction { get; set; }
        [Required]
        public string ModelNumber { get; set; }
        [StringLength(150)]
        public string Summary { get; set; }
        public string Image { get; set; }
        public decimal? Price { get; set; }
        [Required]
        public int? SellerId { get; set; }
        public virtual Seller Seller { get; set; }
    }
}
