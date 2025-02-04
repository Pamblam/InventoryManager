using InventoryManager_C968;

namespace InventoryManager_C968{
    public partial class MainScreen : Form {
        private Inventory inventory;

        public MainScreen(Inventory inventory) {
            InitializeComponent();
            this.inventory = inventory;
            partsTable.DataSource = this.inventory.AllParts;
        }

        private void label1_Click(object sender, EventArgs e) {}
    }
}
