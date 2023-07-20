using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TaskToStoreProducts.DataBase.Entities
{
    [Table("Attributes")]
    internal class AttributeEntity : Entity
    {
        [ForeignKey("OwningObjectEntity")]
        [Required]
        public long ObjectId;
        public ObjectEntity OwningObjectEntity { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string Value { get; set; }
    }
}
