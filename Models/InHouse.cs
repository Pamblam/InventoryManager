using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager_C968 {
    internal class InHouse : Part {
        public int MachineId { get; set; }

        public InHouse(int machineId, int partID, string name, decimal price, int inStock, int min, int max) {
            MachineId = machineId;
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
    }
}
