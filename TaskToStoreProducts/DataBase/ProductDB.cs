using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskToStoreProducts.DataBase.Entities;
using TaskToStoreProducts.DataBase.Repositories;

namespace TaskToStoreProducts.DataBase
{
    internal class ProductDB : DB
    {
        public DbSet<ObjectEntity> ObjectEntities { get; set; }
        public DbSet<AttributeEntity> AttributeEntities { get; set; }
        public DbSet<ObjectRelationshipEntity> ObjectRelationshipEntities { get; set; }
        public ProductDB(string connectionString) : base(connectionString) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ObjectRelationshipEntity>()
                .HasOne(x => x.ParentObjectEntity)
                .WithMany(z => z.ParentObjectRelationshipEntities)
                .HasForeignKey(x => x.ParentId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<ObjectRelationshipEntity>()
                .HasOne(x => x.ChildObjectEntity)
                .WithMany(z => z.ChildObjectRelationshipEntities)
                .HasForeignKey(x => x.ChildId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
