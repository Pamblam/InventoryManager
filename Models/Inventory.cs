using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager_C968.Models
{
    internal class Inventory
    {
        public BindingList<Product> Products;
        public BindingList<Part> AllParts;

        public Inventory() { 
            Products = new BindingList<Product>();
            AllParts = new BindingList<Part>();
        }

        void addProduct(Product product) { 
            Products.Add(product);
        }

        bool removeProduct( Product product) { 
            return Products.Remove(product);
        }


    }
}
