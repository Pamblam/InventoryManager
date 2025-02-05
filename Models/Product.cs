using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager_C968 {
    public class Product {
        public BindingList<Part> AssociatedParts;
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(int productId, string name, decimal price, int inStock, int min, int max) {
            AssociatedParts = new BindingList<Part>();
            ProductId = productId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min; 
            Max = max;
        }

        public void addAssociatedPart(Part part) { 
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(Part part) {   
            return AssociatedParts.Remove(part); 
        }

        public Part? lookupAssociatedPart(int partId) {
            return AssociatedParts.FirstOrDefault(p => p.PartID == partId);
        }

    }
}
