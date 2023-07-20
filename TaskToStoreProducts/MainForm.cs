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
            dbBehavior.Dispose();
        }

        private void OutputDataButton_Click(object sender, EventArgs e)
        {

        }

        private void AddEntityButton_Click(object sender, EventArgs e)
        {

        }
    }
}