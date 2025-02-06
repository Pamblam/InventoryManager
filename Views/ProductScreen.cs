using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager_C968.Views {
    public partial class ProductScreen : Form {

        // The product to be editing, otherwise we're adding a new product
        Product? product; 
        
        public ProductScreen(Product? product = null) {
            InitializeComponent();
            this.product = product;
        }
    }
}
