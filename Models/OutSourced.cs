using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventoryManager_C968 {
    public class OutSourced : Part {
        public string CompanyName { get; set; }

        public OutSourced(String companyName, int partID, string name, decimal price, int inStock, int min, int max) {
            CompanyName = companyName;
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
    }
}
