using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal RegularPrice { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal DiscountPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<Image> Images { get; set; }
        public DateTime DateUpdate { get; set; } = DateTime.Now;

        public Product()
        {
            Categories = new Collection<Category>();
            Images = new Collection<Image>();
        }


    }
}
