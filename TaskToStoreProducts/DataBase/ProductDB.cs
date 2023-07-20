using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskToStoreProducts.DataBase.Entities;

namespace TaskToStoreProducts.DataBase
{
    internal class ProductDB : DB
    {
        public DbSet<ObjectEntity> ObjectEntity { get; set; }
        public DbSet<AttributeEntity> AttributeEntity { get; set; }
        public DbSet<ObjectRelationshipEntity> ObjectRelationshipEntity { get; set; }
        public ProductDB(string connectionString) : base(connectionString) { }
    }
}
