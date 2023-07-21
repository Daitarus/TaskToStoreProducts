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
            addAtteintionLabel = new Label();
            entitiesAddTabControl = new TabControl();
            objectTabPage = new TabPage();
            productObjectAddTextBox = new TextBox();
            typeObjectAddTextBox = new TextBox();
            ProductObjectAddLabel = new Label();
            TypeObjectAddLabel = new Label();
            attributeTabPage = new TabPage();
            objectIdAttributeAddTextBox = new TextBox();
            ObjectIdAttributeAddLabel = new Label();
            valueAttributeAddTextBox = new TextBox();
            nameAttributeAddTextBox = new TextBox();
            ValueAttributeAddLabel = new Label();
            NameAttributeAddLabel = new Label();
            relationshipTabPage = new TabPage();
            parentIdObjectRelationshipAddTextBox = new TextBox();
            parentIdObjectRelationshipAddLabel = new Label();
            linkNameObjectRelationshipAddTextBox = new TextBox();
            childIdObjectRelationshipAddTextBox = new TextBox();
            linkNameObjectRelationshipAddLabel = new Label();
            childIdObjectRelationshipAddLabel = new Label();
            label2 = new Label();
            AddEntityButton = new Button();
            updateTabPage = new TabPage();
            updateAtteintionLabel1 = new Label();
            updateAtteintionLabel2 = new Label();
            entitiesUpdateTabControl = new TabControl();
            tabPage1 = new TabPage();
            idObjectUpdateTextBox = new TextBox();
            idObjectUpdateLabel = new Label();
            productObjectUpdateTextBox = new TextBox();
            typeObjectUpdateTextBox = new TextBox();
            productObjectUpdateLabel = new Label();
            typeObjectUpdateLabel = new Label();
            tabPage2 = new TabPage();
            objectIdAttributeUpdateTextBox = new TextBox();
            objectIdAttributeUpdateLabel = new Label();
            idAttributeUpdateTextBox = new TextBox();
            idAttributeUpdateLabel = new Label();
            valueAttributeUpdateTextBox = new TextBox();
            nameAttributeUpdateTextBox = new TextBox();
            valueAttributeUpdateLabel = new Label();
            nameAttributeUpdateLabel = new Label();
            tabPage3 = new TabPage();
            parentIdObjectRelationshipUpdateTextBox = new TextBox();
            parentIdObjectRelationshipUpdateLabel = new Label();
            idObjectRelationshipUpdateTextBox = new TextBox();
            idObjectRelationshipUpdateLabel = new Label();
            linkNameObjectRelationshipUpdateTextBox = new TextBox();
            childIdObjectRelationshipUpdateTextBox = new TextBox();
            linkNameObjectRelationshipUpdateLabel = new Label();
            childIdObjectRelationshipUpdateLabel = new Label();
            label3 = new Label();
            UpdateEntityButton = new Button();
            deleteTabPage = new TabPage();
            deleteAtteintionLabel2 = new Label();
            deleteAtteintionLabel1 = new Label();
            entitiesDeleteTabControl = new TabControl();
            tabPage4 = new TabPage();
            idObjectDeleteTextBox = new TextBox();
            idObjectDeleteLabel = new Label();
            tabPage5 = new TabPage();
            idAttributeDeleteTextBox = new TextBox();
            idAttributeDeleteLabel = new Label();
            tabPage6 = new TabPage();
            idObjectRelationshipDeleteTextBox = new TextBox();
            idObjectRelationshipDeleteLabel = new Label();
            label4 = new Label();
            DeleteEntityButton = new Button();
            OutputDataButton = new Button();
            label1 = new Label();
            XMLConvertButton = new Button();
            systemMessageTextBox = new TextBox();
            reconnectToDatabaseButton = new Button();
            dbFunctionTabControl.SuspendLayout();
            addTabPage.SuspendLayout();
            entitiesAddTabControl.SuspendLayout();
            objectTabPage.SuspendLayout();
            attributeTabPage.SuspendLayout();
            relationshipTabPage.SuspendLayout();
            updateTabPage.SuspendLayout();
            entitiesUpdateTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            deleteTabPage.SuspendLayout();
            entitiesDeleteTabControl.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 37);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(555, 650);
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
            // addAtteintionLabel
            // 
            addAtteintionLabel.AutoSize = true;
            addAtteintionLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addAtteintionLabel.Location = new Point(10, 489);
            addAtteintionLabel.Name = "addAtteintionLabel";
            addAtteintionLabel.Size = new Size(505, 20);
            addAtteintionLabel.TabIndex = 10;
            addAtteintionLabel.Text = "Внимание: Для связи сущностей, допускаются только существующие Id";
            // 
            // entitiesAddTabControl
            // 
            entitiesAddTabControl.Controls.Add(objectTabPage);
            entitiesAddTabControl.Controls.Add(attributeTabPage);
            entitiesAddTabControl.Controls.Add(relationshipTabPage);
            entitiesAddTabControl.Location = new Point(6, 29);
            entitiesAddTabControl.Name = "entitiesAddTabControl";
            entitiesAddTabControl.SelectedIndex = 0;
            entitiesAddTabControl.Size = new Size(567, 457);
            entitiesAddTabControl.TabIndex = 2;
            // 
            // objectTabPage
            // 
            objectTabPage.Controls.Add(productObjectAddTextBox);
            objectTabPage.Controls.Add(typeObjectAddTextBox);
            objectTabPage.Controls.Add(ProductObjectAddLabel);
            objectTabPage.Controls.Add(TypeObjectAddLabel);
            objectTabPage.Location = new Point(4, 24);
            objectTabPage.Name = "objectTabPage";
            objectTabPage.Padding = new Padding(3);
            objectTabPage.Size = new Size(559, 429);
            objectTabPage.TabIndex = 0;
            objectTabPage.Text = "Объект";
            objectTabPage.UseVisualStyleBackColor = true;
            // 
            // productObjectAddTextBox
            // 
            productObjectAddTextBox.Location = new Point(6, 110);
            productObjectAddTextBox.MaxLength = 50;
            productObjectAddTextBox.Name = "productObjectAddTextBox";
            productObjectAddTextBox.Size = new Size(547, 23);
            productObjectAddTextBox.TabIndex = 3;
            // 
            // typeObjectAddTextBox
            // 
            typeObjectAddTextBox.Location = new Point(6, 44);
            typeObjectAddTextBox.MaxLength = 50;
            typeObjectAddTextBox.Name = "typeObjectAddTextBox";
            typeObjectAddTextBox.Size = new Size(547, 23);
            typeObjectAddTextBox.TabIndex = 2;
            // 
            // ProductObjectAddLabel
            // 
            ProductObjectAddLabel.AutoSize = true;
            ProductObjectAddLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ProductObjectAddLabel.Location = new Point(6, 87);
            ProductObjectAddLabel.Name = "ProductObjectAddLabel";
            ProductObjectAddLabel.Size = new Size(167, 20);
            ProductObjectAddLabel.TabIndex = 1;
            ProductObjectAddLabel.Text = "Обозначение объекта:";
            // 
            // TypeObjectAddLabel
            // 
            TypeObjectAddLabel.AutoSize = true;
            TypeObjectAddLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TypeObjectAddLabel.Location = new Point(6, 21);
            TypeObjectAddLabel.Name = "TypeObjectAddLabel";
            TypeObjectAddLabel.Size = new Size(98, 20);
            TypeObjectAddLabel.TabIndex = 0;
            TypeObjectAddLabel.Text = "Тип объекта:";
            // 
            // attributeTabPage
            // 
            attributeTabPage.Controls.Add(objectIdAttributeAddTextBox);
            attributeTabPage.Controls.Add(ObjectIdAttributeAddLabel);
            attributeTabPage.Controls.Add(valueAttributeAddTextBox);
            attributeTabPage.Controls.Add(nameAttributeAddTextBox);
            attributeTabPage.Controls.Add(ValueAttributeAddLabel);
            attributeTabPage.Controls.Add(NameAttributeAddLabel);
            attributeTabPage.Location = new Point(4, 24);
            attributeTabPage.Name = "attributeTabPage";
            attributeTabPage.Padding = new Padding(3);
            attributeTabPage.Size = new Size(559, 429);
            attributeTabPage.TabIndex = 1;
            attributeTabPage.Text = "Атрибут";
            attributeTabPage.UseVisualStyleBackColor = true;
            // 
            // objectIdAttributeAddTextBox
            // 
            objectIdAttributeAddTextBox.Location = new Point(6, 38);
            objectIdAttributeAddTextBox.MaxLength = 50;
            objectIdAttributeAddTextBox.Name = "objectIdAttributeAddTextBox";
            objectIdAttributeAddTextBox.Size = new Size(547, 23);
            objectIdAttributeAddTextBox.TabIndex = 9;
            // 
            // ObjectIdAttributeAddLabel
            // 
            ObjectIdAttributeAddLabel.AutoSize = true;
            ObjectIdAttributeAddLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ObjectIdAttributeAddLabel.Location = new Point(6, 15);
            ObjectIdAttributeAddLabel.Name = "ObjectIdAttributeAddLabel";
            ObjectIdAttributeAddLabel.Size = new Size(85, 20);
            ObjectIdAttributeAddLabel.TabIndex = 8;
            ObjectIdAttributeAddLabel.Text = "Id объекта:";
            // 
            // valueAttributeAddTextBox
            // 
            valueAttributeAddTextBox.Location = new Point(6, 169);
            valueAttributeAddTextBox.MaxLength = 50;
            valueAttributeAddTextBox.Name = "valueAttributeAddTextBox";
            valueAttributeAddTextBox.Size = new Size(547, 23);
            valueAttributeAddTextBox.TabIndex = 7;
            // 
            // nameAttributeAddTextBox
            // 
            nameAttributeAddTextBox.Location = new Point(6, 103);
            nameAttributeAddTextBox.MaxLength = 50;
            nameAttributeAddTextBox.Name = "nameAttributeAddTextBox";
            nameAttributeAddTextBox.Size = new Size(547, 23);
            nameAttributeAddTextBox.TabIndex = 6;
            // 
            // ValueAttributeAddLabel
            // 
            ValueAttributeAddLabel.AutoSize = true;
            ValueAttributeAddLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ValueAttributeAddLabel.Location = new Point(6, 146);
            ValueAttributeAddLabel.Name = "ValueAttributeAddLabel";
            ValueAttributeAddLabel.Size = new Size(145, 20);
            ValueAttributeAddLabel.TabIndex = 5;
            ValueAttributeAddLabel.Text = "Значение атрибута:";
            // 
            // NameAttributeAddLabel
            // 
            NameAttributeAddLabel.AutoSize = true;
            NameAttributeAddLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NameAttributeAddLabel.Location = new Point(6, 80);
            NameAttributeAddLabel.Name = "NameAttributeAddLabel";
            NameAttributeAddLabel.Size = new Size(108, 20);
            NameAttributeAddLabel.TabIndex = 4;
            NameAttributeAddLabel.Text = "Имя атрибута:";
            // 
            // relationshipTabPage
            // 
            relationshipTabPage.Controls.Add(parentIdObjectRelationshipAddTextBox);
            relationshipTabPage.Controls.Add(parentIdObjectRelationshipAddLabel);
            relationshipTabPage.Controls.Add(linkNameObjectRelationshipAddTextBox);
            relationshipTabPage.Controls.Add(childIdObjectRelationshipAddTextBox);
            relationshipTabPage.Controls.Add(linkNameObjectRelationshipAddLabel);
            relationshipTabPage.Controls.Add(childIdObjectRelationshipAddLabel);
            relationshipTabPage.Location = new Point(4, 24);
            relationshipTabPage.Name = "relationshipTabPage";
            relationshipTabPage.Size = new Size(559, 429);
            relationshipTabPage.TabIndex = 2;
            relationshipTabPage.Text = "Свзяь объектов";
            relationshipTabPage.UseVisualStyleBackColor = true;
            // 
            // parentIdObjectRelationshipAddTextBox
            // 
            parentIdObjectRelationshipAddTextBox.Location = new Point(6, 38);
            parentIdObjectRelationshipAddTextBox.MaxLength = 50;
            parentIdObjectRelationshipAddTextBox.Name = "parentIdObjectRelationshipAddTextBox";
            parentIdObjectRelationshipAddTextBox.Size = new Size(550, 23);
            parentIdObjectRelationshipAddTextBox.TabIndex = 15;
            // 
            // parentIdObjectRelationshipAddLabel
            // 
            parentIdObjectRelationshipAddLabel.AutoSize = true;
            parentIdObjectRelationshipAddLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            parentIdObjectRelationshipAddLabel.Location = new Point(6, 15);
            parentIdObjectRelationshipAddLabel.Name = "parentIdObjectRelationshipAddLabel";
            parentIdObjectRelationshipAddLabel.Size = new Size(156, 20);
            parentIdObjectRelationshipAddLabel.TabIndex = 14;
            parentIdObjectRelationshipAddLabel.Text = "Id объекта-родителя:";
            // 
            // linkNameObjectRelationshipAddTextBox
            // 
            linkNameObjectRelationshipAddTextBox.Location = new Point(6, 169);
            linkNameObjectRelationshipAddTextBox.MaxLength = 50;
            linkNameObjectRelationshipAddTextBox.Name = "linkNameObjectRelationshipAddTextBox";
            linkNameObjectRelationshipAddTextBox.Size = new Size(550, 23);
            linkNameObjectRelationshipAddTextBox.TabIndex = 13;
            // 
            // childIdObjectRelationshipAddTextBox
            // 
            childIdObjectRelationshipAddTextBox.Location = new Point(6, 103);
            childIdObjectRelationshipAddTextBox.MaxLength = 50;
            childIdObjectRelationshipAddTextBox.Name = "childIdObjectRelationshipAddTextBox";
            childIdObjectRelationshipAddTextBox.Size = new Size(550, 23);
            childIdObjectRelationshipAddTextBox.TabIndex = 12;
            // 
            // linkNameObjectRelationshipAddLabel
            // 
            linkNameObjectRelationshipAddLabel.AutoSize = true;
            linkNameObjectRelationshipAddLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            linkNameObjectRelationshipAddLabel.Location = new Point(6, 146);
            linkNameObjectRelationshipAddLabel.Name = "linkNameObjectRelationshipAddLabel";
            linkNameObjectRelationshipAddLabel.Size = new Size(124, 20);
            linkNameObjectRelationshipAddLabel.TabIndex = 11;
            linkNameObjectRelationshipAddLabel.Text = "Связующие имя:";
            // 
            // childIdObjectRelationshipAddLabel
            // 
            childIdObjectRelationshipAddLabel.AutoSize = true;
            childIdObjectRelationshipAddLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            childIdObjectRelationshipAddLabel.Location = new Point(6, 80);
            childIdObjectRelationshipAddLabel.Name = "childIdObjectRelationshipAddLabel";
            childIdObjectRelationshipAddLabel.Size = new Size(172, 20);
            childIdObjectRelationshipAddLabel.TabIndex = 10;
            childIdObjectRelationshipAddLabel.Text = "Id объекта-наследника:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 3);
            label2.Name = "label2";
            label2.Size = new Size(567, 23);
            label2.TabIndex = 1;
            label2.Text = "Заполните все поля добавляемой сущности";
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
            updateTabPage.Controls.Add(updateAtteintionLabel1);
            updateTabPage.Controls.Add(updateAtteintionLabel2);
            updateTabPage.Controls.Add(entitiesUpdateTabControl);
            updateTabPage.Controls.Add(label3);
            updateTabPage.Controls.Add(UpdateEntityButton);
            updateTabPage.Location = new Point(4, 24);
            updateTabPage.Name = "updateTabPage";
            updateTabPage.Size = new Size(579, 552);
            updateTabPage.TabIndex = 2;
            updateTabPage.Text = "Обновить данные";
            updateTabPage.UseVisualStyleBackColor = true;
            // 
            // updateAtteintionLabel1
            // 
            updateAtteintionLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            updateAtteintionLabel1.Location = new Point(10, 443);
            updateAtteintionLabel1.Name = "updateAtteintionLabel1";
            updateAtteintionLabel1.Size = new Size(559, 46);
            updateAtteintionLabel1.TabIndex = 12;
            updateAtteintionLabel1.Text = "Внимание: Выбор изменяемой сущность происходит путём ввода её существующего Id, сам Id не изменяется!";
            // 
            // updateAtteintionLabel2
            // 
            updateAtteintionLabel2.AutoSize = true;
            updateAtteintionLabel2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            updateAtteintionLabel2.Location = new Point(10, 489);
            updateAtteintionLabel2.Name = "updateAtteintionLabel2";
            updateAtteintionLabel2.Size = new Size(505, 20);
            updateAtteintionLabel2.TabIndex = 11;
            updateAtteintionLabel2.Text = "Внимание: Для связи сущностей, допускаются только существующие Id";
            // 
            // entitiesUpdateTabControl
            // 
            entitiesUpdateTabControl.Controls.Add(tabPage1);
            entitiesUpdateTabControl.Controls.Add(tabPage2);
            entitiesUpdateTabControl.Controls.Add(tabPage3);
            entitiesUpdateTabControl.Location = new Point(6, 29);
            entitiesUpdateTabControl.Name = "entitiesUpdateTabControl";
            entitiesUpdateTabControl.SelectedIndex = 0;
            entitiesUpdateTabControl.Size = new Size(567, 411);
            entitiesUpdateTabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(idObjectUpdateTextBox);
            tabPage1.Controls.Add(idObjectUpdateLabel);
            tabPage1.Controls.Add(productObjectUpdateTextBox);
            tabPage1.Controls.Add(typeObjectUpdateTextBox);
            tabPage1.Controls.Add(productObjectUpdateLabel);
            tabPage1.Controls.Add(typeObjectUpdateLabel);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(559, 383);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Объект";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // idObjectUpdateTextBox
            // 
            idObjectUpdateTextBox.Location = new Point(6, 38);
            idObjectUpdateTextBox.MaxLength = 50;
            idObjectUpdateTextBox.Name = "idObjectUpdateTextBox";
            idObjectUpdateTextBox.Size = new Size(547, 23);
            idObjectUpdateTextBox.TabIndex = 15;
            // 
            // idObjectUpdateLabel
            // 
            idObjectUpdateLabel.AutoSize = true;
            idObjectUpdateLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            idObjectUpdateLabel.Location = new Point(6, 15);
            idObjectUpdateLabel.Name = "idObjectUpdateLabel";
            idObjectUpdateLabel.Size = new Size(184, 20);
            idObjectUpdateLabel.TabIndex = 14;
            idObjectUpdateLabel.Text = "Id изменяемого объекта:";
            // 
            // productObjectUpdateTextBox
            // 
            productObjectUpdateTextBox.Location = new Point(6, 169);
            productObjectUpdateTextBox.MaxLength = 50;
            productObjectUpdateTextBox.Name = "productObjectUpdateTextBox";
            productObjectUpdateTextBox.Size = new Size(547, 23);
            productObjectUpdateTextBox.TabIndex = 13;
            // 
            // typeObjectUpdateTextBox
            // 
            typeObjectUpdateTextBox.Location = new Point(6, 103);
            typeObjectUpdateTextBox.MaxLength = 50;
            typeObjectUpdateTextBox.Name = "typeObjectUpdateTextBox";
            typeObjectUpdateTextBox.Size = new Size(547, 23);
            typeObjectUpdateTextBox.TabIndex = 12;
            // 
            // productObjectUpdateLabel
            // 
            productObjectUpdateLabel.AutoSize = true;
            productObjectUpdateLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            productObjectUpdateLabel.Location = new Point(6, 146);
            productObjectUpdateLabel.Name = "productObjectUpdateLabel";
            productObjectUpdateLabel.Size = new Size(167, 20);
            productObjectUpdateLabel.TabIndex = 11;
            productObjectUpdateLabel.Text = "Обозначение объекта:";
            // 
            // typeObjectUpdateLabel
            // 
            typeObjectUpdateLabel.AutoSize = true;
            typeObjectUpdateLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            typeObjectUpdateLabel.Location = new Point(6, 80);
            typeObjectUpdateLabel.Name = "typeObjectUpdateLabel";
            typeObjectUpdateLabel.Size = new Size(98, 20);
            typeObjectUpdateLabel.TabIndex = 10;
            typeObjectUpdateLabel.Text = "Тип объекта:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(objectIdAttributeUpdateTextBox);
            tabPage2.Controls.Add(objectIdAttributeUpdateLabel);
            tabPage2.Controls.Add(idAttributeUpdateTextBox);
            tabPage2.Controls.Add(idAttributeUpdateLabel);
            tabPage2.Controls.Add(valueAttributeUpdateTextBox);
            tabPage2.Controls.Add(nameAttributeUpdateTextBox);
            tabPage2.Controls.Add(valueAttributeUpdateLabel);
            tabPage2.Controls.Add(nameAttributeUpdateLabel);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(559, 383);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Атрибут";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // objectIdAttributeUpdateTextBox
            // 
            objectIdAttributeUpdateTextBox.Location = new Point(6, 100);
            objectIdAttributeUpdateTextBox.MaxLength = 50;
            objectIdAttributeUpdateTextBox.Name = "objectIdAttributeUpdateTextBox";
            objectIdAttributeUpdateTextBox.Size = new Size(547, 23);
            objectIdAttributeUpdateTextBox.TabIndex = 23;
            // 
            // objectIdAttributeUpdateLabel
            // 
            objectIdAttributeUpdateLabel.AutoSize = true;
            objectIdAttributeUpdateLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            objectIdAttributeUpdateLabel.Location = new Point(6, 77);
            objectIdAttributeUpdateLabel.Name = "objectIdAttributeUpdateLabel";
            objectIdAttributeUpdateLabel.Size = new Size(85, 20);
            objectIdAttributeUpdateLabel.TabIndex = 22;
            objectIdAttributeUpdateLabel.Text = "Id объекта:";
            // 
            // idAttributeUpdateTextBox
            // 
            idAttributeUpdateTextBox.Location = new Point(6, 38);
            idAttributeUpdateTextBox.MaxLength = 50;
            idAttributeUpdateTextBox.Name = "idAttributeUpdateTextBox";
            idAttributeUpdateTextBox.Size = new Size(547, 23);
            idAttributeUpdateTextBox.TabIndex = 21;
            // 
            // idAttributeUpdateLabel
            // 
            idAttributeUpdateLabel.AutoSize = true;
            idAttributeUpdateLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            idAttributeUpdateLabel.Location = new Point(6, 15);
            idAttributeUpdateLabel.Name = "idAttributeUpdateLabel";
            idAttributeUpdateLabel.Size = new Size(190, 20);
            idAttributeUpdateLabel.TabIndex = 20;
            idAttributeUpdateLabel.Text = "Id изменяемого атрибута:";
            // 
            // valueAttributeUpdateTextBox
            // 
            valueAttributeUpdateTextBox.Location = new Point(6, 228);
            valueAttributeUpdateTextBox.MaxLength = 50;
            valueAttributeUpdateTextBox.Name = "valueAttributeUpdateTextBox";
            valueAttributeUpdateTextBox.Size = new Size(547, 23);
            valueAttributeUpdateTextBox.TabIndex = 19;
            // 
            // nameAttributeUpdateTextBox
            // 
            nameAttributeUpdateTextBox.Location = new Point(6, 162);
            nameAttributeUpdateTextBox.MaxLength = 50;
            nameAttributeUpdateTextBox.Name = "nameAttributeUpdateTextBox";
            nameAttributeUpdateTextBox.Size = new Size(547, 23);
            nameAttributeUpdateTextBox.TabIndex = 18;
            // 
            // valueAttributeUpdateLabel
            // 
            valueAttributeUpdateLabel.AutoSize = true;
            valueAttributeUpdateLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            valueAttributeUpdateLabel.Location = new Point(6, 205);
            valueAttributeUpdateLabel.Name = "valueAttributeUpdateLabel";
            valueAttributeUpdateLabel.Size = new Size(145, 20);
            valueAttributeUpdateLabel.TabIndex = 17;
            valueAttributeUpdateLabel.Text = "Значение атрибута:";
            // 
            // nameAttributeUpdateLabel
            // 
            nameAttributeUpdateLabel.AutoSize = true;
            nameAttributeUpdateLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nameAttributeUpdateLabel.Location = new Point(6, 139);
            nameAttributeUpdateLabel.Name = "nameAttributeUpdateLabel";
            nameAttributeUpdateLabel.Size = new Size(108, 20);
            nameAttributeUpdateLabel.TabIndex = 16;
            nameAttributeUpdateLabel.Text = "Имя атрибута:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(parentIdObjectRelationshipUpdateTextBox);
            tabPage3.Controls.Add(parentIdObjectRelationshipUpdateLabel);
            tabPage3.Controls.Add(idObjectRelationshipUpdateTextBox);
            tabPage3.Controls.Add(idObjectRelationshipUpdateLabel);
            tabPage3.Controls.Add(linkNameObjectRelationshipUpdateTextBox);
            tabPage3.Controls.Add(childIdObjectRelationshipUpdateTextBox);
            tabPage3.Controls.Add(linkNameObjectRelationshipUpdateLabel);
            tabPage3.Controls.Add(childIdObjectRelationshipUpdateLabel);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(559, 383);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Свзяь объектов";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // parentIdObjectRelationshipUpdateTextBox
            // 
            parentIdObjectRelationshipUpdateTextBox.Location = new Point(6, 100);
            parentIdObjectRelationshipUpdateTextBox.MaxLength = 50;
            parentIdObjectRelationshipUpdateTextBox.Name = "parentIdObjectRelationshipUpdateTextBox";
            parentIdObjectRelationshipUpdateTextBox.Size = new Size(547, 23);
            parentIdObjectRelationshipUpdateTextBox.TabIndex = 31;
            // 
            // parentIdObjectRelationshipUpdateLabel
            // 
            parentIdObjectRelationshipUpdateLabel.AutoSize = true;
            parentIdObjectRelationshipUpdateLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            parentIdObjectRelationshipUpdateLabel.Location = new Point(6, 77);
            parentIdObjectRelationshipUpdateLabel.Name = "parentIdObjectRelationshipUpdateLabel";
            parentIdObjectRelationshipUpdateLabel.Size = new Size(156, 20);
            parentIdObjectRelationshipUpdateLabel.TabIndex = 30;
            parentIdObjectRelationshipUpdateLabel.Text = "Id объекта-родителя:";
            // 
            // idObjectRelationshipUpdateTextBox
            // 
            idObjectRelationshipUpdateTextBox.Location = new Point(6, 38);
            idObjectRelationshipUpdateTextBox.MaxLength = 50;
            idObjectRelationshipUpdateTextBox.Name = "idObjectRelationshipUpdateTextBox";
            idObjectRelationshipUpdateTextBox.Size = new Size(547, 23);
            idObjectRelationshipUpdateTextBox.TabIndex = 29;
            // 
            // idObjectRelationshipUpdateLabel
            // 
            idObjectRelationshipUpdateLabel.AutoSize = true;
            idObjectRelationshipUpdateLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            idObjectRelationshipUpdateLabel.Location = new Point(6, 15);
            idObjectRelationshipUpdateLabel.Name = "idObjectRelationshipUpdateLabel";
            idObjectRelationshipUpdateLabel.Size = new Size(161, 20);
            idObjectRelationshipUpdateLabel.TabIndex = 28;
            idObjectRelationshipUpdateLabel.Text = "Id изменяемой связи:";
            // 
            // linkNameObjectRelationshipUpdateTextBox
            // 
            linkNameObjectRelationshipUpdateTextBox.Location = new Point(6, 228);
            linkNameObjectRelationshipUpdateTextBox.MaxLength = 50;
            linkNameObjectRelationshipUpdateTextBox.Name = "linkNameObjectRelationshipUpdateTextBox";
            linkNameObjectRelationshipUpdateTextBox.Size = new Size(547, 23);
            linkNameObjectRelationshipUpdateTextBox.TabIndex = 27;
            // 
            // childIdObjectRelationshipUpdateTextBox
            // 
            childIdObjectRelationshipUpdateTextBox.Location = new Point(6, 162);
            childIdObjectRelationshipUpdateTextBox.MaxLength = 50;
            childIdObjectRelationshipUpdateTextBox.Name = "childIdObjectRelationshipUpdateTextBox";
            childIdObjectRelationshipUpdateTextBox.Size = new Size(547, 23);
            childIdObjectRelationshipUpdateTextBox.TabIndex = 26;
            // 
            // linkNameObjectRelationshipUpdateLabel
            // 
            linkNameObjectRelationshipUpdateLabel.AutoSize = true;
            linkNameObjectRelationshipUpdateLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            linkNameObjectRelationshipUpdateLabel.Location = new Point(6, 205);
            linkNameObjectRelationshipUpdateLabel.Name = "linkNameObjectRelationshipUpdateLabel";
            linkNameObjectRelationshipUpdateLabel.Size = new Size(124, 20);
            linkNameObjectRelationshipUpdateLabel.TabIndex = 25;
            linkNameObjectRelationshipUpdateLabel.Text = "Связующие имя:";
            // 
            // childIdObjectRelationshipUpdateLabel
            // 
            childIdObjectRelationshipUpdateLabel.AutoSize = true;
            childIdObjectRelationshipUpdateLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            childIdObjectRelationshipUpdateLabel.Location = new Point(6, 139);
            childIdObjectRelationshipUpdateLabel.Name = "childIdObjectRelationshipUpdateLabel";
            childIdObjectRelationshipUpdateLabel.Size = new Size(172, 20);
            childIdObjectRelationshipUpdateLabel.TabIndex = 24;
            childIdObjectRelationshipUpdateLabel.Text = "Id объекта-наследника:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 3);
            label3.Name = "label3";
            label3.Size = new Size(567, 23);
            label3.TabIndex = 2;
            label3.Text = "Заполните изменяемые поля нужно сущности";
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
            UpdateEntityButton.Click += UpdateEntityButton_Click;
            // 
            // deleteTabPage
            // 
            deleteTabPage.Controls.Add(deleteAtteintionLabel2);
            deleteTabPage.Controls.Add(deleteAtteintionLabel1);
            deleteTabPage.Controls.Add(entitiesDeleteTabControl);
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
            // deleteAtteintionLabel2
            // 
            deleteAtteintionLabel2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteAtteintionLabel2.Location = new Point(10, 463);
            deleteAtteintionLabel2.Name = "deleteAtteintionLabel2";
            deleteAtteintionLabel2.Size = new Size(559, 46);
            deleteAtteintionLabel2.TabIndex = 14;
            deleteAtteintionLabel2.Text = "Внимание: Если имеются сущности, которые зависят от удаляемой, они тоже будут удалены!";
            // 
            // deleteAtteintionLabel1
            // 
            deleteAtteintionLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteAtteintionLabel1.Location = new Point(10, 418);
            deleteAtteintionLabel1.Name = "deleteAtteintionLabel1";
            deleteAtteintionLabel1.Size = new Size(559, 46);
            deleteAtteintionLabel1.TabIndex = 13;
            deleteAtteintionLabel1.Text = "Внимание: Выбор удаляемой сущность происходит путём ввода её существующего Id!";
            // 
            // entitiesDeleteTabControl
            // 
            entitiesDeleteTabControl.Controls.Add(tabPage4);
            entitiesDeleteTabControl.Controls.Add(tabPage5);
            entitiesDeleteTabControl.Controls.Add(tabPage6);
            entitiesDeleteTabControl.Location = new Point(6, 29);
            entitiesDeleteTabControl.Name = "entitiesDeleteTabControl";
            entitiesDeleteTabControl.SelectedIndex = 0;
            entitiesDeleteTabControl.Size = new Size(567, 386);
            entitiesDeleteTabControl.TabIndex = 4;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(idObjectDeleteTextBox);
            tabPage4.Controls.Add(idObjectDeleteLabel);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(559, 358);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Объект";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // idObjectDeleteTextBox
            // 
            idObjectDeleteTextBox.Location = new Point(6, 38);
            idObjectDeleteTextBox.MaxLength = 50;
            idObjectDeleteTextBox.Name = "idObjectDeleteTextBox";
            idObjectDeleteTextBox.Size = new Size(547, 23);
            idObjectDeleteTextBox.TabIndex = 31;
            // 
            // idObjectDeleteLabel
            // 
            idObjectDeleteLabel.AutoSize = true;
            idObjectDeleteLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            idObjectDeleteLabel.Location = new Point(6, 15);
            idObjectDeleteLabel.Name = "idObjectDeleteLabel";
            idObjectDeleteLabel.Size = new Size(171, 20);
            idObjectDeleteLabel.TabIndex = 30;
            idObjectDeleteLabel.Text = "Id удаляемого объекта:";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(idAttributeDeleteTextBox);
            tabPage5.Controls.Add(idAttributeDeleteLabel);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(559, 358);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Атрибут";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // idAttributeDeleteTextBox
            // 
            idAttributeDeleteTextBox.Location = new Point(6, 38);
            idAttributeDeleteTextBox.MaxLength = 50;
            idAttributeDeleteTextBox.Name = "idAttributeDeleteTextBox";
            idAttributeDeleteTextBox.Size = new Size(547, 23);
            idAttributeDeleteTextBox.TabIndex = 33;
            // 
            // idAttributeDeleteLabel
            // 
            idAttributeDeleteLabel.AutoSize = true;
            idAttributeDeleteLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            idAttributeDeleteLabel.ForeColor = SystemColors.ControlText;
            idAttributeDeleteLabel.Location = new Point(6, 15);
            idAttributeDeleteLabel.Name = "idAttributeDeleteLabel";
            idAttributeDeleteLabel.Size = new Size(177, 20);
            idAttributeDeleteLabel.TabIndex = 32;
            idAttributeDeleteLabel.Text = "Id удаляемого атрибута:";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(idObjectRelationshipDeleteTextBox);
            tabPage6.Controls.Add(idObjectRelationshipDeleteLabel);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(559, 358);
            tabPage6.TabIndex = 2;
            tabPage6.Text = "Свзяь объектов";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // idObjectRelationshipDeleteTextBox
            // 
            idObjectRelationshipDeleteTextBox.Location = new Point(6, 38);
            idObjectRelationshipDeleteTextBox.MaxLength = 50;
            idObjectRelationshipDeleteTextBox.Name = "idObjectRelationshipDeleteTextBox";
            idObjectRelationshipDeleteTextBox.Size = new Size(547, 23);
            idObjectRelationshipDeleteTextBox.TabIndex = 35;
            // 
            // idObjectRelationshipDeleteLabel
            // 
            idObjectRelationshipDeleteLabel.AutoSize = true;
            idObjectRelationshipDeleteLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            idObjectRelationshipDeleteLabel.ForeColor = SystemColors.ControlText;
            idObjectRelationshipDeleteLabel.Location = new Point(6, 15);
            idObjectRelationshipDeleteLabel.Name = "idObjectRelationshipDeleteLabel";
            idObjectRelationshipDeleteLabel.Size = new Size(148, 20);
            idObjectRelationshipDeleteLabel.TabIndex = 34;
            idObjectRelationshipDeleteLabel.Text = "Id удаляемой связи:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 3);
            label4.Name = "label4";
            label4.Size = new Size(567, 23);
            label4.TabIndex = 3;
            label4.Text = "Выберите удаляемую сущность";
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
            DeleteEntityButton.Click += DeleteEntityButton_Click;
            // 
            // OutputDataButton
            // 
            OutputDataButton.Location = new Point(12, 697);
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
            XMLConvertButton.Location = new Point(292, 697);
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
            // reconnectToDatabaseButton
            // 
            reconnectToDatabaseButton.Location = new Point(582, 697);
            reconnectToDatabaseButton.Name = "reconnectToDatabaseButton";
            reconnectToDatabaseButton.Size = new Size(587, 30);
            reconnectToDatabaseButton.TabIndex = 6;
            reconnectToDatabaseButton.Text = "Переподключится к базе данных";
            reconnectToDatabaseButton.UseVisualStyleBackColor = true;
            reconnectToDatabaseButton.Click += reconnectToDatabaseButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 739);
            Controls.Add(reconnectToDatabaseButton);
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
            updateTabPage.PerformLayout();
            entitiesUpdateTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            deleteTabPage.ResumeLayout(false);
            entitiesDeleteTabControl.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
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
        private TabControl entitiesUpdateTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabControl entitiesDeleteTabControl;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TextBox systemMessageTextBox;
        private Label TypeObjectAddLabel;
        private Label ProductObjectAddLabel;
        private TextBox typeObjectAddTextBox;
        private TextBox productObjectAddTextBox;
        private TextBox valueAttributeAddTextBox;
        private TextBox nameAttributeAddTextBox;
        private Label ValueAttributeAddLabel;
        private Label NameAttributeAddLabel;
        private TextBox objectIdAttributeAddTextBox;
        private Label ObjectIdAttributeAddLabel;
        private TextBox parentIdObjectRelationshipAddTextBox;
        private Label parentIdObjectRelationshipAddLabel;
        private TextBox linkNameObjectRelationshipAddTextBox;
        private TextBox childIdObjectRelationshipAddTextBox;
        private Label linkNameObjectRelationshipAddLabel;
        private Label childIdObjectRelationshipAddLabel;
        private Label addAtteintionLabel;
        private TextBox idObjectUpdateTextBox;
        private Label idObjectUpdateLabel;
        private TextBox productObjectUpdateTextBox;
        private TextBox typeObjectUpdateTextBox;
        private Label productObjectUpdateLabel;
        private Label typeObjectUpdateLabel;
        private Label updateAtteintionLabel1;
        private Label updateAtteintionLabel2;
        private TextBox idAttributeUpdateTextBox;
        private Label idAttributeUpdateLabel;
        private TextBox valueAttributeUpdateTextBox;
        private TextBox nameAttributeUpdateTextBox;
        private Label valueAttributeUpdateLabel;
        private Label nameAttributeUpdateLabel;
        private TextBox objectIdAttributeUpdateTextBox;
        private Label objectIdAttributeUpdateLabel;
        private TextBox parentIdObjectRelationshipUpdateTextBox;
        private Label parentIdObjectRelationshipUpdateLabel;
        private TextBox idObjectRelationshipUpdateTextBox;
        private Label idObjectRelationshipUpdateLabel;
        private TextBox linkNameObjectRelationshipUpdateTextBox;
        private TextBox childIdObjectRelationshipUpdateTextBox;
        private Label linkNameObjectRelationshipUpdateLabel;
        private Label childIdObjectRelationshipUpdateLabel;
        private Label deleteAtteintionLabel2;
        private Label deleteAtteintionLabel1;
        private TextBox idObjectDeleteTextBox;
        private Label idObjectDeleteLabel;
        private TextBox idAttributeDeleteTextBox;
        private Label idAttributeDeleteLabel;
        private TextBox idObjectRelationshipDeleteTextBox;
        private Label idObjectRelationshipDeleteLabel;
        private Button reconnectToDatabaseButton;
    }
}