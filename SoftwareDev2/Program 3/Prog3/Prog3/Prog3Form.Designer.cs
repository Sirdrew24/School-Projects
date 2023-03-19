namespace Prog3
{
    partial class Prog3Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prog3Form));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.FileToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ChangeLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.editaddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.InsertToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.letterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ReportToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.listAddressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listParcelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MainTextBox = new System.Windows.Forms.TextBox();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripDropDownButton,
            this.EditToolStripDropDownButton,
            this.InsertToolStripDropDownButton,
            this.ReportToolStripDropDownButton});
			resources.ApplyResources(this.toolStrip1, "toolStrip1");
			this.toolStrip1.Name = "toolStrip1";
			// 
			// FileToolStripDropDownButton
			// 
			this.FileToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.FileToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.ChangeLanguageToolStripMenuItem});
			resources.ApplyResources(this.FileToolStripDropDownButton, "FileToolStripDropDownButton");
			this.FileToolStripDropDownButton.Name = "FileToolStripDropDownButton";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// ChangeLanguageToolStripMenuItem
			// 
			this.ChangeLanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.spanishToolStripMenuItem});
			this.ChangeLanguageToolStripMenuItem.Name = "ChangeLanguageToolStripMenuItem";
			resources.ApplyResources(this.ChangeLanguageToolStripMenuItem, "ChangeLanguageToolStripMenuItem");
			// 
			// englishToolStripMenuItem
			// 
			this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
			resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
			this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
			// 
			// spanishToolStripMenuItem
			// 
			this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
			resources.ApplyResources(this.spanishToolStripMenuItem, "spanishToolStripMenuItem");
			this.spanishToolStripMenuItem.Click += new System.EventHandler(this.spanishToolStripMenuItem_Click);
			// 
			// EditToolStripDropDownButton
			// 
			this.EditToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.EditToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editaddressToolStripMenuItem});
			resources.ApplyResources(this.EditToolStripDropDownButton, "EditToolStripDropDownButton");
			this.EditToolStripDropDownButton.Name = "EditToolStripDropDownButton";
			// 
			// editaddressToolStripMenuItem
			// 
			this.editaddressToolStripMenuItem.Name = "editaddressToolStripMenuItem";
			resources.ApplyResources(this.editaddressToolStripMenuItem, "editaddressToolStripMenuItem");
			this.editaddressToolStripMenuItem.Click += new System.EventHandler(this.editaddressToolStripMenuItem_Click);
			// 
			// InsertToolStripDropDownButton
			// 
			this.InsertToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.InsertToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressToolStripMenuItem,
            this.letterToolStripMenuItem});
			resources.ApplyResources(this.InsertToolStripDropDownButton, "InsertToolStripDropDownButton");
			this.InsertToolStripDropDownButton.Name = "InsertToolStripDropDownButton";
			// 
			// addressToolStripMenuItem
			// 
			this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
			resources.ApplyResources(this.addressToolStripMenuItem, "addressToolStripMenuItem");
			this.addressToolStripMenuItem.Click += new System.EventHandler(this.addressToolStripMenuItem_Click);
			// 
			// letterToolStripMenuItem
			// 
			this.letterToolStripMenuItem.Name = "letterToolStripMenuItem";
			resources.ApplyResources(this.letterToolStripMenuItem, "letterToolStripMenuItem");
			this.letterToolStripMenuItem.Click += new System.EventHandler(this.letterToolStripMenuItem_Click);
			// 
			// ReportToolStripDropDownButton
			// 
			this.ReportToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ReportToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAddressesToolStripMenuItem,
            this.listParcelsToolStripMenuItem});
			resources.ApplyResources(this.ReportToolStripDropDownButton, "ReportToolStripDropDownButton");
			this.ReportToolStripDropDownButton.Name = "ReportToolStripDropDownButton";
			// 
			// listAddressesToolStripMenuItem
			// 
			this.listAddressesToolStripMenuItem.Name = "listAddressesToolStripMenuItem";
			resources.ApplyResources(this.listAddressesToolStripMenuItem, "listAddressesToolStripMenuItem");
			this.listAddressesToolStripMenuItem.Click += new System.EventHandler(this.listAddressesToolStripMenuItem_Click);
			// 
			// listParcelsToolStripMenuItem
			// 
			this.listParcelsToolStripMenuItem.Name = "listParcelsToolStripMenuItem";
			resources.ApplyResources(this.listParcelsToolStripMenuItem, "listParcelsToolStripMenuItem");
			this.listParcelsToolStripMenuItem.Click += new System.EventHandler(this.listParcelsToolStripMenuItem_Click);
			// 
			// MainTextBox
			// 
			this.MainTextBox.BackColor = System.Drawing.SystemColors.Control;
			resources.ApplyResources(this.MainTextBox, "MainTextBox");
			this.MainTextBox.Name = "MainTextBox";
			this.MainTextBox.ReadOnly = true;
			// 
			// Prog3Form
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.MainTextBox);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Prog3Form";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton FileToolStripDropDownButton;
        private System.Windows.Forms.ToolStripDropDownButton InsertToolStripDropDownButton;
        private System.Windows.Forms.ToolStripDropDownButton ReportToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letterToolStripMenuItem;
        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.ToolStripMenuItem listAddressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listParcelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton EditToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem editaddressToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ChangeLanguageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;
	}
}

