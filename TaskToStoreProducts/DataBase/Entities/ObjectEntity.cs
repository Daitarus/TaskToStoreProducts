using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        [MaxLength(50)]
        [Required]
        public string Type { get; set; }

        [MaxLength(50)]
        [Required]
        public string Product { get; set; }

        public ICollection<AttributeEntity> AttributeEntities { get; set; }

        public ICollection<ObjectRelationshipEntity> ParentObjectRelationshipEntities { get; set; }

        public ICollection<ObjectRelationshipEntity> ChildObjectRelationshipEntities { get; set; }
    }
}
