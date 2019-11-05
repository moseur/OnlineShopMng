using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopMngSys.Models
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product Type")]
        public string Name { get; set; }

    }
}
