using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_example.Models
{
    internal class Category
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
    internal class Product
    {
        [Key] //unnecessary in this case because Id is automatically a key attridbute
        public int Id { get; set; } //must exist in any db

        public string? Description { get; set; } = null; //property is declared as nullable

        [Column(TypeName = "decimal(6, 2)")] //this shows what is wanted for the following attribute
        public decimal Price { get; set; }

        [Range(2020, 2030)]
        public decimal ReleaseYear { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }
    }
}
