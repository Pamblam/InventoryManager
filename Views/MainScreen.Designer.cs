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
        private void InitializeComponent()
        {
            headerLabel = new Label();
            tableContainer = new TableLayoutPanel();
            partsTable = new DataGridView();
            tableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)partsTable).BeginInit();
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
            headerLabel.Click += label1_Click;
            // 
            // tableContainer
            // 
            tableContainer.ColumnCount = 2;
            tableContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableContainer.Controls.Add(partsTable, 0, 0);
            tableContainer.Location = new Point(12, 58);
            tableContainer.Name = "tableContainer";
            tableContainer.RowCount = 1;
            tableContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableContainer.Size = new Size(776, 245);
            tableContainer.TabIndex = 1;
            // 
            // partsTable
            // 
            partsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsTable.Dock = DockStyle.Fill;
            partsTable.Location = new Point(3, 3);
            partsTable.Name = "partsTable";
            partsTable.Size = new Size(382, 239);
            partsTable.TabIndex = 0;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableContainer);
            Controls.Add(headerLabel);
            Name = "MainScreen";
            Text = "Main Screen";
            tableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)partsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TableLayoutPanel tableContainer;
        private DataGridView partsTable;
    }
}
