using RepositoryDB;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskToStoreProducts.DataBase.Entities
{
    [Table("Attributes")]
    internal class AttributeEntity : Entity
    {
        [Column("name")]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [Column("value")]
        [MaxLength(50)]
        [Required]
        public string Value { get; set; }

        public AttributeEntity(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}
