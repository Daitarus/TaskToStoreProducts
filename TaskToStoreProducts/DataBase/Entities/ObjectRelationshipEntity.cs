using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskToStoreProducts.DataBase.Entities
{
    [Table("ObjectRelationships")]
    internal class ObjectRelationshipEntity : Entity
    {
        [ForeignKey("ParentObjectEntity")]
        [Required]
        public long ParentId { get; set; }
        public ObjectEntity ParentObjectEntity { get; set; }

        [ForeignKey("ChildObjectEntity")]
        [Required]
        public long ChildId { get; set; }
        public ObjectEntity ChildObjectEntity { get; set; }

        [MaxLength(100)]
        [Required]
        public string LinkName { get; set; }
    }
}
