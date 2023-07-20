using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskToStoreProducts.DataBase.Entities;
using TaskToStoreProducts.DataBase.Repositories;

namespace TaskToStoreProducts.DataBaseBehavior
{
    internal class DeleteBehavior
    {
        private DbBehavior dbBehavior;

        public DeleteBehavior(DbBehavior dbBehavior)
        {
            this.dbBehavior = dbBehavior;
        }

        public bool TryDeleteObjectEntity(string idStr)
        {
            long id;
            if (dbBehavior.TryParseToId(idStr, out id)
                && !dbBehavior.IsDataBaseNullWithPrintError())
            {
                ObjectRepository objectRepository = new ObjectRepository(dbBehavior.database);
                ObjectEntity? objectEntity = objectRepository.SelectForId(id);
                if (!dbBehavior.IsEntityNullWithPrintError(objectEntity))
                {
                    if(TryDeleteAttributeEntitiesForObjectId(objectEntity.Id)
                        && TryDeleteObjectRelationshipEntitiesForParetnId(objectEntity.Id)
                        && TryDeleteObjectRelationshipEntitiesForChildId(objectEntity.Id))
                    objectRepository.Remove(objectEntity);
                    return dbBehavior.TrySaveChangeIntoDB(objectRepository);
                }
            }
            return false;
        }
        public bool TryDeleteAttributeEntity(string idStr)
        {
            long id;
            if (dbBehavior.TryParseToId(idStr, out id)
                && !dbBehavior.IsDataBaseNullWithPrintError())
            {
                AttributeRepository attributeRepository = new AttributeRepository(dbBehavior.database);
                AttributeEntity? attributeEntity = attributeRepository.SelectForId(id);
                if (!dbBehavior.IsEntityNullWithPrintError(attributeEntity))
                {
                    attributeRepository.Remove(attributeEntity);
                    return dbBehavior.TrySaveChangeIntoDB(attributeRepository);
                }
            }
            return false;
        }
        public bool TryDeleteObjectRelationshipEntity(string idStr)
        {
            long id;
            if (dbBehavior.TryParseToId(idStr, out id)
                && !dbBehavior.IsDataBaseNullWithPrintError())
            {
                ObjectRelationshipRepository objectRelationshipRepository = new ObjectRelationshipRepository(dbBehavior.database);
                ObjectRelationshipEntity? objectRelationshipEntity = objectRelationshipRepository.SelectForId(id);
                if (!dbBehavior.IsEntityNullWithPrintError(objectRelationshipEntity))
                {
                    objectRelationshipRepository.Remove(objectRelationshipEntity);
                    return dbBehavior.TrySaveChangeIntoDB(objectRelationshipRepository);
                }
            }
            return false;
        }

        private bool TryDeleteAttributeEntitiesForObjectId(long objectId)
        {
            AttributeRepository attributeRepository = new AttributeRepository(dbBehavior.database);
            ICollection<AttributeEntity> attributeEntities = attributeRepository.SelectForObjectId(objectId);
            foreach (AttributeEntity attributeEntity in attributeEntities)
            {
                attributeRepository.Remove(attributeEntity);
            }
            return dbBehavior.TrySaveChangeIntoDB(attributeRepository);
        }
        private bool TryDeleteObjectRelationshipEntitiesForParetnId(long parentId)
        {
            ObjectRelationshipRepository objectRelationshipRepository = new ObjectRelationshipRepository(dbBehavior.database);
            ICollection<ObjectRelationshipEntity> objectRelationshipEntities = objectRelationshipRepository.SelectForParentId(parentId);
            foreach(ObjectRelationshipEntity objectRelationshipEntity in objectRelationshipEntities)
            {
                objectRelationshipRepository.Remove(objectRelationshipEntity);
            }
            return dbBehavior.TrySaveChangeIntoDB(objectRelationshipRepository);
        }
        private bool TryDeleteObjectRelationshipEntitiesForChildId(long childId)
        {
            ObjectRelationshipRepository objectRelationshipRepository = new ObjectRelationshipRepository(dbBehavior.database);
            ICollection<ObjectRelationshipEntity> objectRelationshipEntities = objectRelationshipRepository.SelectForChildId(childId);
            foreach (ObjectRelationshipEntity objectRelationshipEntity in objectRelationshipEntities)
            {
                objectRelationshipRepository.Remove(objectRelationshipEntity);
            }
            return dbBehavior.TrySaveChangeIntoDB(objectRelationshipRepository);
        }
    }
}
