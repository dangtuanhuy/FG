using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationk.Models
{
    public class Products
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name can not null")]
        [Display(Name = "Product Name")]
        [MaxLength(70)]
        public string ProductName { get; set; }


        [Display(Name = "Product Details")]
        [Column(TypeName = "ntext")]
        public string ProductDetails { get; set; }

        [Display(Name = "Price")]
        [Range(1, int.MaxValue, ErrorMessage = "Price should be greater than ${1}")]
        public double Price { get; set; }
    }
}
