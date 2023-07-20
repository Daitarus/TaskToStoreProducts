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
            entitiesAddTabControl = new TabControl();
            objectTabPage = new TabPage();
            productObjectTextBox = new TextBox();
            typeObjectTextBox = new TextBox();
            ProductObjectLabel = new Label();
            TypeObjectLabel = new Label();
            attributeTabPage = new TabPage();
            objectIdAttributeTextBox = new TextBox();
            ObjectIdAttributeLabel = new Label();
            valueAttributeTextBox = new TextBox();
            nameAttributeTextBox = new TextBox();
            ValueAttributeLabel = new Label();
            NameAttributeLabel = new Label();
            relationshipTabPage = new TabPage();
            parentIdObjectRelationshipTextBox = new TextBox();
            parentIdObjectRelationshipLabel = new Label();
            linkNameObjectRelationshipTextBox = new TextBox();
            childIdObjectRelationshipTextBox = new TextBox();
            linkNameObjectRelationshipLabel = new Label();
            childIdObjectRelationshipLabel = new Label();
            label2 = new Label();
            AddEntityButton = new Button();
            updateTabPage = new TabPage();
            entityUpdateTabControl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            label3 = new Label();
            UpdateEntityButton = new Button();
            deleteTabPage = new TabPage();
            entityDeleteTabControl = new TabControl();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            label4 = new Label();
            DeleteEntityButton = new Button();
            OutputDataButton = new Button();
            label1 = new Label();
            XMLConvertButton = new Button();
            systemMessageTextBox = new TextBox();
            addAtteintionLabel = new Label();
            dbFunctionTabControl.SuspendLayout();
            addTabPage.SuspendLayout();
            entitiesAddTabControl.SuspendLayout();
            objectTabPage.SuspendLayout();
            attributeTabPage.SuspendLayout();
            relationshipTabPage.SuspendLayout();
            updateTabPage.SuspendLayout();
            entityUpdateTabControl.SuspendLayout();
            deleteTabPage.SuspendLayout();
            entityDeleteTabControl.SuspendLayout();
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
            dbFunctionTabControl.Size = new Size(587, 580);
            dbFunctionTabControl.TabIndex = 1;
            // 
            // addTabPage
            // 
            addTabPage.Controls.Add(addAtteintionLabel);
            addTabPage.Controls.Add(entitiesAddTabControl);
            addTabPage.Controls.Add(label2);
            addTabPage.Controls.Add(AddEntityButton);
            addTabPage.Location = new Point(4, 24);
            addTabPage.Name = "addTabPage";
            addTabPage.Padding = new Padding(3);
            addTabPage.Size = new Size(579, 552);
            addTabPage.TabIndex = 0;
            addTabPage.Text = "Добавить данные";
            addTabPage.UseVisualStyleBackColor = true;
            // 
            // entitiesAddTabControl
            // 
            entitiesAddTabControl.Controls.Add(objectTabPage);
            entitiesAddTabControl.Controls.Add(attributeTabPage);
            entitiesAddTabControl.Controls.Add(relationshipTabPage);
            entitiesAddTabControl.Location = new Point(6, 29);
            entitiesAddTabControl.Name = "entitiesAddTabControl";
            entitiesAddTabControl.SelectedIndex = 0;
            entitiesAddTabControl.Size = new Size(567, 431);
            entitiesAddTabControl.TabIndex = 2;
            // 
            // objectTabPage
            // 
            objectTabPage.Controls.Add(productObjectTextBox);
            objectTabPage.Controls.Add(typeObjectTextBox);
            objectTabPage.Controls.Add(ProductObjectLabel);
            objectTabPage.Controls.Add(TypeObjectLabel);
            objectTabPage.Location = new Point(4, 24);
            objectTabPage.Name = "objectTabPage";
            objectTabPage.Padding = new Padding(3);
            objectTabPage.Size = new Size(484, 449);
            objectTabPage.TabIndex = 0;
            objectTabPage.Text = "Объект";
            objectTabPage.UseVisualStyleBackColor = true;
            // 
            // productObjectTextBox
            // 
            productObjectTextBox.Location = new Point(6, 110);
            productObjectTextBox.MaxLength = 50;
            productObjectTextBox.Name = "productObjectTextBox";
            productObjectTextBox.Size = new Size(472, 23);
            productObjectTextBox.TabIndex = 3;
            // 
            // typeObjectTextBox
            // 
            typeObjectTextBox.Location = new Point(6, 44);
            typeObjectTextBox.MaxLength = 50;
            typeObjectTextBox.Name = "typeObjectTextBox";
            typeObjectTextBox.Size = new Size(472, 23);
            typeObjectTextBox.TabIndex = 2;
            // 
            // ProductObjectLabel
            // 
            ProductObjectLabel.AutoSize = true;
            ProductObjectLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ProductObjectLabel.Location = new Point(6, 87);
            ProductObjectLabel.Name = "ProductObjectLabel";
            ProductObjectLabel.Size = new Size(167, 20);
            ProductObjectLabel.TabIndex = 1;
            ProductObjectLabel.Text = "Обозначение объекта:";
            // 
            // TypeObjectLabel
            // 
            TypeObjectLabel.AutoSize = true;
            TypeObjectLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TypeObjectLabel.Location = new Point(6, 21);
            TypeObjectLabel.Name = "TypeObjectLabel";
            TypeObjectLabel.Size = new Size(98, 20);
            TypeObjectLabel.TabIndex = 0;
            TypeObjectLabel.Text = "Тип объекта:";
            // 
            // attributeTabPage
            // 
            attributeTabPage.Controls.Add(objectIdAttributeTextBox);
            attributeTabPage.Controls.Add(ObjectIdAttributeLabel);
            attributeTabPage.Controls.Add(valueAttributeTextBox);
            attributeTabPage.Controls.Add(nameAttributeTextBox);
            attributeTabPage.Controls.Add(ValueAttributeLabel);
            attributeTabPage.Controls.Add(NameAttributeLabel);
            attributeTabPage.Location = new Point(4, 24);
            attributeTabPage.Name = "attributeTabPage";
            attributeTabPage.Padding = new Padding(3);
            attributeTabPage.Size = new Size(559, 403);
            attributeTabPage.TabIndex = 1;
            attributeTabPage.Text = "Атрибут";
            attributeTabPage.UseVisualStyleBackColor = true;
            // 
            // objectIdAttributeTextBox
            // 
            objectIdAttributeTextBox.Location = new Point(6, 38);
            objectIdAttributeTextBox.MaxLength = 50;
            objectIdAttributeTextBox.Name = "objectIdAttributeTextBox";
            objectIdAttributeTextBox.Size = new Size(547, 23);
            objectIdAttributeTextBox.TabIndex = 9;
            // 
            // ObjectIdAttributeLabel
            // 
            ObjectIdAttributeLabel.AutoSize = true;
            ObjectIdAttributeLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ObjectIdAttributeLabel.Location = new Point(6, 15);
            ObjectIdAttributeLabel.Name = "ObjectIdAttributeLabel";
            ObjectIdAttributeLabel.Size = new Size(85, 20);
            ObjectIdAttributeLabel.TabIndex = 8;
            ObjectIdAttributeLabel.Text = "Id объекта:";
            // 
            // valueAttributeTextBox
            // 
            valueAttributeTextBox.Location = new Point(6, 169);
            valueAttributeTextBox.MaxLength = 50;
            valueAttributeTextBox.Name = "valueAttributeTextBox";
            valueAttributeTextBox.Size = new Size(547, 23);
            valueAttributeTextBox.TabIndex = 7;
            // 
            // nameAttributeTextBox
            // 
            nameAttributeTextBox.Location = new Point(6, 103);
            nameAttributeTextBox.MaxLength = 50;
            nameAttributeTextBox.Name = "nameAttributeTextBox";
            nameAttributeTextBox.Size = new Size(547, 23);
            nameAttributeTextBox.TabIndex = 6;
            // 
            // ValueAttributeLabel
            // 
            ValueAttributeLabel.AutoSize = true;
            ValueAttributeLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ValueAttributeLabel.Location = new Point(6, 146);
            ValueAttributeLabel.Name = "ValueAttributeLabel";
            ValueAttributeLabel.Size = new Size(145, 20);
            ValueAttributeLabel.TabIndex = 5;
            ValueAttributeLabel.Text = "Значение атрибута:";
            // 
            // NameAttributeLabel
            // 
            NameAttributeLabel.AutoSize = true;
            NameAttributeLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NameAttributeLabel.Location = new Point(6, 80);
            NameAttributeLabel.Name = "NameAttributeLabel";
            NameAttributeLabel.Size = new Size(108, 20);
            NameAttributeLabel.TabIndex = 4;
            NameAttributeLabel.Text = "Имя атрибута:";
            // 
            // relationshipTabPage
            // 
            relationshipTabPage.Controls.Add(parentIdObjectRelationshipTextBox);
            relationshipTabPage.Controls.Add(parentIdObjectRelationshipLabel);
            relationshipTabPage.Controls.Add(linkNameObjectRelationshipTextBox);
            relationshipTabPage.Controls.Add(childIdObjectRelationshipTextBox);
            relationshipTabPage.Controls.Add(linkNameObjectRelationshipLabel);
            relationshipTabPage.Controls.Add(childIdObjectRelationshipLabel);
            relationshipTabPage.Location = new Point(4, 24);
            relationshipTabPage.Name = "relationshipTabPage";
            relationshipTabPage.Size = new Size(559, 403);
            relationshipTabPage.TabIndex = 2;
            relationshipTabPage.Text = "Свзяь объектов";
            relationshipTabPage.UseVisualStyleBackColor = true;
            // 
            // parentIdObjectRelationshipTextBox
            // 
            parentIdObjectRelationshipTextBox.Location = new Point(6, 38);
            parentIdObjectRelationshipTextBox.MaxLength = 50;
            parentIdObjectRelationshipTextBox.Name = "parentIdObjectRelationshipTextBox";
            parentIdObjectRelationshipTextBox.Size = new Size(472, 23);
            parentIdObjectRelationshipTextBox.TabIndex = 15;
            // 
            // parentIdObjectRelationshipLabel
            // 
            parentIdObjectRelationshipLabel.AutoSize = true;
            parentIdObjectRelationshipLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            parentIdObjectRelationshipLabel.Location = new Point(6, 15);
            parentIdObjectRelationshipLabel.Name = "parentIdObjectRelationshipLabel";
            parentIdObjectRelationshipLabel.Size = new Size(156, 20);
            parentIdObjectRelationshipLabel.TabIndex = 14;
            parentIdObjectRelationshipLabel.Text = "Id объекта-родителя:";
            // 
            // linkNameObjectRelationshipTextBox
            // 
            linkNameObjectRelationshipTextBox.Location = new Point(6, 169);
            linkNameObjectRelationshipTextBox.MaxLength = 50;
            linkNameObjectRelationshipTextBox.Name = "linkNameObjectRelationshipTextBox";
            linkNameObjectRelationshipTextBox.Size = new Size(472, 23);
            linkNameObjectRelationshipTextBox.TabIndex = 13;
            // 
            // childIdObjectRelationshipTextBox
            // 
            childIdObjectRelationshipTextBox.Location = new Point(6, 103);
            childIdObjectRelationshipTextBox.MaxLength = 50;
            childIdObjectRelationshipTextBox.Name = "childIdObjectRelationshipTextBox";
            childIdObjectRelationshipTextBox.Size = new Size(472, 23);
            childIdObjectRelationshipTextBox.TabIndex = 12;
            // 
            // linkNameObjectRelationshipLabel
            // 
            linkNameObjectRelationshipLabel.AutoSize = true;
            linkNameObjectRelationshipLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            linkNameObjectRelationshipLabel.Location = new Point(6, 146);
            linkNameObjectRelationshipLabel.Name = "linkNameObjectRelationshipLabel";
            linkNameObjectRelationshipLabel.Size = new Size(124, 20);
            linkNameObjectRelationshipLabel.TabIndex = 11;
            linkNameObjectRelationshipLabel.Text = "Связующие имя:";
            // 
            // childIdObjectRelationshipLabel
            // 
            childIdObjectRelationshipLabel.AutoSize = true;
            childIdObjectRelationshipLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            childIdObjectRelationshipLabel.Location = new Point(6, 80);
            childIdObjectRelationshipLabel.Name = "childIdObjectRelationshipLabel";
            childIdObjectRelationshipLabel.Size = new Size(172, 20);
            childIdObjectRelationshipLabel.TabIndex = 10;
            childIdObjectRelationshipLabel.Text = "Id объекта-наследника:";
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
            // AddEntityButton
            // 
            AddEntityButton.Location = new Point(6, 512);
            AddEntityButton.Name = "AddEntityButton";
            AddEntityButton.Size = new Size(567, 31);
            AddEntityButton.TabIndex = 0;
            AddEntityButton.Text = "Добавить";
            AddEntityButton.UseVisualStyleBackColor = true;
            AddEntityButton.Click += AddEntityButton_Click;
            // 
            // updateTabPage
            // 
            updateTabPage.Controls.Add(entityUpdateTabControl);
            updateTabPage.Controls.Add(label3);
            updateTabPage.Controls.Add(UpdateEntityButton);
            updateTabPage.Location = new Point(4, 24);
            updateTabPage.Name = "updateTabPage";
            updateTabPage.Size = new Size(579, 552);
            updateTabPage.TabIndex = 2;
            updateTabPage.Text = "Обновить данные";
            updateTabPage.UseVisualStyleBackColor = true;
            // 
            // entityUpdateTabControl
            // 
            entityUpdateTabControl.Controls.Add(tabPage1);
            entityUpdateTabControl.Controls.Add(tabPage2);
            entityUpdateTabControl.Controls.Add(tabPage3);
            entityUpdateTabControl.Location = new Point(6, 29);
            entityUpdateTabControl.Name = "entityUpdateTabControl";
            entityUpdateTabControl.SelectedIndex = 0;
            entityUpdateTabControl.Size = new Size(567, 431);
            entityUpdateTabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(559, 403);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Объект";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(484, 449);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Атрибут";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(484, 449);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Свзяь объектов";
            tabPage3.UseVisualStyleBackColor = true;
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
            // UpdateEntityButton
            // 
            UpdateEntityButton.Location = new Point(6, 512);
            UpdateEntityButton.Name = "UpdateEntityButton";
            UpdateEntityButton.Size = new Size(567, 31);
            UpdateEntityButton.TabIndex = 1;
            UpdateEntityButton.Text = "Обновить";
            UpdateEntityButton.UseVisualStyleBackColor = true;
            // 
            // deleteTabPage
            // 
            deleteTabPage.Controls.Add(entityDeleteTabControl);
            deleteTabPage.Controls.Add(label4);
            deleteTabPage.Controls.Add(DeleteEntityButton);
            deleteTabPage.Location = new Point(4, 24);
            deleteTabPage.Name = "deleteTabPage";
            deleteTabPage.Padding = new Padding(3);
            deleteTabPage.Size = new Size(579, 552);
            deleteTabPage.TabIndex = 1;
            deleteTabPage.Text = "Удалить данные";
            deleteTabPage.UseVisualStyleBackColor = true;
            // 
            // entityDeleteTabControl
            // 
            entityDeleteTabControl.Controls.Add(tabPage4);
            entityDeleteTabControl.Controls.Add(tabPage5);
            entityDeleteTabControl.Controls.Add(tabPage6);
            entityDeleteTabControl.Location = new Point(6, 29);
            entityDeleteTabControl.Name = "entityDeleteTabControl";
            entityDeleteTabControl.SelectedIndex = 0;
            entityDeleteTabControl.Size = new Size(567, 431);
            entityDeleteTabControl.TabIndex = 4;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(559, 403);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Объект";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(484, 449);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Атрибут";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(484, 449);
            tabPage6.TabIndex = 2;
            tabPage6.Text = "Свзяь объектов";
            tabPage6.UseVisualStyleBackColor = true;
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
            // DeleteEntityButton
            // 
            DeleteEntityButton.Location = new Point(6, 512);
            DeleteEntityButton.Name = "DeleteEntityButton";
            DeleteEntityButton.Size = new Size(567, 31);
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
            OutputDataButton.Click += OutputDataButton_Click;
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
            // systemMessageTextBox
            // 
            systemMessageTextBox.Location = new Point(582, 599);
            systemMessageTextBox.Multiline = true;
            systemMessageTextBox.Name = "systemMessageTextBox";
            systemMessageTextBox.ReadOnly = true;
            systemMessageTextBox.ScrollBars = ScrollBars.Both;
            systemMessageTextBox.Size = new Size(587, 88);
            systemMessageTextBox.TabIndex = 5;
            // 
            // addAtteintionLabel
            // 
            addAtteintionLabel.AutoSize = true;
            addAtteintionLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addAtteintionLabel.Location = new Point(10, 475);
            addAtteintionLabel.Name = "addAtteintionLabel";
            addAtteintionLabel.Size = new Size(505, 20);
            addAtteintionLabel.TabIndex = 10;
            addAtteintionLabel.Text = "Внимание: Для связи сущностей, допускаются только существующие Id";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 703);
            Controls.Add(systemMessageTextBox);
            Controls.Add(XMLConvertButton);
            Controls.Add(label1);
            Controls.Add(OutputDataButton);
            Controls.Add(dbFunctionTabControl);
            Controls.Add(treeView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FromClosing;
            Shown += MainForm_Shown;
            dbFunctionTabControl.ResumeLayout(false);
            addTabPage.ResumeLayout(false);
            addTabPage.PerformLayout();
            entitiesAddTabControl.ResumeLayout(false);
            objectTabPage.ResumeLayout(false);
            objectTabPage.PerformLayout();
            attributeTabPage.ResumeLayout(false);
            attributeTabPage.PerformLayout();
            relationshipTabPage.ResumeLayout(false);
            relationshipTabPage.PerformLayout();
            updateTabPage.ResumeLayout(false);
            entityUpdateTabControl.ResumeLayout(false);
            deleteTabPage.ResumeLayout(false);
            entityDeleteTabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private TabControl entityUpdateTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabControl entityDeleteTabControl;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TextBox systemMessageTextBox;
        private Label TypeObjectLabel;
        private Label ProductObjectLabel;
        private TextBox typeObjectTextBox;
        private TextBox productObjectTextBox;
        private TextBox valueAttributeTextBox;
        private TextBox nameAttributeTextBox;
        private Label ValueAttributeLabel;
        private Label NameAttributeLabel;
        private TextBox objectIdAttributeTextBox;
        private Label ObjectIdAttributeLabel;
        private TextBox parentIdObjectRelationshipTextBox;
        private Label parentIdObjectRelationshipLabel;
        private TextBox linkNameObjectRelationshipTextBox;
        private TextBox childIdObjectRelationshipTextBox;
        private Label linkNameObjectRelationshipLabel;
        private Label childIdObjectRelationshipLabel;
        private Label addAtteintionLabel;
    }
}