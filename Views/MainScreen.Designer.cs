namespace InventoryManager_C968 {
    partial class MainScreen {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            headerLabel = new Label();
            partsTable = new DataGridView();
            productsTable = new DataGridView();
            partsSearchInput = new TextBox();
            productSearchInput = new TextBox();
            partsSearchBtn = new Button();
            productsSearchBtn = new Button();
            partsLabel = new Label();
            productsLabel = new Label();
            partsDeleteBtn = new Button();
            partsModifyBtn = new Button();
            partsAddBtn = new Button();
            productsDeleteBtn = new Button();
            productModifyBtn = new Button();
            productsAddBtn = new Button();
            exitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)partsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsTable).BeginInit();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.FlatStyle = FlatStyle.Flat;
            headerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(250, 21);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Inventory Management System";
            // 
            // partsTable
            // 
            partsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsTable.Location = new Point(12, 77);
            partsTable.Name = "partsTable";
            partsTable.RowHeadersVisible = false;
            partsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsTable.Size = new Size(579, 360);
            partsTable.TabIndex = 1;
            // 
            // productsTable
            // 
            productsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsTable.Location = new Point(615, 77);
            productsTable.Name = "productsTable";
            productsTable.RowHeadersVisible = false;
            productsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsTable.Size = new Size(579, 360);
            productsTable.TabIndex = 2;
            // 
            // partsSearchInput
            // 
            partsSearchInput.Location = new Point(309, 48);
            partsSearchInput.Name = "partsSearchInput";
            partsSearchInput.Size = new Size(282, 23);
            partsSearchInput.TabIndex = 3;
            partsSearchInput.KeyUp += partsSearchInput_KeyUp;
            // 
            // productSearchInput
            // 
            productSearchInput.Location = new Point(912, 48);
            productSearchInput.Name = "productSearchInput";
            productSearchInput.Size = new Size(282, 23);
            productSearchInput.TabIndex = 4;
            productSearchInput.KeyUp += productSearchInput_KeyUp;
            // 
            // partsSearchBtn
            // 
            partsSearchBtn.Location = new Point(228, 48);
            partsSearchBtn.Name = "partsSearchBtn";
            partsSearchBtn.Size = new Size(75, 23);
            partsSearchBtn.TabIndex = 5;
            partsSearchBtn.Text = "Search";
            partsSearchBtn.UseVisualStyleBackColor = true;
            partsSearchBtn.Click += partsSearchBtn_Click;
            // 
            // productsSearchBtn
            // 
            productsSearchBtn.Location = new Point(831, 48);
            productsSearchBtn.Name = "productsSearchBtn";
            productsSearchBtn.Size = new Size(75, 23);
            productsSearchBtn.TabIndex = 6;
            productsSearchBtn.Text = "Search";
            productsSearchBtn.UseVisualStyleBackColor = true;
            productsSearchBtn.Click += productsSearchBtn_Click;
            // 
            // partsLabel
            // 
            partsLabel.AutoSize = true;
            partsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            partsLabel.Location = new Point(12, 52);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new Size(35, 15);
            partsLabel.TabIndex = 7;
            partsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            productsLabel.AutoSize = true;
            productsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productsLabel.Location = new Point(615, 52);
            productsLabel.Name = "productsLabel";
            productsLabel.Size = new Size(56, 15);
            productsLabel.TabIndex = 8;
            productsLabel.Text = "Products";
            // 
            // partsDeleteBtn
            // 
            partsDeleteBtn.Location = new Point(516, 443);
            partsDeleteBtn.Name = "partsDeleteBtn";
            partsDeleteBtn.Size = new Size(75, 23);
            partsDeleteBtn.TabIndex = 9;
            partsDeleteBtn.Text = "Delete";
            partsDeleteBtn.UseVisualStyleBackColor = true;
            partsDeleteBtn.Click += partsDeleteBtn_Click;
            // 
            // partsModifyBtn
            // 
            partsModifyBtn.Location = new Point(435, 443);
            partsModifyBtn.Name = "partsModifyBtn";
            partsModifyBtn.Size = new Size(75, 23);
            partsModifyBtn.TabIndex = 10;
            partsModifyBtn.Text = "Modify";
            partsModifyBtn.UseVisualStyleBackColor = true;
            partsModifyBtn.Click += partsModifyBtn_Click;
            // 
            // partsAddBtn
            // 
            partsAddBtn.Location = new Point(354, 443);
            partsAddBtn.Name = "partsAddBtn";
            partsAddBtn.Size = new Size(75, 23);
            partsAddBtn.TabIndex = 11;
            partsAddBtn.Text = "Add";
            partsAddBtn.UseVisualStyleBackColor = true;
            partsAddBtn.Click += partsAddBtn_Click;
            // 
            // productsDeleteBtn
            // 
            productsDeleteBtn.Location = new Point(1119, 443);
            productsDeleteBtn.Name = "productsDeleteBtn";
            productsDeleteBtn.Size = new Size(75, 23);
            productsDeleteBtn.TabIndex = 12;
            productsDeleteBtn.Text = "Delete";
            productsDeleteBtn.UseVisualStyleBackColor = true;
            productsDeleteBtn.Click += productsDeleteBtn_Click;
            // 
            // productModifyBtn
            // 
            productModifyBtn.Location = new Point(1038, 443);
            productModifyBtn.Name = "productModifyBtn";
            productModifyBtn.Size = new Size(75, 23);
            productModifyBtn.TabIndex = 13;
            productModifyBtn.Text = "Modify";
            productModifyBtn.UseVisualStyleBackColor = true;
            productModifyBtn.Click += productModifyBtn_Click;
            // 
            // productsAddBtn
            // 
            productsAddBtn.Location = new Point(957, 443);
            productsAddBtn.Name = "productsAddBtn";
            productsAddBtn.Size = new Size(75, 23);
            productsAddBtn.TabIndex = 14;
            productsAddBtn.Text = "Add";
            productsAddBtn.UseVisualStyleBackColor = true;
            productsAddBtn.Click += productsAddBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(1123, 472);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 23);
            exitBtn.TabIndex = 15;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 507);
            Controls.Add(exitBtn);
            Controls.Add(productsAddBtn);
            Controls.Add(productModifyBtn);
            Controls.Add(productsDeleteBtn);
            Controls.Add(partsAddBtn);
            Controls.Add(partsModifyBtn);
            Controls.Add(partsDeleteBtn);
            Controls.Add(productsLabel);
            Controls.Add(partsLabel);
            Controls.Add(productsSearchBtn);
            Controls.Add(partsSearchBtn);
            Controls.Add(productSearchInput);
            Controls.Add(partsSearchInput);
            Controls.Add(productsTable);
            Controls.Add(partsTable);
            Controls.Add(headerLabel);
            MinimumSize = new Size(1226, 546);
            Name = "MainScreen";
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)partsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private DataGridView partsTable;
        private DataGridView productsTable;
        private TextBox partsSearchInput;
        private TextBox productSearchInput;
        private Button partsSearchBtn;
        private Button productsSearchBtn;
        private Label partsLabel;
        private Label productsLabel;
        private Button partsDeleteBtn;
        private Button partsModifyBtn;
        private Button partsAddBtn;
        private Button productsDeleteBtn;
        private Button productModifyBtn;
        private Button productsAddBtn;
        private Button exitBtn;
    }
}