using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskToStoreProducts.DataBase.Entities;
using TaskToStoreProducts.DataBase.Repositories;

namespace TaskToStoreProducts.DataBaseBehavior
{
    internal class AddBehavior
    {
        private DbBehavior dbBehavior;

        public AddBehavior (DbBehavior dbBehavior)
        {
            this.dbBehavior = dbBehavior;
        }

        public bool TryAddObjectEntity(string type, string product)
        {
            if (!dbBehavior.IsArgumentNullOrEmptyWithPrintError(type, product) && !dbBehavior.IsDataBaseNullWithPrintError())
            {
                ObjectEntity objectEntity = new ObjectEntity() { Type = type, Product = product };
                ObjectRepository objectRepository = new ObjectRepository(dbBehavior.database);
                objectRepository.Add(objectEntity);
                return dbBehavior.TrySaveChangeIntoDB(objectRepository);
            }
            else
                return false;
        }
        public bool TryAddAttributeEntity(string objectIdStr, string name, string value)
        {
            long objectId;
            if(!dbBehavior.IsArgumentNullOrEmptyWithPrintError(objectIdStr, name, value) 
                && dbBehavior.TryParseToId(objectIdStr, out objectId)
                && !dbBehavior.IsDataBaseNullWithPrintError())
            {
                AttributeEntity attributeEntity = new AttributeEntity() { ObjectId = objectId, Name = name, Value = value };
                AttributeRepository attributeRepository = new AttributeRepository(dbBehavior.database);
                attributeRepository.Add(attributeEntity);
                return dbBehavior.TrySaveChangeIntoDB(attributeRepository);
            }
            else
                return false;
        }
        public bool TryAddObjectRelationshipEntity(string parentIdStr, string childIdStr, string linkName)
        {
            long parentId, childId;
            if (!dbBehavior.IsArgumentNullOrEmptyWithPrintError(parentIdStr, childIdStr, linkName)
                && dbBehavior.TryParseToId(parentIdStr, out parentId)
                && dbBehavior.TryParseToId(childIdStr, out childId)
                && !dbBehavior.IsDataBaseNullWithPrintError())
            {
                ObjectRelationshipEntity objectRelationshipEntity = new ObjectRelationshipEntity()
                { ParentId = parentId, ChildId = childId, LinkName = linkName };
                ObjectRelationshipRepository objectRelationshipRepository = new ObjectRelationshipRepository(dbBehavior.database);
                objectRelationshipRepository.Add(objectRelationshipEntity);
                return dbBehavior.TrySaveChangeIntoDB(objectRelationshipRepository);
            }
            else
                return false;
        }
    }
}
