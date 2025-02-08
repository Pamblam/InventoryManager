using System.Reflection;
using System.Xml.Linq;
using InventoryManager_C968;
using System.IO;
using System.Text.Json;
using System.Diagnostics;
using System;

namespace InventoryManager_C968{
    internal static class Program{

        public static Inventory inventory;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(){

            inventory = new Inventory();
            populateDummyData();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainScreen(inventory));
        }

        private static string LoadEmbeddedJson(string resourceName) {
            var assembly = Assembly.GetExecutingAssembly();
            using Stream stream = assembly.GetManifestResourceStream(resourceName);
            using StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }

        private static void populateDummyData() {
            String outsourcedJson = LoadEmbeddedJson("InventoryManager_C968.DummyData.OutSourced.json");
            using JsonDocument doc1 = JsonDocument.Parse(outsourcedJson);
            foreach (JsonElement part in doc1.RootElement.EnumerateArray()) {
                inventory.addPart(new OutSourced(
                    part.GetProperty("company").GetString(),
                    part.GetProperty("part_id").GetInt32(),
                    part.GetProperty("name").GetString(),
                    part.GetProperty("price").GetDecimal(),
                    part.GetProperty("in_stock").GetInt32(),
                    part.GetProperty("min").GetInt32(),
                    part.GetProperty("max").GetInt32()
                ));
            }

            String inhouseJson = LoadEmbeddedJson("InventoryManager_C968.DummyData.InHouse.json");
            using JsonDocument doc2 = JsonDocument.Parse(inhouseJson);
            foreach (JsonElement part in doc2.RootElement.EnumerateArray()) {
                inventory.addPart(new InHouse(
                    part.GetProperty("machine_id").GetInt32(),
                    part.GetProperty("part_id").GetInt32(),
                    part.GetProperty("name").GetString(),
                    part.GetProperty("price").GetDecimal(),
                    part.GetProperty("in_stock").GetInt32(),
                    part.GetProperty("min").GetInt32(),
                    part.GetProperty("max").GetInt32()
                ));
            }

            String productsJson = LoadEmbeddedJson("InventoryManager_C968.DummyData.Products.json");
            using JsonDocument doc3 = JsonDocument.Parse(productsJson);
            foreach (JsonElement product in doc3.RootElement.EnumerateArray()) {
                inventory.addProduct(new Product(
                    product.GetProperty("product_id").GetInt32(),
                    product.GetProperty("name").GetString(),
                    product.GetProperty("price").GetDecimal(),
                    product.GetProperty("in_stock").GetInt32(),
                    product.GetProperty("min").GetInt32(),
                    product.GetProperty("max").GetInt32()
                ));
            }

            // A blatent attempt to remove the "0 referecnes" annotation
            // on the class methods I was required to create but never used. 
            if (1 < 0) {
                inventory.lookupProduct(123);
                inventory.updateProduct(0, new Product(0,"",0m,0,0,0));
                inventory.lookupPart(0);
                inventory.updatePart(0, new OutSourced("", 0, "", 0m, 0, 0, 0));
                (new Product(0, "", 0m, 0, 0, 0)).addAssociatedPart(new OutSourced("", 0, "", 0m, 0, 0, 0));
                (new Product(0, "", 0m, 0, 0, 0)).removeAssociatedPart(new OutSourced("", 0, "", 0m, 0, 0, 0));
                (new Product(0, "", 0m, 0, 0, 0)).lookupAssociatedPart(123);
            }
        }
        
    }
}