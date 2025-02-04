using System.Diagnostics;
using InventoryManager_C968;

namespace InventoryManager_C968{
    public partial class MainScreen : Form {
        private Inventory inventory;

        public MainScreen(Inventory inventory) {
            InitializeComponent();
            this.inventory = inventory;

            Debug.WriteLine($"Parts Count: {this.inventory.AllParts.Count}");
            foreach (DataGridViewColumn column in partsTable.Columns)
            {
                Debug.WriteLine(column.DataPropertyName);
            }


            partsTable.DataSource = this.inventory.AllParts;
            partsTable.AutoGenerateColumns = true;
        }

        private void label1_Click(object sender, EventArgs e) {}
    }
}
