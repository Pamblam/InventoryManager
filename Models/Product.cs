using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager_C968.Models
{
    internal class Product
    {
        public BindingList<Part> AssociatedParts;
        public int ProductId;
        public string Name;
        public decimal Price;
        public int InStock;
        public int Min;
        public int Max;

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

        public Part lookupAssociatedPart(int partId) {
            return AssociatedParts.First(p => p.PartID == partId);
        }

    }
}
