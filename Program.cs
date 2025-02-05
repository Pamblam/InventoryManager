using System.Xml.Linq;
using InventoryManager_C968;

namespace InventoryManager_C968{
    internal static class Program{

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(){

            Inventory inventory = new Inventory();
            inventory.addPart(new OutSourced("Bobco Inc", 12345, "Seat", 19.99m, 3, 1, 3));
            inventory.addPart(new OutSourced("Bobco Inc", 12346, "Chain", 10.99m, 3, 1, 3));
            inventory.addPart(new OutSourced("Bobco Inc", 12347, "Cup Holder", 15.75m, 3, 1, 3));
            inventory.addPart(new InHouse(11234, 12348, "Tire", 30.00m, 15, 5, 25));
            inventory.addPart(new InHouse(11235, 12349, "Inner Tube", 35.50m, 14, 10, 30));

            inventory.addProduct(new Product(4535, "Bicycle", 199.23m, 8, 2, 20));
            inventory.addProduct(new Product(4566, "Helmet", 19.00m, 10, 10, 25));
            inventory.addProduct(new Product(4565, "Hat", 19.00m, 10, 10, 25));

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainScreen(inventory));
        }
    }
}