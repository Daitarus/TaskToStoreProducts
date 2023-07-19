namespace TaskToStoreFactoryProducts
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView1 = new TreeView();
            dbFunctionTabControl = new TabControl();
            addTabPage = new TabPage();
            AddEntityButton = new Button();
            updateTabPage = new TabPage();
            UpdateEntityButton = new Button();
            deleteTabPage = new TabPage();
            DeleteEntityButton = new Button();
            OutputDataButton = new Button();
            label1 = new Label();
            XMLConvertButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            entitiesAddTabControl = new TabControl();
            objectTabPage = new TabPage();
            attributeTabPage = new TabPage();
            relationshipTabPage = new TabPage();
            dbFunctionTabControl.SuspendLayout();
            addTabPage.SuspendLayout();
            updateTabPage.SuspendLayout();
            deleteTabPage.SuspendLayout();
            entitiesAddTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 37);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(555, 614);
            treeView1.TabIndex = 0;
            // 
            // dbFunctionTabControl
            // 
            dbFunctionTabControl.Controls.Add(addTabPage);
            dbFunctionTabControl.Controls.Add(updateTabPage);
            dbFunctionTabControl.Controls.Add(deleteTabPage);
            dbFunctionTabControl.Location = new Point(582, 13);
            dbFunctionTabControl.Name = "dbFunctionTabControl";
            dbFunctionTabControl.SelectedIndex = 0;
            dbFunctionTabControl.Size = new Size(512, 678);
            dbFunctionTabControl.TabIndex = 1;
            // 
            // addTabPage
            // 
            addTabPage.Controls.Add(entitiesAddTabControl);
            addTabPage.Controls.Add(label2);
            addTabPage.Controls.Add(AddEntityButton);
            addTabPage.Location = new Point(4, 24);
            addTabPage.Name = "addTabPage";
            addTabPage.Padding = new Padding(3);
            addTabPage.Size = new Size(504, 650);
            addTabPage.TabIndex = 0;
            addTabPage.Text = "Добавить данные";
            addTabPage.UseVisualStyleBackColor = true;
            // 
            // AddEntityButton
            // 
            AddEntityButton.Location = new Point(6, 613);
            AddEntityButton.Name = "AddEntityButton";
            AddEntityButton.Size = new Size(492, 31);
            AddEntityButton.TabIndex = 0;
            AddEntityButton.Text = "Добавить";
            AddEntityButton.UseVisualStyleBackColor = true;
            // 
            // updateTabPage
            // 
            updateTabPage.Controls.Add(label3);
            updateTabPage.Controls.Add(UpdateEntityButton);
            updateTabPage.Location = new Point(4, 24);
            updateTabPage.Name = "updateTabPage";
            updateTabPage.Size = new Size(504, 650);
            updateTabPage.TabIndex = 2;
            updateTabPage.Text = "Обновить данные";
            updateTabPage.UseVisualStyleBackColor = true;
            // 
            // UpdateEntityButton
            // 
            UpdateEntityButton.Location = new Point(6, 613);
            UpdateEntityButton.Name = "UpdateEntityButton";
            UpdateEntityButton.Size = new Size(492, 31);
            UpdateEntityButton.TabIndex = 1;
            UpdateEntityButton.Text = "Обновить";
            UpdateEntityButton.UseVisualStyleBackColor = true;
            // 
            // deleteTabPage
            // 
            deleteTabPage.Controls.Add(label4);
            deleteTabPage.Controls.Add(DeleteEntityButton);
            deleteTabPage.Location = new Point(4, 24);
            deleteTabPage.Name = "deleteTabPage";
            deleteTabPage.Padding = new Padding(3);
            deleteTabPage.Size = new Size(504, 650);
            deleteTabPage.TabIndex = 1;
            deleteTabPage.Text = "Удалить данные";
            deleteTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteEntityButton
            // 
            DeleteEntityButton.Location = new Point(6, 613);
            DeleteEntityButton.Name = "DeleteEntityButton";
            DeleteEntityButton.Size = new Size(492, 31);
            DeleteEntityButton.TabIndex = 2;
            DeleteEntityButton.Text = "Удалить";
            DeleteEntityButton.UseVisualStyleBackColor = true;
            // 
            // OutputDataButton
            // 
            OutputDataButton.Location = new Point(12, 657);
            OutputDataButton.Name = "OutputDataButton";
            OutputDataButton.Size = new Size(275, 30);
            OutputDataButton.TabIndex = 2;
            OutputDataButton.Text = "Получить данные";
            OutputDataButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(555, 23);
            label1.TabIndex = 3;
            label1.Text = "Просмотр дерева объектов";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // XMLConvertButton
            // 
            XMLConvertButton.Location = new Point(293, 657);
            XMLConvertButton.Name = "XMLConvertButton";
            XMLConvertButton.Size = new Size(275, 30);
            XMLConvertButton.TabIndex = 4;
            XMLConvertButton.Text = "Выгрузить в XML";
            XMLConvertButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 3);
            label2.Name = "label2";
            label2.Size = new Size(492, 23);
            label2.TabIndex = 1;
            label2.Text = "Заполните поля нужных сущностей";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 3);
            label3.Name = "label3";
            label3.Size = new Size(492, 23);
            label3.TabIndex = 2;
            label3.Text = "Заполните поля нужных сущностей";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 3);
            label4.Name = "label4";
            label4.Size = new Size(492, 23);
            label4.TabIndex = 3;
            label4.Text = "Заполните поля нужных сущностей";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // entitiesAddTabControl
            // 
            entitiesAddTabControl.Controls.Add(objectTabPage);
            entitiesAddTabControl.Controls.Add(attributeTabPage);
            entitiesAddTabControl.Controls.Add(relationshipTabPage);
            entitiesAddTabControl.Location = new Point(6, 29);
            entitiesAddTabControl.Name = "entitiesAddTabControl";
            entitiesAddTabControl.SelectedIndex = 0;
            entitiesAddTabControl.Size = new Size(492, 477);
            entitiesAddTabControl.TabIndex = 2;
            // 
            // objectTabPage
            // 
            objectTabPage.Location = new Point(4, 24);
            objectTabPage.Name = "objectTabPage";
            objectTabPage.Padding = new Padding(3);
            objectTabPage.Size = new Size(484, 449);
            objectTabPage.TabIndex = 0;
            objectTabPage.Text = "Объект";
            objectTabPage.UseVisualStyleBackColor = true;
            // 
            // attributeTabPage
            // 
            attributeTabPage.Location = new Point(4, 24);
            attributeTabPage.Name = "attributeTabPage";
            attributeTabPage.Padding = new Padding(3);
            attributeTabPage.Size = new Size(484, 449);
            attributeTabPage.TabIndex = 1;
            attributeTabPage.Text = "Атрибут";
            attributeTabPage.UseVisualStyleBackColor = true;
            // 
            // relationshipTabPage
            // 
            relationshipTabPage.Location = new Point(4, 24);
            relationshipTabPage.Name = "relationshipTabPage";
            relationshipTabPage.Size = new Size(484, 449);
            relationshipTabPage.TabIndex = 2;
            relationshipTabPage.Text = "Свзяь объектов";
            relationshipTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 703);
            Controls.Add(XMLConvertButton);
            Controls.Add(label1);
            Controls.Add(OutputDataButton);
            Controls.Add(dbFunctionTabControl);
            Controls.Add(treeView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "MainForm";
            dbFunctionTabControl.ResumeLayout(false);
            addTabPage.ResumeLayout(false);
            updateTabPage.ResumeLayout(false);
            deleteTabPage.ResumeLayout(false);
            entitiesAddTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private TabControl dbFunctionTabControl;
        private TabPage addTabPage;
        private TabPage deleteTabPage;
        private Button OutputDataButton;
        private Label label1;
        private Button AddEntityButton;
        private TabPage updateTabPage;
        private Button UpdateEntityButton;
        private Button DeleteEntityButton;
        private Button XMLConvertButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private TabControl entitiesAddTabControl;
        private TabPage objectTabPage;
        private TabPage attributeTabPage;
        private TabPage relationshipTabPage;
    }
}