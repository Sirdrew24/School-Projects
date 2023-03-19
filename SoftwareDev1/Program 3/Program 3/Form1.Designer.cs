
namespace Program_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.FarmLabel = new System.Windows.Forms.Label();
			this.ItemLabel = new System.Windows.Forms.Label();
			this.QuantityLabel = new System.Windows.Forms.Label();
			this.CalcButton = new System.Windows.Forms.Button();
			this.FarmCombobox = new System.Windows.Forms.ComboBox();
			this.ItemTextbox = new System.Windows.Forms.TextBox();
			this.QuantityTextbox = new System.Windows.Forms.TextBox();
			this.InitialCostLabel = new System.Windows.Forms.Label();
			this.DiscountedCostLabel = new System.Windows.Forms.Label();
			this.ShipmentCostLabel = new System.Windows.Forms.Label();
			this.TotalPriceLabel = new System.Windows.Forms.Label();
			this.InitialCostoutputLabel = new System.Windows.Forms.Label();
			this.DiscountedCostoutputLabel = new System.Windows.Forms.Label();
			this.ShipmentCostoutputLabel = new System.Windows.Forms.Label();
			this.TotalPriceoutputLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// FarmLabel
			// 
			this.FarmLabel.AutoSize = true;
			this.FarmLabel.Location = new System.Drawing.Point(106, 29);
			this.FarmLabel.Name = "FarmLabel";
			this.FarmLabel.Size = new System.Drawing.Size(33, 13);
			this.FarmLabel.TabIndex = 0;
			this.FarmLabel.Text = "Farm:";
			// 
			// ItemLabel
			// 
			this.ItemLabel.AutoSize = true;
			this.ItemLabel.Location = new System.Drawing.Point(109, 56);
			this.ItemLabel.Name = "ItemLabel";
			this.ItemLabel.Size = new System.Drawing.Size(30, 13);
			this.ItemLabel.TabIndex = 1;
			this.ItemLabel.Text = "Item:";
			// 
			// QuantityLabel
			// 
			this.QuantityLabel.AutoSize = true;
			this.QuantityLabel.Location = new System.Drawing.Point(68, 82);
			this.QuantityLabel.Name = "QuantityLabel";
			this.QuantityLabel.Size = new System.Drawing.Size(71, 13);
			this.QuantityLabel.TabIndex = 2;
			this.QuantityLabel.Text = "Quantity (lbs):";
			// 
			// CalcButton
			// 
			this.CalcButton.Location = new System.Drawing.Point(155, 117);
			this.CalcButton.Name = "CalcButton";
			this.CalcButton.Size = new System.Drawing.Size(75, 23);
			this.CalcButton.TabIndex = 3;
			this.CalcButton.Text = "Calculate";
			this.CalcButton.UseVisualStyleBackColor = true;
			this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
			// 
			// FarmCombobox
			// 
			this.FarmCombobox.FormattingEnabled = true;
			this.FarmCombobox.Location = new System.Drawing.Point(145, 26);
			this.FarmCombobox.Name = "FarmCombobox";
			this.FarmCombobox.Size = new System.Drawing.Size(100, 21);
			this.FarmCombobox.TabIndex = 4;
			// 
			// ItemTextbox
			// 
			this.ItemTextbox.Location = new System.Drawing.Point(145, 53);
			this.ItemTextbox.Name = "ItemTextbox";
			this.ItemTextbox.Size = new System.Drawing.Size(100, 20);
			this.ItemTextbox.TabIndex = 5;
			// 
			// QuantityTextbox
			// 
			this.QuantityTextbox.Location = new System.Drawing.Point(145, 79);
			this.QuantityTextbox.Name = "QuantityTextbox";
			this.QuantityTextbox.Size = new System.Drawing.Size(100, 20);
			this.QuantityTextbox.TabIndex = 6;
			// 
			// InitialCostLabel
			// 
			this.InitialCostLabel.AutoSize = true;
			this.InitialCostLabel.Location = new System.Drawing.Point(81, 162);
			this.InitialCostLabel.Name = "InitialCostLabel";
			this.InitialCostLabel.Size = new System.Drawing.Size(58, 13);
			this.InitialCostLabel.TabIndex = 7;
			this.InitialCostLabel.Text = "Initial Cost:";
			// 
			// DiscountedCostLabel
			// 
			this.DiscountedCostLabel.AutoSize = true;
			this.DiscountedCostLabel.Location = new System.Drawing.Point(51, 190);
			this.DiscountedCostLabel.Name = "DiscountedCostLabel";
			this.DiscountedCostLabel.Size = new System.Drawing.Size(88, 13);
			this.DiscountedCostLabel.TabIndex = 9;
			this.DiscountedCostLabel.Text = "Discounted Cost:";
			// 
			// ShipmentCostLabel
			// 
			this.ShipmentCostLabel.AutoSize = true;
			this.ShipmentCostLabel.Location = new System.Drawing.Point(61, 218);
			this.ShipmentCostLabel.Name = "ShipmentCostLabel";
			this.ShipmentCostLabel.Size = new System.Drawing.Size(78, 13);
			this.ShipmentCostLabel.TabIndex = 11;
			this.ShipmentCostLabel.Text = "Shipment Cost:";
			// 
			// TotalPriceLabel
			// 
			this.TotalPriceLabel.AutoSize = true;
			this.TotalPriceLabel.Location = new System.Drawing.Point(78, 246);
			this.TotalPriceLabel.Name = "TotalPriceLabel";
			this.TotalPriceLabel.Size = new System.Drawing.Size(61, 13);
			this.TotalPriceLabel.TabIndex = 13;
			this.TotalPriceLabel.Text = "Total Price:";
			// 
			// InitialCostoutputLabel
			// 
			this.InitialCostoutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.InitialCostoutputLabel.Location = new System.Drawing.Point(145, 161);
			this.InitialCostoutputLabel.Name = "InitialCostoutputLabel";
			this.InitialCostoutputLabel.Size = new System.Drawing.Size(100, 20);
			this.InitialCostoutputLabel.TabIndex = 14;
			// 
			// DiscountedCostoutputLabel
			// 
			this.DiscountedCostoutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DiscountedCostoutputLabel.Location = new System.Drawing.Point(145, 189);
			this.DiscountedCostoutputLabel.Name = "DiscountedCostoutputLabel";
			this.DiscountedCostoutputLabel.Size = new System.Drawing.Size(100, 20);
			this.DiscountedCostoutputLabel.TabIndex = 15;
			// 
			// ShipmentCostoutputLabel
			// 
			this.ShipmentCostoutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ShipmentCostoutputLabel.Location = new System.Drawing.Point(145, 217);
			this.ShipmentCostoutputLabel.Name = "ShipmentCostoutputLabel";
			this.ShipmentCostoutputLabel.Size = new System.Drawing.Size(100, 20);
			this.ShipmentCostoutputLabel.TabIndex = 16;
			// 
			// TotalPriceoutputLabel
			// 
			this.TotalPriceoutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TotalPriceoutputLabel.Location = new System.Drawing.Point(145, 245);
			this.TotalPriceoutputLabel.Name = "TotalPriceoutputLabel";
			this.TotalPriceoutputLabel.Size = new System.Drawing.Size(100, 20);
			this.TotalPriceoutputLabel.TabIndex = 17;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 291);
			this.Controls.Add(this.TotalPriceoutputLabel);
			this.Controls.Add(this.ShipmentCostoutputLabel);
			this.Controls.Add(this.DiscountedCostoutputLabel);
			this.Controls.Add(this.InitialCostoutputLabel);
			this.Controls.Add(this.TotalPriceLabel);
			this.Controls.Add(this.ShipmentCostLabel);
			this.Controls.Add(this.DiscountedCostLabel);
			this.Controls.Add(this.InitialCostLabel);
			this.Controls.Add(this.QuantityTextbox);
			this.Controls.Add(this.ItemTextbox);
			this.Controls.Add(this.FarmCombobox);
			this.Controls.Add(this.CalcButton);
			this.Controls.Add(this.QuantityLabel);
			this.Controls.Add(this.ItemLabel);
			this.Controls.Add(this.FarmLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FarmLabel;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.ComboBox FarmCombobox;
        private System.Windows.Forms.TextBox ItemTextbox;
        private System.Windows.Forms.TextBox QuantityTextbox;
        private System.Windows.Forms.Label InitialCostLabel;
        private System.Windows.Forms.Label DiscountedCostLabel;
        private System.Windows.Forms.Label ShipmentCostLabel;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label InitialCostoutputLabel;
        private System.Windows.Forms.Label DiscountedCostoutputLabel;
        private System.Windows.Forms.Label ShipmentCostoutputLabel;
        private System.Windows.Forms.Label TotalPriceoutputLabel;
    }
}

