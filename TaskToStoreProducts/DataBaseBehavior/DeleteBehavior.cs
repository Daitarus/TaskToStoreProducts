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
                    if(TryDeleteAttributeEntities(objectEntity.AttributeEntities)
                        && TryDeleteObjectRelationshipEntities(objectEntity.ParentObjectRelationshipEntities)
                        && TryDeleteObjectRelationshipEntities(objectEntity.ChildObjectRelationshipEntities))
                    objectRepository.Delete(objectEntity);
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
                    attributeRepository.Delete(attributeEntity);
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
                    objectRelationshipRepository.Delete(objectRelationshipEntity);
                    return dbBehavior.TrySaveChangeIntoDB(objectRelationshipRepository);
                }
            }
            return false;
        }

        private bool TryDeleteAttributeEntities(ICollection<AttributeEntity> attributeEntities)
        {
            AttributeRepository attributeRepository = new AttributeRepository(dbBehavior.database);
            foreach (AttributeEntity attributeEntity in attributeEntities)
            {
                attributeRepository.Delete(attributeEntity);
            }
            return dbBehavior.TrySaveChangeIntoDB(attributeRepository);
        }
        private bool TryDeleteObjectRelationshipEntities(ICollection<ObjectRelationshipEntity> objectRelationshipEntities)
        {
            ObjectRelationshipRepository objectRelationshipRepository = new ObjectRelationshipRepository(dbBehavior.database);           
            foreach(ObjectRelationshipEntity objectRelationshipEntity in objectRelationshipEntities)
            {
                objectRelationshipRepository.Delete(objectRelationshipEntity);
            }
            return dbBehavior.TrySaveChangeIntoDB(objectRelationshipRepository);
        }
    }
}
