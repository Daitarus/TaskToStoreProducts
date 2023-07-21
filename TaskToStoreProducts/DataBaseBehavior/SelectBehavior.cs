using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskToStoreProducts.DataBase.Entities;
using TaskToStoreProducts.DataBase.Repositories;

namespace TaskToStoreProducts.DataBaseBehavior
{
    internal class SelectBehavior
    {
        public DbBehavior dbBehavior;
        public SelectBehavior(DbBehavior dbBehavior)
        {
            this.dbBehavior = dbBehavior;
        }

        public TreeNode[] AddObjectEntitiesToTreeNodes(ICollection<ObjectEntity> objectEntities)
        {
            ObjectEntity[] arrayObjectEntities = objectEntities.ToArray();
            TreeNode[] treeNodes = new TreeNode[objectEntities.Count];
            for(int i=0;i<objectEntities.Count;i++)
            {
                treeNodes[i] = AddObjectEntityToTreeNode(arrayObjectEntities[i]);
            }
            return treeNodes;
        }
        public TreeNode AddObjectEntityToTreeNode(ObjectEntity objectEntity)
        {
            TreeNode resultTreeNode = new TreeNode(ConvertObjectEntityToStringForTreeNode(objectEntity));
            if (objectEntity.ChildObjectEntities.Count > 0)
                resultTreeNode.Nodes.AddRange(AddObjectEntitiesToTreeNodes(objectEntity.ChildObjectEntities));
            return resultTreeNode;
        }

        private string ConvertObjectEntityToStringForTreeNode(ObjectEntity objectEntity)
        {
            StringBuilder resultStringBuilder = new StringBuilder();
            resultStringBuilder.Append(
                ConvertArrayStringToStringBuilder(new String[] { nameof(objectEntity.Id) , ": ", objectEntity.Id.ToString(), " " }));
            resultStringBuilder.Append(
                ConvertArrayStringToStringBuilder(new String[] { objectEntity.Type, " - ", objectEntity.Product, " " }));

            resultStringBuilder.Append("(");
            int counter = 0;
            foreach(var attributeEntity in objectEntity.AttributeEntities)
            {
                resultStringBuilder.Append(
                    ConvertArrayStringToStringBuilder(new String[] {attributeEntity.Name, ": ", attributeEntity.Value}));
                if (counter < objectEntity.AttributeEntities.Count - 1)
                    resultStringBuilder.Append(", ");
                counter++;
            }
            resultStringBuilder.Append(")");
            
            return resultStringBuilder.ToString();
        }
        private StringBuilder ConvertArrayStringToStringBuilder(string[] arrayString)
        {
            StringBuilder resultStringBuilder = new StringBuilder();
            for(int i=0; i<arrayString.Length; i++)
            {
                resultStringBuilder.Append(arrayString[i]);
            }
            return resultStringBuilder;
        }

        public bool TrySelectSeniorObjectEntities(out ICollection<ObjectEntity> seniorObjectEntities)
        {
            seniorObjectEntities = new List<ObjectEntity>();
            if (!dbBehavior.IsDataBaseNullWithPrintError())
            {
                ObjectRepository objectRepository = new ObjectRepository(dbBehavior.database);                
                seniorObjectEntities = objectRepository.SelectWithoutParents();
                return true;
            }
            else
                return false;
        }
    }
}
