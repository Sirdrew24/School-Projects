namespace Prog2
{
    partial class LetterForm
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
            this.components = new System.ComponentModel.Container();
            this.OriginAddressLabel = new System.Windows.Forms.Label();
            this.DestinationAddressLabel = new System.Windows.Forms.Label();
            this.FixedCostLabel = new System.Windows.Forms.Label();
            this.FixedCostTextbox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OriginAddressCombobox = new System.Windows.Forms.ComboBox();
            this.DestinationAddressCombobox = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginAddressLabel
            // 
            this.OriginAddressLabel.AutoSize = true;
            this.OriginAddressLabel.Location = new System.Drawing.Point(40, 9);
            this.OriginAddressLabel.Name = "OriginAddressLabel";
            this.OriginAddressLabel.Size = new System.Drawing.Size(78, 13);
            this.OriginAddressLabel.TabIndex = 0;
            this.OriginAddressLabel.Text = "Origin Address:";
            // 
            // DestinationAddressLabel
            // 
            this.DestinationAddressLabel.AutoSize = true;
            this.DestinationAddressLabel.Location = new System.Drawing.Point(14, 36);
            this.DestinationAddressLabel.Name = "DestinationAddressLabel";
            this.DestinationAddressLabel.Size = new System.Drawing.Size(104, 13);
            this.DestinationAddressLabel.TabIndex = 1;
            this.DestinationAddressLabel.Text = "Destination Address:";
            // 
            // FixedCostLabel
            // 
            this.FixedCostLabel.AutoSize = true;
            this.FixedCostLabel.Location = new System.Drawing.Point(59, 63);
            this.FixedCostLabel.Name = "FixedCostLabel";
            this.FixedCostLabel.Size = new System.Drawing.Size(59, 13);
            this.FixedCostLabel.TabIndex = 2;
            this.FixedCostLabel.Text = "Fixed Cost:";
            // 
            // FixedCostTextbox
            // 
            this.FixedCostTextbox.Location = new System.Drawing.Point(124, 60);
            this.FixedCostTextbox.Name = "FixedCostTextbox";
            this.FixedCostTextbox.Size = new System.Drawing.Size(100, 20);
            this.FixedCostTextbox.TabIndex = 3;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 99);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(149, 99);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CancelButton_MouseDown);
            // 
            // OriginAddressCombobox
            // 
            this.OriginAddressCombobox.BackColor = System.Drawing.SystemColors.Window;
            this.OriginAddressCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OriginAddressCombobox.FormattingEnabled = true;
            this.OriginAddressCombobox.Location = new System.Drawing.Point(124, 6);
            this.OriginAddressCombobox.Name = "OriginAddressCombobox";
            this.OriginAddressCombobox.Size = new System.Drawing.Size(99, 21);
            this.OriginAddressCombobox.TabIndex = 6;
            // 
            // DestinationAddressCombobox
            // 
            this.DestinationAddressCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestinationAddressCombobox.FormattingEnabled = true;
            this.DestinationAddressCombobox.Location = new System.Drawing.Point(124, 33);
            this.DestinationAddressCombobox.Name = "DestinationAddressCombobox";
            this.DestinationAddressCombobox.Size = new System.Drawing.Size(99, 21);
            this.DestinationAddressCombobox.TabIndex = 7;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 134);
            this.Controls.Add(this.DestinationAddressCombobox);
            this.Controls.Add(this.OriginAddressCombobox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.FixedCostTextbox);
            this.Controls.Add(this.FixedCostLabel);
            this.Controls.Add(this.DestinationAddressLabel);
            this.Controls.Add(this.OriginAddressLabel);
            this.Name = "LetterForm";
            this.Text = "Letter";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OriginAddressLabel;
        private System.Windows.Forms.Label DestinationAddressLabel;
        private System.Windows.Forms.Label FixedCostLabel;
        private System.Windows.Forms.TextBox FixedCostTextbox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox OriginAddressCombobox;
        private System.Windows.Forms.ComboBox DestinationAddressCombobox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}