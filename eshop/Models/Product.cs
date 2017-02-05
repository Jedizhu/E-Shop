using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace eshop.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [MaxLength(60, ErrorMessage = "The maximum length must be upto 60 characters only")]
        public string Name { get; set; }

        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Has to be decimal with two decimal points")]
        public Decimal Price { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        [Display(Name = "Updated At")]
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdated { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<OrderedProduct> OrderedProducts { get; set; }
    }
}