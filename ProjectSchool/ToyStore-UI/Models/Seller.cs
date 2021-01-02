using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToyStore_UI.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]

        public string FirstName { get; set; }
        [Required]
        [DisplayName("Second Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Profile")]
        [StringLength(250)]
        public string Profile { get; set; }

        public virtual IList<Toy> Toys { get; set; }


    }
}
