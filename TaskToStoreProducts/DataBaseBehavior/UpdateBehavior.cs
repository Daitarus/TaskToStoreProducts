using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskToStoreProducts.DataBase.Entities;
using TaskToStoreProducts.DataBase.Repositories;

namespace TaskToStoreProducts.DataBaseBehavior
{
    internal class UpdateBehavior
    {
        private DbBehavior dbBehavior;

        public UpdateBehavior(DbBehavior dbBehavior)
        {
            this.dbBehavior = dbBehavior;
        }

        public bool TryUpdateObjectEntity(string idStr, string type, string product)
        {
            long id;
            if (dbBehavior.TryParseToId(idStr, out id))
            {
                ObjectRepository objectRepository = new ObjectRepository(dbBehavior.database);
                ObjectEntity? objectEntity = objectRepository.SelectForId(id);
                if(!dbBehavior.IsEntityNullWithPrintError(objectEntity))
                {
                    if (!String.IsNullOrEmpty(type))
                        objectEntity.Type = type;
                    if (!String.IsNullOrEmpty(product))
                        objectEntity.Product = product;
                    return dbBehavior.TrySaveChangeIntoDB(objectRepository);
                }
            }

            return false;
        }
        public bool TryUpdateAttributeEntity(string idStr, string objectIdStr, string name, string value)
        {
            long id;
            if (dbBehavior.TryParseToId(idStr, out id))
            {
                AttributeRepository attributeRepository = new AttributeRepository(dbBehavior.database);
                AttributeEntity? attributeEntity = attributeRepository.SelectForId(id);
                if (!dbBehavior.IsEntityNullWithPrintError(attributeEntity))
                {
                    long objectId;
                    if (long.TryParse(objectIdStr, out objectId))
                        attributeEntity.ObjectId = objectId;
                    if (!String.IsNullOrEmpty(name))
                        attributeEntity.Name = name;
                    if (!String.IsNullOrEmpty(value))
                        attributeEntity.Value = value;
                    return dbBehavior.TrySaveChangeIntoDB(attributeRepository);
                }
            }
            return false;
        }
        public bool TryUpdateObjectRelationshipEntity(string idStr, string parentIdStr, string childIdStr, string linkName)
        {
            long id;
            if (dbBehavior.TryParseToId(idStr, out id))
            {
                ObjectRelationshipRepository objectRelationshipRepository = new ObjectRelationshipRepository(dbBehavior.database);
                ObjectRelationshipEntity? objectRelationshipEntity = objectRelationshipRepository.SelectForId(id);
                if (!dbBehavior.IsEntityNullWithPrintError(objectRelationshipEntity))
                {
                    long parentId, childId;
                    if (long.TryParse(parentIdStr, out parentId) 
                        && !dbBehavior.IsIdsEqualWithPrintError(parentId, objectRelationshipEntity.ChildId))
                        objectRelationshipEntity.ParentId = parentId;
                    if (long.TryParse(childIdStr, out childId)
                        && !dbBehavior.IsIdsEqualWithPrintError(childId, objectRelationshipEntity.ParentId))
                        objectRelationshipEntity.ChildId = childId;
                    if (!String.IsNullOrEmpty(linkName))
                        objectRelationshipEntity.LinkName = linkName;
                    return dbBehavior.TrySaveChangeIntoDB(objectRelationshipRepository);
                }
            }
            return false;
        }
    }
}
