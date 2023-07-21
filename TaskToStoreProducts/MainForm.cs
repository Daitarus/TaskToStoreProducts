using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskToStoreProducts.DataBase;
using TaskToStoreProducts.DataBase.Entities;
using TaskToStoreProducts.DataBase.Repositories;
using TaskToStoreProducts.DataBaseBehavior;

namespace TaskToStoreFactoryProducts
{
    public partial class MainForm : Form
    {
        private DbBehavior dbBehavior;

        public MainForm()
        {
            InitializeComponent();
            dbBehavior = new DbBehavior(PrintSystemMessage);
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            dbBehavior.TryConnectDb();
        }

        private void PrintSystemMessage(string message)
        {
            StringBuilder messageBuilder = new StringBuilder();
            if (!String.IsNullOrEmpty(systemMessageTextBox.Text))
            {
                messageBuilder.Append(systemMessageTextBox.Text);
                messageBuilder.Append("\r\n");
            }
            messageBuilder.Append("-> ");
            messageBuilder.Append(message);
            systemMessageTextBox.Text = messageBuilder.ToString();
        }

        private void MainForm_FromClosing(object sender, FormClosingEventArgs e)
        {
            dbBehavior.DisposeDataBase();
        }

        private void OutputDataButton_Click(object sender, EventArgs e)
        {
            SelectBehavior selectBehavior = new SelectBehavior(dbBehavior);
            ICollection<ObjectEntity> seniorObjectEntities;
            selectBehavior.TrySelectSeniorObjectEntities(out seniorObjectEntities);

            TreeNode[] treeNodes = selectBehavior.AddObjectEntitiesToTreeNodes(seniorObjectEntities);
            foreach (TreeNode node in treeNodes)
            {
                treeView1.Nodes.Add(node);
            }
        }

        private void AddEntityButton_Click(object sender, EventArgs e)
        {
            AddBehavior addBehavior = new AddBehavior(dbBehavior);
            switch (entitiesAddTabControl.SelectedIndex)
            {
                case 0:
                    {
                        addBehavior.TryAddObjectEntity(
                            typeObjectAddTextBox.Text,
                            productObjectAddTextBox.Text);
                        break;
                    }
                case 1:
                    {
                        addBehavior.TryAddAttributeEntity(
                            objectIdAttributeAddTextBox.Text,
                            nameAttributeAddTextBox.Text,
                            valueAttributeAddTextBox.Text);
                        break;
                    }
                case 2:
                    {
                        addBehavior.TryAddObjectRelationshipEntity(
                            parentIdObjectRelationshipAddTextBox.Text,
                            childIdObjectRelationshipAddTextBox.Text,
                            linkNameObjectRelationshipAddTextBox.Text);
                        break;
                    }
            }
        }

        private void UpdateEntityButton_Click(object sender, EventArgs e)
        {
            UpdateBehavior updateBehavior = new UpdateBehavior(dbBehavior);
            switch (entitiesUpdateTabControl.SelectedIndex)
            {
                case 0:
                    {
                        updateBehavior.TryUpdateObjectEntity(
                            idObjectUpdateTextBox.Text,
                            typeObjectUpdateTextBox.Text,
                            productObjectUpdateTextBox.Text);
                        break;
                    }
                case 1:
                    {
                        updateBehavior.TryUpdateAttributeEntity(
                            idAttributeUpdateTextBox.Text,
                            objectIdAttributeUpdateTextBox.Text,
                            nameAttributeUpdateTextBox.Text,
                            valueAttributeUpdateTextBox.Text);
                        break;
                    }
                case 2:
                    {
                        updateBehavior.TryUpdateObjectRelationshipEntity(
                            idObjectRelationshipUpdateTextBox.Text,
                            parentIdObjectRelationshipUpdateTextBox.Text,
                            childIdObjectRelationshipUpdateTextBox.Text,
                            linkNameObjectRelationshipUpdateTextBox.Text);
                        break;
                    }
            }
        }

        private void DeleteEntityButton_Click(object sender, EventArgs e)
        {
            DeleteBehavior deleteBehavior = new DeleteBehavior(dbBehavior);
            switch (entitiesDeleteTabControl.SelectedIndex)
            {
                case 0:
                    {
                        deleteBehavior.TryDeleteObjectEntity(idObjectDeleteTextBox.Text);
                        break;
                    }
                case 1:
                    {
                        deleteBehavior.TryDeleteAttributeEntity(idAttributeDeleteTextBox.Text);
                        break;
                    }
                case 2:
                    {
                        deleteBehavior.TryDeleteObjectRelationshipEntity(idObjectRelationshipDeleteTextBox.Text);
                        break;
                    }
            }
        }

        private void reconnectToDatabaseButton_Click(object sender, EventArgs e)
        {
            dbBehavior.DisposeDataBase();
            dbBehavior.TryConnectDb();
        }
    }
}