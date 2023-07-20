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
            attributeTabPage = new TabPage();
            relationshipTabPage = new TabPage();
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
            dbFunctionTabControl.SuspendLayout();
            addTabPage.SuspendLayout();
            entitiesAddTabControl.SuspendLayout();
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
            dbFunctionTabControl.Size = new Size(512, 580);
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
            addTabPage.Size = new Size(504, 552);
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
            AddEntityButton.Size = new Size(492, 31);
            AddEntityButton.TabIndex = 0;
            AddEntityButton.Text = "Добавить";
            AddEntityButton.UseVisualStyleBackColor = true;
            // 
            // updateTabPage
            // 
            updateTabPage.Controls.Add(entityUpdateTabControl);
            updateTabPage.Controls.Add(label3);
            updateTabPage.Controls.Add(UpdateEntityButton);
            updateTabPage.Location = new Point(4, 24);
            updateTabPage.Name = "updateTabPage";
            updateTabPage.Size = new Size(504, 552);
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
            entityUpdateTabControl.Size = new Size(492, 477);
            entityUpdateTabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(484, 449);
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
            UpdateEntityButton.Size = new Size(492, 31);
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
            deleteTabPage.Size = new Size(504, 552);
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
            entityDeleteTabControl.Size = new Size(492, 477);
            entityDeleteTabControl.TabIndex = 4;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(484, 449);
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
            systemMessageTextBox.Size = new Size(512, 88);
            systemMessageTextBox.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 703);
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
            entitiesAddTabControl.ResumeLayout(false);
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
    }
}