using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskToStoreProducts.DataBase.Entities;

namespace TaskToStoreProducts.DataBase.Repositories
{
    internal class ObjectRepository : Repository<ObjectEntity>
    {
        private ProductDB productDB;
        public ObjectRepository(ProductDB dataBase) : base(dataBase) 
        {
            productDB = dataBase;
        }

        public override ObjectEntity? SelectForId(long id)
        {
            ObjectEntity? objectEntity = base.SelectForId(id);
            if(objectEntity != null)
            {
                AttributeRepository attributeRepository = new AttributeRepository(productDB);
                objectEntity.AttributeEntities = attributeRepository.SelectForObjectId(objectEntity.Id);

                ObjectRelationshipRepository objectRelationshipRepository = new ObjectRelationshipRepository(productDB);
                objectEntity.ParentObjectRelationshipEntities = objectRelationshipRepository.SelectForParentId(objectEntity.Id);
                objectEntity.ChildObjectRelationshipEntities = objectRelationshipRepository.SelectForChildId(objectEntity.Id);

                ICollection<long> childIds = SelectChildIds(objectEntity.ParentObjectRelationshipEntities);
                objectEntity.ChildObjectEntities = SelectForIds(childIds);
            }
            return objectEntity;
        }
        public ICollection<ObjectEntity> SelectForIds(ICollection<long> ids)
        {
            ICollection<ObjectEntity> objectEntities = new List<ObjectEntity>();
            foreach (long id in ids)
            {
                ObjectEntity? objectEntity = SelectForId(id);
                if( objectEntity != null )
                    objectEntities.Add(objectEntity);
            }
            return objectEntities;
        }
        private ICollection<long> SelectChildIds(ICollection<ObjectRelationshipEntity> objectRelationshipEntities)
        {
            ICollection<long> childIds = new List<long>();
            foreach(var objectRelationshipEntity in objectRelationshipEntities)
            {
                childIds.Add(objectRelationshipEntity.ChildId);
            }
            return childIds;
        }
        public ICollection<ObjectEntity> SelectWithoutParents()
        {
            ObjectRelationshipRepository objectRelationshipRepository = new ObjectRelationshipRepository(productDB);
            ICollection<ObjectRelationshipEntity> allObjectRelationshipEntities = objectRelationshipRepository.SelectAll().ToList();
            ICollection<ObjectEntity> objectEntities = new List<ObjectEntity>();
            List<long> allIds = SelectParentIdWhenNeverBeChildId(allObjectRelationshipEntities);
            foreach(long id in allIds)
            {
                objectEntities.Add(SelectForId(id));
            }
            return objectEntities;
        }

        private List<long> SelectParentIdWhenNeverBeChildId(ICollection<ObjectRelationshipEntity> allObjectRelationshipEntities)
        {
            List<long> parentIds = new List<long>();
            foreach (var objectRelationshipEntity in allObjectRelationshipEntities)
            {
                if(!IsParentIdChildId(objectRelationshipEntity.ParentId, allObjectRelationshipEntities))
                    parentIds.Add(objectRelationshipEntity.ParentId);
            }
            return parentIds;
        }
        private bool IsParentIdChildId(long parentId, ICollection<ObjectRelationshipEntity> objectRelationshipEntities)
        {
            bool result = false;
            foreach(var objectRelationshipEntity in objectRelationshipEntities)
            {
                if(parentId == objectRelationshipEntity.ChildId)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
