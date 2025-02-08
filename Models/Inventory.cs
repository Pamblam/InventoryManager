using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager_C968 {
    public class Inventory {

        public BindingList<Product> Products;
        public BindingList<Part> AllParts;

        public Inventory() { 
            Products = new BindingList<Product>();
            AllParts = new BindingList<Part>();
        }

        public void addProduct(Product product) { 
            Products.Add(product);  
        }

        public bool removeProduct( Product product) { 
            return Products.Remove(product);
        }

        public Product? lookupProduct(int productId){
            return Products.FirstOrDefault(p => productId == p.ProductId);
        }

        public void updateProduct(int index, Product product) {
            Products[index] = product;
        }

        public void addPart(Part part) { 
            AllParts.Add(part);
        }

        public bool deletePart(Part part) { 
            return AllParts.Remove(part);
        }

        public Part? lookupPart(int partId) {
            return AllParts.FirstOrDefault(p => p.PartID == partId);
        }

        public void updatePart(int index, Part part) {
            AllParts[index] = part;
        }

    }
}
