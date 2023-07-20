using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskToStoreProducts.DataBase.Entities;

namespace TaskToStoreProducts.DataBase.Repositories
{
    internal class AttributeRepository : Repository<AttributeEntity>
    {
        private ProductDB productDB;
        public AttributeRepository(ProductDB dataBase) : base(dataBase) 
        {
            productDB = dataBase;
        }

        public ICollection<AttributeEntity> SelectForObjectId(long objectId)
        {
            IQueryable<AttributeEntity> attributeEntities = productDB.AttributeEntities.Where
                (attributeEntity => attributeEntity.ObjectId.Equals(objectId));
            return attributeEntities.ToList();
        }
    }
}
