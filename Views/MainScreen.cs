using System.Diagnostics;
using System.Windows.Forms;
using InventoryManager_C968;

namespace InventoryManager_C968 {
    public partial class MainScreen : Form {

        private Inventory inventory;

        public MainScreen(Inventory inventory) {
            InitializeComponent();
            this.inventory = inventory;
            initPartsTable();
            initProductsTable();
        }

        private void initProductsTable() {
            // Add "Product ID" column
            var col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Product ID";
            col1.DataPropertyName = "ProductID";
            productsTable.Columns.Add(col1);

            // Add "Name" column
            var col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Name";
            col2.DataPropertyName = "Name";
            productsTable.Columns.Add(col2);

            // Add "Inv" column
            var col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Inventory";
            col3.DataPropertyName = "InStock";
            productsTable.Columns.Add(col3);

            // Add "Price" column
            var col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Price";
            col4.DataPropertyName = "Price";
            productsTable.Columns.Add(col4);

            // Add "Min" column
            var col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Min";
            col5.DataPropertyName = "Min";
            productsTable.Columns.Add(col5);

            // Add "Max" column
            var col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Max";
            col6.DataPropertyName = "Max";
            productsTable.Columns.Add(col6);

            productsTable.DataSource = this.inventory.Products;
        }

        /// <summary>
        ///  Initiates the DataGridView for the parts. 
        /// </summary>
        private void initPartsTable() {
            // Add "Part ID" column
            var col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Part ID";
            col1.DataPropertyName = "PartID";
            partsTable.Columns.Add(col1);

            // Add "Name" column
            var col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Name";
            col2.DataPropertyName = "Name";
            partsTable.Columns.Add(col2);

            // Add "Inv" column
            var col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Inventory";
            col3.DataPropertyName = "InStock";
            partsTable.Columns.Add(col3);

            // Add "Price" column
            var col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Price";
            col4.DataPropertyName = "Price";
            partsTable.Columns.Add(col4);

            // Add "Min" column
            var col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Min";
            col5.DataPropertyName = "Min";
            partsTable.Columns.Add(col5);

            // Add "Max" column
            var col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Max";
            col6.DataPropertyName = "Max";
            partsTable.Columns.Add(col6);

            partsTable.DataSource = this.inventory.AllParts;
        }
    }
}
