using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskToStoreProducts.DataBase.Entities;

namespace TaskToStoreProducts.DataBase.Repositories
{
    internal class ObjectRelationshipRepository : Repository<ObjectRelationshipEntity>
    {
        private ProductDB productDB;
        public ObjectRelationshipRepository(ProductDB database) : base(database) 
        { 
            this.productDB = database;
        }

        public ICollection<ObjectRelationshipEntity> SelectForParentId(long parentId)
        {
            IQueryable<ObjectRelationshipEntity> objectRelationshipEntities = productDB.ObjectRelationshipEntities.Where
                (objectRelationshipEntity => objectRelationshipEntity.ParentId.Equals(parentId));
            return objectRelationshipEntities.ToList();
        }
        public ICollection<ObjectRelationshipEntity> SelectForChildId(long childId)
        {
            IQueryable<ObjectRelationshipEntity> objectRelationshipEntities = productDB.ObjectRelationshipEntities.Where
                (objectRelationshipEntity => objectRelationshipEntity.ChildId.Equals(childId));
            return objectRelationshipEntities.ToList();
        }
    }
}
