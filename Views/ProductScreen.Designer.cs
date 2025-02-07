namespace InventoryManager_C968.Views {
    partial class ProductScreen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            labelProduct = new Label();
            textBoxID = new TextBox();
            labelID = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            labelInventory = new Label();
            labelPrice = new Label();
            labelMax = new Label();
            textBoxInentory = new TextBox();
            textBoxPrice = new TextBox();
            textBoxMin = new TextBox();
            textBoxMax = new TextBox();
            groupBoxRange = new GroupBox();
            labelMin = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            dataGridViewAssoc = new DataGridView();
            dataGridViewCand = new DataGridView();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            labelCadndateTable = new Label();
            labelAssociatedTable = new Label();
            groupBoxRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCand).BeginInit();
            SuspendLayout();
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProduct.Location = new Point(12, 9);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(70, 21);
            labelProduct.TabIndex = 0;
            labelProduct.Text = "Product";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(125, 104);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(185, 23);
            textBoxID.TabIndex = 4;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(12, 112);
            labelID.Name = "labelID";
            labelID.Size = new Size(18, 15);
            labelID.TabIndex = 5;
            labelID.Text = "ID";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(125, 133);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(185, 23);
            textBoxName.TabIndex = 6;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 141);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 7;
            labelName.Text = "Name";
            // 
            // labelInventory
            // 
            labelInventory.AutoSize = true;
            labelInventory.Location = new Point(12, 170);
            labelInventory.Name = "labelInventory";
            labelInventory.Size = new Size(57, 15);
            labelInventory.TabIndex = 8;
            labelInventory.Text = "Inventory";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(12, 199);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(33, 15);
            labelPrice.TabIndex = 9;
            labelPrice.Text = "Price";
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Location = new Point(163, 30);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(30, 15);
            labelMax.TabIndex = 10;
            labelMax.Text = "Max";
            // 
            // textBoxInentory
            // 
            textBoxInentory.Location = new Point(125, 162);
            textBoxInentory.Name = "textBoxInentory";
            textBoxInentory.Size = new Size(185, 23);
            textBoxInentory.TabIndex = 11;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(125, 191);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(185, 23);
            textBoxPrice.TabIndex = 12;
            // 
            // textBoxMin
            // 
            textBoxMin.Location = new Point(67, 22);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new Size(57, 23);
            textBoxMin.TabIndex = 13;
            // 
            // textBoxMax
            // 
            textBoxMax.Location = new Point(199, 22);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new Size(57, 23);
            textBoxMax.TabIndex = 14;
            // 
            // groupBoxRange
            // 
            groupBoxRange.Controls.Add(labelMin);
            groupBoxRange.Controls.Add(textBoxMin);
            groupBoxRange.Controls.Add(textBoxMax);
            groupBoxRange.Controls.Add(labelMax);
            groupBoxRange.Location = new Point(12, 236);
            groupBoxRange.Name = "groupBoxRange";
            groupBoxRange.Size = new Size(298, 61);
            groupBoxRange.TabIndex = 15;
            groupBoxRange.TabStop = false;
            groupBoxRange.Text = "Inventory Range";
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Location = new Point(33, 30);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(28, 15);
            labelMin.TabIndex = 16;
            labelMin.Text = "Min";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(805, 416);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 18;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(724, 416);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 19;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // dataGridViewAssoc
            // 
            dataGridViewAssoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAssoc.Location = new Point(337, 238);
            dataGridViewAssoc.Name = "dataGridViewAssoc";
            dataGridViewAssoc.RowHeadersVisible = false;
            dataGridViewAssoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAssoc.Size = new Size(543, 126);
            dataGridViewAssoc.TabIndex = 20;
            // 
            // dataGridViewCand
            // 
            dataGridViewCand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCand.Location = new Point(337, 58);
            dataGridViewCand.Name = "dataGridViewCand";
            dataGridViewCand.RowHeadersVisible = false;
            dataGridViewCand.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCand.Size = new Size(543, 126);
            dataGridViewCand.TabIndex = 21;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(668, 29);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(212, 23);
            textBoxSearch.TabIndex = 22;
            textBoxSearch.KeyUp += partsSearchInput_KeyUp;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(587, 28);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 23;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(805, 190);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 24;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(805, 370);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 25;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelCadndateTable
            // 
            labelCadndateTable.AutoSize = true;
            labelCadndateTable.Location = new Point(337, 40);
            labelCadndateTable.Name = "labelCadndateTable";
            labelCadndateTable.Size = new Size(107, 15);
            labelCadndateTable.TabIndex = 26;
            labelCadndateTable.Text = "All Candidate Parts";
            // 
            // labelAssociatedTable
            // 
            labelAssociatedTable.AutoSize = true;
            labelAssociatedTable.Location = new Point(337, 220);
            labelAssociatedTable.Name = "labelAssociatedTable";
            labelAssociatedTable.Size = new Size(186, 15);
            labelAssociatedTable.TabIndex = 27;
            labelAssociatedTable.Text = "Parts Associated with this Product";
            // 
            // ProductScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 451);
            Controls.Add(labelAssociatedTable);
            Controls.Add(labelCadndateTable);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridViewCand);
            Controls.Add(dataGridViewAssoc);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(groupBoxRange);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxInentory);
            Controls.Add(labelPrice);
            Controls.Add(labelInventory);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelID);
            Controls.Add(textBoxID);
            Controls.Add(labelProduct);
            Name = "ProductScreen";
            Text = "Product";
            groupBoxRange.ResumeLayout(false);
            groupBoxRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCand).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProduct;
        private TextBox textBoxID;
        private Label labelID;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelInventory;
        private Label labelPrice;
        private Label labelMax;
        private TextBox textBoxInentory;
        private TextBox textBoxPrice;
        private TextBox textBoxMin;
        private TextBox textBoxMax;
        private GroupBox groupBoxRange;
        private Label labelMin;
        private Button buttonCancel;
        private Button buttonSave;
        private DataGridView dataGridViewAssoc;
        private DataGridView dataGridViewCand;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonAdd;
        private Button buttonDelete;
        private Label labelCadndateTable;
        private Label labelAssociatedTable;
    }
}