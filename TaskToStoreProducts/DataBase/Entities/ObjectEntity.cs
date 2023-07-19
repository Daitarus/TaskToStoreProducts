using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskToStoreProducts.DataBase.Entities
{
    [Table("Objects")]
    internal class ObjectEntity : Entity
    {
        [Column("type")]
        [MaxLength(50)]
        [Required]
        public string Type { get; set; }

        [Column("product")]
        [MaxLength(50)]
        [Required]
        public string Product { get; set; }

        public ObjectEntity(string type, string product)
        {
            Type = type;
            Product = product;
        }
    }
}
