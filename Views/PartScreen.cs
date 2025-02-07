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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;
using System.IO.Pipelines;

namespace InventoryManager_C968.Views {
    public partial class PartScreen : Form {

        // The product to be editing, otherwise we're adding a new product
        Part? part;
        Inventory inventory;

        public PartScreen(Inventory inventory, Part? part = null) {
            InitializeComponent();
            this.part = part;
            this.inventory = inventory;
            partLabel.Text = part == null ? "Add Part" : "Modify Part";
            textBoxID.ReadOnly = true;

            if (this.part != null) {
                string partType = this.part.GetType().Name;
                radioInhouse.Checked = partType == "InHouse";
                radioOutsourced.Checked = partType == "OutSourced";
                textBoxID.Text = this.part.PartID.ToString();
                textBoxName.Text = this.part.Name;
                textBoxInentory.Text = this.part.InStock.ToString();
                textBoxMin.Text = this.part.Min.ToString();
                textBoxMax.Text = this.part.Max.ToString();
                textBoxPrice.Text = this.part.Price.ToString();
                textBoxMachineID.Text = partType == "InHouse"
                    ? ((InHouse)this.part).MachineId.ToString()
                    : ((OutSourced)this.part).CompanyName;
                labelMachineID.Text = partType == "InHouse" ? "Machine ID" : "Company Name";
            } else {
                Random rand = new Random();
                int fiveDigitNumber = rand.Next(10000, 100000);
                radioInhouse.Checked = true;
                radioOutsourced.Checked = false;
                textBoxID.Text = fiveDigitNumber.ToString();
                labelMachineID.Text = "Machine ID";
            }
        }


        private void partType_CheckedChanged(object sender, EventArgs e) {
            labelMachineID.Text = radioInhouse.Checked ? "Machine ID" : "Company Name";
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            string partType = radioInhouse.Checked ? "InHouse" : "OutSourced";
            int id = int.Parse(textBoxID.Text);

            List<string> errors = new List<string>();

            string name = textBoxName.Text;
            if (string.IsNullOrWhiteSpace(name)) {
                textBoxName.BackColor = Color.Red;
                errors.Add("Must enter a name.");
            } else {
                textBoxName.BackColor = SystemColors.Window;
            }

            int inventory = 0;
            if (string.IsNullOrWhiteSpace(textBoxInentory.Text)) {
                errors.Add("Must enter an inventory value.");
                textBoxInentory.BackColor = Color.Red;
            } else if (!int.TryParse(textBoxInentory.Text, out inventory)) {
                errors.Add("Must enter a numeric inventory value.");
                textBoxInentory.BackColor = Color.Red;
            } else {
                textBoxInentory.BackColor = SystemColors.Window;
            }

            int min = 0;
            if (string.IsNullOrWhiteSpace(textBoxMin.Text)) {
                errors.Add("Must enter an minimum quantity.");
                textBoxMin.BackColor = Color.Red;
            } else if (!int.TryParse(textBoxMin.Text, out min)) {
                errors.Add("Must enter a numeric minimum quantity.");
                textBoxMin.BackColor = Color.Red;
            } else {
                textBoxMin.BackColor = SystemColors.Window;
            }

            int max = 0;
            if (string.IsNullOrWhiteSpace(textBoxMax.Text)) {
                errors.Add("Must enter an maximum quantity.");
                textBoxMax.BackColor = Color.Red;
            } else if (!int.TryParse(textBoxMax.Text, out max)) {
                errors.Add("Must enter a numeric maximum quantity.");
                textBoxMax.BackColor = Color.Red;
            } else if (min > max) {
                errors.Add("Maximum must be greater than minimum quantity.");
                textBoxMax.BackColor = Color.Red;
                textBoxMin.BackColor = Color.Red;
            } else {
                textBoxMax.BackColor = SystemColors.Window;
            }

            decimal price = 0;
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text)) {
                errors.Add("Must enter a price.");
                textBoxPrice.BackColor = Color.Red;
            } else if (!decimal.TryParse(textBoxPrice.Text, out price)) {
                errors.Add("Must enter a numeric price.");
                textBoxPrice.BackColor = Color.Red;
            } else {
                textBoxPrice.BackColor = SystemColors.Window;
            }

            int machineId = 0;
            string companyName = "";
            if (partType == "InHouse") {

                if (string.IsNullOrWhiteSpace(textBoxMachineID.Text)) {
                    errors.Add("Must enter a Machine ID.");
                    textBoxMachineID.BackColor = Color.Red;
                } else if (!int.TryParse(textBoxMachineID.Text, out machineId)) {
                    errors.Add("Must enter a numeric Machine ID.");
                    textBoxMachineID.BackColor = Color.Red;
                } else {
                    textBoxMachineID.BackColor = SystemColors.Window;
                }

            } else {

                companyName = textBoxMachineID.Text;
                if (string.IsNullOrWhiteSpace(companyName)) {
                    textBoxMachineID.BackColor = Color.Red;
                    errors.Add("Must enter a company name.");
                } else {
                    textBoxMachineID.BackColor = SystemColors.Window;
                }

            }


            if (errors.Count > 0) {
                MessageBox.Show(string.Join("\n", errors), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (this.part != null) {

                if (partType == "InHouse") ((InHouse)this.part).MachineId = machineId;
                else ((OutSourced)this.part).CompanyName = companyName;
                this.part.PartID = id;
                this.part.Name = name;
                this.part.Price = price;
                this.part.InStock = inventory;
                this.part.Min = min;
                this.part.Max = max;

            } else {

                Part newPart;
                if (partType == "InHouse") {
                    newPart = new InHouse(machineId, id, name, price, inventory, min, max);
                } else {
                    newPart = new OutSourced(companyName, id, name, price, inventory, min, max);
                }
                this.inventory.addPart(newPart);

            }

            this.Close();
        }
            
    }
}
