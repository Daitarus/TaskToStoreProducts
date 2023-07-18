using RepositoryDB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskToStoreProducts.DataBase.Entities
{
    [Table("ObjectAttributeRelationships")]
    internal class ObjectAttributeRelationship : Entity
    {
        [Column("idparent")]
        [Required]
        public int IdParant { get; set; }

        [Column("idchild")]
        [Required]
        public int IdChild { get; set; }

        [Column("linkname")]
        [MaxLength(100)]
        [Required]
        public string LinkName { get; set; }

        public ObjectAttributeRelationship(int idParant, int idChild, string linkName)
        {
            IdParant = idParant;
            IdChild = idChild;
            LinkName = linkName;
        }
    }
}
