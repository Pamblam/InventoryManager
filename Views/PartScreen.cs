using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager_C968.Views {
    public partial class PartScreen : Form {

        // The product to be editing, otherwise we're adding a new product
        Part? part;

        public PartScreen(Part? part = null) {
            InitializeComponent();
            this.part = part;
            partLabel.Text = part == null ? "Add Part" : "Modify Part";
        }

        private void PartScreen_Load(object sender, EventArgs e) {

        }
    }
}
