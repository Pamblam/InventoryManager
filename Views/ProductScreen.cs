using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager_C968.Views {
    public partial class ProductScreen : Form {

        // The product to be editing, otherwise we're adding a new product
        Product? product;
        Inventory inventory;
        BindingList<Part> associatedParts = new BindingList<Part>();
        List<Part> removedParts = new List<Part>();

        public ProductScreen(Inventory inventory, Product? product = null) {
            InitializeComponent();
            this.product = product;
            this.inventory = inventory;
            labelProduct.Text = product == null ? "Add Product" : "Modify Product";
            textBoxID.ReadOnly = true;

            if (this.product != null) {
                textBoxID.Text = this.product.ProductId.ToString();
                textBoxName.Text = this.product.Name;
                textBoxInentory.Text = this.product.InStock.ToString();
                textBoxMin.Text = this.product.Min.ToString();
                textBoxMax.Text = this.product.Max.ToString();
                textBoxPrice.Text = this.product.Price.ToString();
                foreach (Part p in this.product.AssociatedParts) {
                    this.associatedParts.Add(p);
                }
            } else {
                Random rand = new Random();
                int fiveDigitNumber = rand.Next(10000, 100000);
                textBoxID.Text = fiveDigitNumber.ToString();
            }

            initCandidatePartsTable();
            initAssociatedPartsTable();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void initCandidatePartsTable() {
            // Add "Part ID" column
            var col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Part ID";
            col1.Name = "PartID";
            col1.DataPropertyName = "PartID";
            dataGridViewCand.Columns.Add(col1);

            // Add "Name" column
            var col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Name";
            col2.Name = "Name";
            col2.DataPropertyName = "Name";
            dataGridViewCand.Columns.Add(col2);

            // Add "Inv" column
            var col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Inventory";
            col3.Name = "InStock";
            col3.DataPropertyName = "InStock";
            dataGridViewCand.Columns.Add(col3);

            // Add "Price" column
            var col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Price";
            col4.Name = "Price";
            col4.DataPropertyName = "Price";
            dataGridViewCand.Columns.Add(col4);

            // Add "Min" column
            var col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Min";
            col5.Name = "Min";
            col5.DataPropertyName = "Min";
            dataGridViewCand.Columns.Add(col5);

            // Add "Max" column
            var col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Max";
            col6.Name = "Max";
            col6.DataPropertyName = "Max";
            dataGridViewCand.Columns.Add(col6);

            dataGridViewCand.MultiSelect = false;
            dataGridViewCand.AllowUserToResizeColumns = false;
            dataGridViewCand.AllowUserToResizeRows = false;
            dataGridViewCand.ReadOnly = true;

            loadCandidatePartsTable();
        }

        private void initAssociatedPartsTable() {
            // Add "Part ID" column
            var col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Part ID";
            col1.Name = "PartID";
            col1.DataPropertyName = "PartID";
            dataGridViewAssoc.Columns.Add(col1);

            // Add "Name" column
            var col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Name";
            col2.Name = "Name";
            col2.DataPropertyName = "Name";
            dataGridViewAssoc.Columns.Add(col2);

            // Add "Inv" column
            var col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Inventory";
            col3.Name = "InStock";
            col3.DataPropertyName = "InStock";
            dataGridViewAssoc.Columns.Add(col3);

            // Add "Price" column
            var col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Price";
            col4.Name = "Price";
            col4.DataPropertyName = "Price";
            dataGridViewAssoc.Columns.Add(col4);

            // Add "Min" column
            var col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Min";
            col5.Name = "Min";
            col5.DataPropertyName = "Min";
            dataGridViewAssoc.Columns.Add(col5);

            // Add "Max" column
            var col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Max";
            col6.Name = "Max";
            col6.DataPropertyName = "Max";
            dataGridViewAssoc.Columns.Add(col6);

            dataGridViewAssoc.MultiSelect = false;
            dataGridViewAssoc.AllowUserToResizeColumns = false;
            dataGridViewAssoc.AllowUserToResizeRows = false;
            dataGridViewAssoc.ReadOnly = true;

            loadAssociatedPartsTable();
        }

        private void loadAssociatedPartsTable() {
            var searchTerm = textBoxSearch.Text;
            var filteredRows = new BindingList<Part>();
            foreach (Part part in this.associatedParts) {
                filteredRows.Add(part);
            }
            dataGridViewAssoc.DataSource = filteredRows;
        }

        private void loadCandidatePartsTable() {
            var searchTerm = textBoxSearch.Text;
            var filteredRows = new BindingList<Part>();
            foreach (Part part in inventory.AllParts) {
                var partId = part.PartID;
                var partName = part.Name;
                bool matches =
                    searchTerm == "" ||
                    (Convert.ToString(partId).Contains(searchTerm, StringComparison.OrdinalIgnoreCase)) ||
                    (partName != null && Convert.ToString(partName).Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
                if (matches && !this.associatedParts.Contains(part)) {
                    filteredRows.Add(part);
                }
            }
            dataGridViewCand.DataSource = filteredRows;
        }

        private void buttonSearch_Click(object sender, EventArgs e) {
            loadCandidatePartsTable();
        }

        private void partsSearchInput_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                loadCandidatePartsTable();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            Part? part = getSelectedCandidatePart();
            if (part != null) {
                if (removedParts.Contains(part)) {
                    removedParts.Remove(part);
                }
                associatedParts.Add(part);
                loadCandidatePartsTable();
                loadAssociatedPartsTable();
            }
        }

        private Part? getSelectedCandidatePart() {
            if (dataGridViewCand.SelectedRows.Count > 0) {
                DataGridViewRow selectedRow = dataGridViewCand.SelectedRows[0];
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

        private Part? getSelectedAssociatedPart() {
            if (dataGridViewAssoc.SelectedRows.Count > 0) {
                DataGridViewRow selectedRow = dataGridViewAssoc.SelectedRows[0];
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

        private void buttonDelete_Click(object sender, EventArgs e) {
            Part? part = getSelectedAssociatedPart();
            if (part != null) {
                var parts = new BindingList<Part>();
                foreach (Part p in this.associatedParts) {
                    if (p != part) {
                        parts.Add(p);
                    }
                }
                if (!removedParts.Contains(part)) {
                    removedParts.Add(part);
                }
                this.associatedParts = parts;
                loadCandidatePartsTable();
                loadAssociatedPartsTable();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            int id = int.Parse(textBoxID.Text);

            List<string> errors = new List<string>();

            string name = textBoxName.Text;
            if (string.IsNullOrWhiteSpace(name)) {
                textBoxName.BackColor = Color.Red;
                errors.Add("Must enter a name.");
            } else {
                textBoxName.BackColor = SystemColors.Window;
            }

            int inventory = 0;
            if (string.IsNullOrWhiteSpace(textBoxInentory.Text)) {
                errors.Add("Must enter an inventory value.");
                textBoxInentory.BackColor = Color.Red;
            } else if (!int.TryParse(textBoxInentory.Text, out inventory)) {
                errors.Add("Must enter a numeric inventory value.");
                textBoxInentory.BackColor = Color.Red;
            } else {
                textBoxInentory.BackColor = SystemColors.Window;
            }

            int min = 0;
            if (string.IsNullOrWhiteSpace(textBoxMin.Text)) {
                errors.Add("Must enter an minimum quantity.");
                textBoxMin.BackColor = Color.Red;
            } else if (!int.TryParse(textBoxMin.Text, out min)) {
                errors.Add("Must enter a numeric minimum quantity.");
                textBoxMin.BackColor = Color.Red;
            } else {
                textBoxMin.BackColor = SystemColors.Window;
            }

            int max = 0;
            if (string.IsNullOrWhiteSpace(textBoxMax.Text)) {
                errors.Add("Must enter an maximum quantity.");
                textBoxMax.BackColor = Color.Red;
            } else if (!int.TryParse(textBoxMax.Text, out max)) {
                errors.Add("Must enter a numeric maximum quantity.");
                textBoxMax.BackColor = Color.Red;
            } else if (min > max) {
                errors.Add("Maximum must be greater than minimum quantity.");
                textBoxMax.BackColor = Color.Red;
                textBoxMin.BackColor = Color.Red;
            } else if (min > inventory || max < inventory) {
                errors.Add("Inventory must be between within acceptable range.");
                textBoxInentory.BackColor = Color.Red;
            } else {
                textBoxMax.BackColor = SystemColors.Window;
            }

            decimal price = 0;
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text)) {
                errors.Add("Must enter a price.");
                textBoxPrice.BackColor = Color.Red;
            } else if (!decimal.TryParse(textBoxPrice.Text, out price)) {
                errors.Add("Must enter a numeric price.");
                textBoxPrice.BackColor = Color.Red;
            } else {
                textBoxPrice.BackColor = SystemColors.Window;
            }

            if (errors.Count > 0) {
                MessageBox.Show(string.Join("\n", errors), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Product p;
            if (this.product != null) {

                p = this.product;
                p.ProductId = id;
                p.Name = name;
                p.Price = price;
                p.InStock = inventory;
                p.Min = min;
                p.Max = max;
                p.AssociatedParts = this.associatedParts;

            } else {

                p = new Product(id, name, price, inventory, min, max);
                p.AssociatedParts = this.associatedParts;
                this.inventory.addProduct(p);

            }

            foreach (Part pt in removedParts) { 
                pt.AssociatedProductIds.Remove(p.ProductId);
            }

            foreach (Part pt in p.AssociatedParts) {
                if (!pt.AssociatedProductIds.Contains(p.ProductId)) {
                    pt.AssociatedProductIds.Add(p.ProductId);
                }
            }


            this.Close();
        }
    }
}
