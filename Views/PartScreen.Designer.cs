namespace InventoryManager_C968.Views {
    partial class PartScreen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            partLabel = new Label();
            radioInhouse = new RadioButton();
            timer1 = new System.Windows.Forms.Timer(components);
            radioOutoourced = new RadioButton();
            groupBoxPartType = new GroupBox();
            textBoxID = new TextBox();
            labelID = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            labelInventory = new Label();
            labelPrice = new Label();
            labelMax = new Label();
            textBoxInentory = new TextBox();
            textBoxPrice = new TextBox();
            textBoxMin = new TextBox();
            textBoxMax = new TextBox();
            groupBoxRange = new GroupBox();
            labelMin = new Label();
            labelMachineID = new Label();
            textBoxMachineID = new TextBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            groupBoxPartType.SuspendLayout();
            groupBoxRange.SuspendLayout();
            SuspendLayout();
            // 
            // partLabel
            // 
            partLabel.AutoSize = true;
            partLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            partLabel.Location = new Point(12, 9);
            partLabel.Name = "partLabel";
            partLabel.Size = new Size(41, 21);
            partLabel.TabIndex = 0;
            partLabel.Text = "Part";
            // 
            // radioInhouse
            // 
            radioInhouse.AutoSize = true;
            radioInhouse.Location = new Point(41, 22);
            radioInhouse.Name = "radioInhouse";
            radioInhouse.Size = new Size(74, 19);
            radioInhouse.TabIndex = 1;
            radioInhouse.TabStop = true;
            radioInhouse.Text = "In-House";
            radioInhouse.UseVisualStyleBackColor = true;
            // 
            // radioOutoourced
            // 
            radioOutoourced.AutoSize = true;
            radioOutoourced.Location = new Point(168, 22);
            radioOutoourced.Name = "radioOutoourced";
            radioOutoourced.Size = new Size(91, 19);
            radioOutoourced.TabIndex = 2;
            radioOutoourced.TabStop = true;
            radioOutoourced.Text = "Out Sourced";
            radioOutoourced.UseVisualStyleBackColor = true;
            // 
            // groupBoxPartType
            // 
            groupBoxPartType.Controls.Add(radioInhouse);
            groupBoxPartType.Controls.Add(radioOutoourced);
            groupBoxPartType.Location = new Point(12, 33);
            groupBoxPartType.Name = "groupBoxPartType";
            groupBoxPartType.Size = new Size(298, 51);
            groupBoxPartType.TabIndex = 3;
            groupBoxPartType.TabStop = false;
            groupBoxPartType.Text = "Part Type";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(125, 104);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(185, 23);
            textBoxID.TabIndex = 4;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(12, 112);
            labelID.Name = "labelID";
            labelID.Size = new Size(18, 15);
            labelID.TabIndex = 5;
            labelID.Text = "ID";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(125, 133);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(185, 23);
            textBoxName.TabIndex = 6;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 141);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 7;
            labelName.Text = "Name";
            // 
            // labelInventory
            // 
            labelInventory.AutoSize = true;
            labelInventory.Location = new Point(12, 170);
            labelInventory.Name = "labelInventory";
            labelInventory.Size = new Size(57, 15);
            labelInventory.TabIndex = 8;
            labelInventory.Text = "Inventory";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(12, 199);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(68, 15);
            labelPrice.TabIndex = 9;
            labelPrice.Text = "Price / Cost";
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Location = new Point(163, 30);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(30, 15);
            labelMax.TabIndex = 10;
            labelMax.Text = "Max";
            // 
            // textBoxInentory
            // 
            textBoxInentory.Location = new Point(125, 162);
            textBoxInentory.Name = "textBoxInentory";
            textBoxInentory.Size = new Size(185, 23);
            textBoxInentory.TabIndex = 11;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(125, 191);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(185, 23);
            textBoxPrice.TabIndex = 12;
            // 
            // textBoxMin
            // 
            textBoxMin.Location = new Point(67, 22);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new Size(57, 23);
            textBoxMin.TabIndex = 13;
            // 
            // textBoxMax
            // 
            textBoxMax.Location = new Point(199, 22);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new Size(57, 23);
            textBoxMax.TabIndex = 14;
            // 
            // groupBoxRange
            // 
            groupBoxRange.Controls.Add(labelMin);
            groupBoxRange.Controls.Add(textBoxMin);
            groupBoxRange.Controls.Add(textBoxMax);
            groupBoxRange.Controls.Add(labelMax);
            groupBoxRange.Location = new Point(12, 236);
            groupBoxRange.Name = "groupBoxRange";
            groupBoxRange.Size = new Size(298, 61);
            groupBoxRange.TabIndex = 15;
            groupBoxRange.TabStop = false;
            groupBoxRange.Text = "Inventory Range";
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Location = new Point(33, 30);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(28, 15);
            labelMin.TabIndex = 16;
            labelMin.Text = "Min";
            // 
            // labelMachineID
            // 
            labelMachineID.AutoSize = true;
            labelMachineID.Location = new Point(12, 334);
            labelMachineID.Name = "labelMachineID";
            labelMachineID.Size = new Size(67, 15);
            labelMachineID.TabIndex = 16;
            labelMachineID.Text = "Machine ID";
            // 
            // textBoxMachineID
            // 
            textBoxMachineID.Location = new Point(125, 326);
            textBoxMachineID.Name = "textBoxMachineID";
            textBoxMachineID.Size = new Size(185, 23);
            textBoxMachineID.TabIndex = 17;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(235, 377);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 18;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(154, 377);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 19;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // PartScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 413);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxMachineID);
            Controls.Add(labelMachineID);
            Controls.Add(groupBoxRange);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxInentory);
            Controls.Add(labelPrice);
            Controls.Add(labelInventory);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelID);
            Controls.Add(textBoxID);
            Controls.Add(groupBoxPartType);
            Controls.Add(partLabel);
            Name = "PartScreen";
            Text = "Part";
            groupBoxPartType.ResumeLayout(false);
            groupBoxPartType.PerformLayout();
            groupBoxRange.ResumeLayout(false);
            groupBoxRange.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label partLabel;
        private RadioButton radioInhouse;
        private System.Windows.Forms.Timer timer1;
        private RadioButton radioOutoourced;
        private GroupBox groupBoxPartType;
        private TextBox textBoxID;
        private Label labelID;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelInventory;
        private Label labelPrice;
        private Label labelMax;
        private TextBox textBoxInentory;
        private TextBox textBoxPrice;
        private TextBox textBoxMin;
        private TextBox textBoxMax;
        private GroupBox groupBoxRange;
        private Label labelMin;
        private Label labelMachineID;
        private TextBox textBoxMachineID;
        private Button buttonCancel;
        private Button buttonSave;
    }
}