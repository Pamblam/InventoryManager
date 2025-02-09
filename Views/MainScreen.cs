using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using InventoryManager_C968;
using InventoryManager_C968.Views;
using static System.Windows.Forms.DataFormats;

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
            col1.Name = "ProductID";
            col1.DataPropertyName = "ProductID";
            productsTable.Columns.Add(col1);

            // Add "Name" column
            var col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Name";
            col2.Name = "Name";
            col2.DataPropertyName = "Name";
            productsTable.Columns.Add(col2);

            // Add "Inv" column
            var col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Inventory";
            col3.Name = "InStock";
            col3.DataPropertyName = "InStock";
            productsTable.Columns.Add(col3);

            // Add "Price" column
            var col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Price";
            col4.Name = "Price";
            col4.DataPropertyName = "Price";
            productsTable.Columns.Add(col4);

            // Add "Min" column
            var col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Min";
            col5.Name = "Min";
            col5.DataPropertyName = "Min";
            productsTable.Columns.Add(col5);

            // Add "Max" column
            var col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Max";
            col6.Name = "Max";
            col6.DataPropertyName = "Max";
            productsTable.Columns.Add(col6);

            productsTable.MultiSelect = false;
            productsTable.AllowUserToResizeColumns = false;
            productsTable.AllowUserToResizeRows = false;
            productsTable.ReadOnly = true;
            productsTable.DataSource = this.inventory.Products;
        }

        /// <summary>
        ///  Initiates the DataGridView for the parts. 
        /// </summary>
        private void initPartsTable() {
            // Add "Part ID" column
            var col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Part ID";
            col1.Name = "PartID";
            col1.DataPropertyName = "PartID";
            partsTable.Columns.Add(col1);

            // Add "Name" column
            var col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Name";
            col2.Name = "Name";
            col2.DataPropertyName = "Name";
            partsTable.Columns.Add(col2);

            // Add "Inv" column
            var col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Inventory";
            col3.Name = "InStock";
            col3.DataPropertyName = "InStock";
            partsTable.Columns.Add(col3);

            // Add "Price" column
            var col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Price";
            col4.Name = "Price";
            col4.DataPropertyName = "Price";
            partsTable.Columns.Add(col4);

            // Add "Min" column
            var col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Min";
            col5.Name = "Min";
            col5.DataPropertyName = "Min";
            partsTable.Columns.Add(col5);

            // Add "Max" column
            var col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Max";
            col6.Name = "Max";
            col6.DataPropertyName = "Max";
            partsTable.Columns.Add(col6);

            partsTable.MultiSelect = false;
            partsTable.AllowUserToResizeColumns = false;
            partsTable.AllowUserToResizeRows = false;
            partsTable.ReadOnly = true;
            partsTable.DataSource = this.inventory.AllParts;
        }

        private void searchPartsTable() {
            var searchTerm = partsSearchInput.Text;
            var filteredRows = new BindingList<Part>();
            foreach (Part part in inventory.AllParts) {
                var partId = part.PartID;
                var partName = part.Name;
                bool matches =
                    searchTerm == "" ||
                    (Convert.ToString(partId).Contains(searchTerm, StringComparison.OrdinalIgnoreCase)) ||
                    (partName != null && Convert.ToString(partName).Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
                if (matches) {
                    filteredRows.Add(part);
                }
            }
            partsTable.DataSource = filteredRows;
        }

        private void partsSearchBtn_Click(object sender, EventArgs e) {
            searchPartsTable();
        }

        private void partsSearchInput_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                searchPartsTable();
            }
        }

        private void ProductScreen_FormClosed(object sender, EventArgs e) {
            searchProductsTable();
        }

        private void PartScreen_FormClosed(object sender, EventArgs e) {
            searchPartsTable();
        }

        private void searchProductsTable() {
            var searchTerm = productSearchInput.Text;
            var filteredRows = new BindingList<Product>();
            foreach (Product product in inventory.Products) {
                var productId = product.ProductId;
                var partName = product.Name;
                bool matches =
                    searchTerm == "" ||
                    (Convert.ToString(productId).Contains(searchTerm, StringComparison.OrdinalIgnoreCase)) ||
                    (partName != null && Convert.ToString(partName).Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
                if (matches) {
                    filteredRows.Add(product);
                }
            }
            productsTable.DataSource = filteredRows;
        }

        private void productsSearchBtn_Click(object sender, EventArgs e) {
            searchProductsTable();
        }

        private void productSearchInput_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                searchProductsTable();
            }
        }

        private void partsDeleteBtn_Click(object sender, EventArgs e) {
            Part part = getSelectedPart();
            if (part != null) {
                if (part.AssociatedProductIds.Count > 0) {
                    MessageBox.Show($"Product cannot be deleted. It is associated with {part.AssociatedProductIds.Count} product(s).", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) {
                        this.inventory.deletePart(part);
                        searchPartsTable();
                    }
                }
            }
        }

        private void productsDeleteBtn_Click(object sender, EventArgs e) {
            Product? product = getSelectedProduct();
            if (product != null) {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    this.inventory.removeProduct(product);
                    searchProductsTable();
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void partsAddBtn_Click(object sender, EventArgs e) {
            PartScreen screen = new PartScreen(this.inventory);
            screen.FormClosed += PartScreen_FormClosed;
            screen.ShowDialog();
        }

        private void productsAddBtn_Click(object sender, EventArgs e) {
            ProductScreen screen = new ProductScreen(this.inventory);
            screen.FormClosed += ProductScreen_FormClosed;
            screen.ShowDialog();
        }

        private void partsModifyBtn_Click(object sender, EventArgs e) {
            Part? part = getSelectedPart();
            if (part != null) {
                PartScreen screen = new PartScreen(this.inventory, part);
                screen.FormClosed += PartScreen_FormClosed; 
                screen.ShowDialog();
            }
        }

        private Part? getSelectedPart() {
            if (partsTable.SelectedRows.Count > 0) {
                DataGridViewRow selectedRow = partsTable.SelectedRows[0];
                var partId = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
                foreach (Part part in this.inventory.AllParts) {
                    if (partId == part.PartID) {
                        return part;
                    }
                }
            }
            MessageBox.Show("No part selected.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }

        private Product? getSelectedProduct() {
            if (productsTable.SelectedRows.Count > 0) {
                DataGridViewRow selectedRow = productsTable.SelectedRows[0];
                var productId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                foreach (Product product in this.inventory.Products) {
                    if (productId == product.ProductId) {
                        return product;
                    }
                }
            }
            MessageBox.Show("No product selected.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }

        private void productModifyBtn_Click(object sender, EventArgs e) {
            Product? product = getSelectedProduct();
            if (product != null) {
                ProductScreen screen = new ProductScreen(this.inventory, product);
                screen.FormClosed += ProductScreen_FormClosed;
                screen.ShowDialog();
            }
        }
    }
}
