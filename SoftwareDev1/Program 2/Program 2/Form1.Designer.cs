
namespace Program_2
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
            this.ResultsGroupbox = new System.Windows.Forms.GroupBox();
            this.Peoplelabel = new System.Windows.Forms.Label();
            this.Peopletextbox = new System.Windows.Forms.TextBox();
            this.Distancetextbox = new System.Windows.Forms.TextBox();
            this.Distancelabel = new System.Windows.Forms.Label();
            this.Deliverydaytextbox = new System.Windows.Forms.TextBox();
            this.DeliveryDayslabel = new System.Windows.Forms.Label();
            this.CompanyACostlabel = new System.Windows.Forms.Label();
            this.CompanyAoutputlabel = new System.Windows.Forms.Label();
            this.CompanyBoutputlabel = new System.Windows.Forms.Label();
            this.CompanyBCostlabel = new System.Windows.Forms.Label();
            this.CompanyCoutputlabel = new System.Windows.Forms.Label();
            this.CompanyCCostlabel = new System.Windows.Forms.Label();
            this.LowestCompanyoutputlabel = new System.Windows.Forms.Label();
            this.Calcbutton = new System.Windows.Forms.Button();
            this.ResultsGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultsGroupbox
            // 
            this.ResultsGroupbox.Controls.Add(this.LowestCompanyoutputlabel);
            this.ResultsGroupbox.Controls.Add(this.CompanyCoutputlabel);
            this.ResultsGroupbox.Controls.Add(this.CompanyCCostlabel);
            this.ResultsGroupbox.Controls.Add(this.CompanyBoutputlabel);
            this.ResultsGroupbox.Controls.Add(this.CompanyBCostlabel);
            this.ResultsGroupbox.Controls.Add(this.CompanyAoutputlabel);
            this.ResultsGroupbox.Controls.Add(this.CompanyACostlabel);
            this.ResultsGroupbox.Location = new System.Drawing.Point(243, 12);
            this.ResultsGroupbox.Name = "ResultsGroupbox";
            this.ResultsGroupbox.Size = new System.Drawing.Size(243, 180);
            this.ResultsGroupbox.TabIndex = 0;
            this.ResultsGroupbox.TabStop = false;
            this.ResultsGroupbox.Text = "Results";
            // 
            // Peoplelabel
            // 
            this.Peoplelabel.AutoSize = true;
            this.Peoplelabel.Location = new System.Drawing.Point(56, 34);
            this.Peoplelabel.Name = "Peoplelabel";
            this.Peoplelabel.Size = new System.Drawing.Size(43, 13);
            this.Peoplelabel.TabIndex = 1;
            this.Peoplelabel.Text = "People:";
            // 
            // Peopletextbox
            // 
            this.Peopletextbox.Location = new System.Drawing.Point(105, 31);
            this.Peopletextbox.Name = "Peopletextbox";
            this.Peopletextbox.Size = new System.Drawing.Size(100, 20);
            this.Peopletextbox.TabIndex = 2;
            // 
            // Distancetextbox
            // 
            this.Distancetextbox.Location = new System.Drawing.Point(105, 77);
            this.Distancetextbox.Name = "Distancetextbox";
            this.Distancetextbox.Size = new System.Drawing.Size(100, 20);
            this.Distancetextbox.TabIndex = 4;
            // 
            // Distancelabel
            // 
            this.Distancelabel.AutoSize = true;
            this.Distancelabel.Location = new System.Drawing.Point(17, 80);
            this.Distancelabel.Name = "Distancelabel";
            this.Distancelabel.Size = new System.Drawing.Size(85, 13);
            this.Distancelabel.TabIndex = 3;
            this.Distancelabel.Text = "Distance (Miles):";
            // 
            // Deliverydaytextbox
            // 
            this.Deliverydaytextbox.Location = new System.Drawing.Point(105, 123);
            this.Deliverydaytextbox.Name = "Deliverydaytextbox";
            this.Deliverydaytextbox.Size = new System.Drawing.Size(100, 20);
            this.Deliverydaytextbox.TabIndex = 6;
            // 
            // DeliveryDayslabel
            // 
            this.DeliveryDayslabel.AutoSize = true;
            this.DeliveryDayslabel.Location = new System.Drawing.Point(24, 126);
            this.DeliveryDayslabel.Name = "DeliveryDayslabel";
            this.DeliveryDayslabel.Size = new System.Drawing.Size(75, 13);
            this.DeliveryDayslabel.TabIndex = 5;
            this.DeliveryDayslabel.Text = "Delivery Days:";
            // 
            // CompanyACostlabel
            // 
            this.CompanyACostlabel.AutoSize = true;
            this.CompanyACostlabel.Location = new System.Drawing.Point(6, 20);
            this.CompanyACostlabel.Name = "CompanyACostlabel";
            this.CompanyACostlabel.Size = new System.Drawing.Size(88, 13);
            this.CompanyACostlabel.TabIndex = 0;
            this.CompanyACostlabel.Text = "Company A Cost:";
            // 
            // CompanyAoutputlabel
            // 
            this.CompanyAoutputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyAoutputlabel.Location = new System.Drawing.Point(137, 19);
            this.CompanyAoutputlabel.Name = "CompanyAoutputlabel";
            this.CompanyAoutputlabel.Size = new System.Drawing.Size(100, 20);
            this.CompanyAoutputlabel.TabIndex = 1;
            // 
            // CompanyBoutputlabel
            // 
            this.CompanyBoutputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyBoutputlabel.Location = new System.Drawing.Point(137, 65);
            this.CompanyBoutputlabel.Name = "CompanyBoutputlabel";
            this.CompanyBoutputlabel.Size = new System.Drawing.Size(100, 20);
            this.CompanyBoutputlabel.TabIndex = 3;
            // 
            // CompanyBCostlabel
            // 
            this.CompanyBCostlabel.AutoSize = true;
            this.CompanyBCostlabel.Location = new System.Drawing.Point(6, 66);
            this.CompanyBCostlabel.Name = "CompanyBCostlabel";
            this.CompanyBCostlabel.Size = new System.Drawing.Size(88, 13);
            this.CompanyBCostlabel.TabIndex = 2;
            this.CompanyBCostlabel.Text = "Company B Cost:";
            // 
            // CompanyCoutputlabel
            // 
            this.CompanyCoutputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyCoutputlabel.Location = new System.Drawing.Point(137, 111);
            this.CompanyCoutputlabel.Name = "CompanyCoutputlabel";
            this.CompanyCoutputlabel.Size = new System.Drawing.Size(100, 20);
            this.CompanyCoutputlabel.TabIndex = 5;
            // 
            // CompanyCCostlabel
            // 
            this.CompanyCCostlabel.AutoSize = true;
            this.CompanyCCostlabel.Location = new System.Drawing.Point(6, 112);
            this.CompanyCCostlabel.Name = "CompanyCCostlabel";
            this.CompanyCCostlabel.Size = new System.Drawing.Size(88, 13);
            this.CompanyCCostlabel.TabIndex = 4;
            this.CompanyCCostlabel.Text = "Company C Cost:";
            // 
            // LowestCompanyoutputlabel
            // 
            this.LowestCompanyoutputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LowestCompanyoutputlabel.Location = new System.Drawing.Point(30, 154);
            this.LowestCompanyoutputlabel.Name = "LowestCompanyoutputlabel";
            this.LowestCompanyoutputlabel.Size = new System.Drawing.Size(183, 23);
            this.LowestCompanyoutputlabel.TabIndex = 6;
            // 
            // Calcbutton
            // 
            this.Calcbutton.Location = new System.Drawing.Point(72, 166);
            this.Calcbutton.Name = "Calcbutton";
            this.Calcbutton.Size = new System.Drawing.Size(75, 23);
            this.Calcbutton.TabIndex = 7;
            this.Calcbutton.Text = "Calculate Cost";
            this.Calcbutton.UseVisualStyleBackColor = true;
            this.Calcbutton.Click += new System.EventHandler(this.Calcbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 204);
            this.Controls.Add(this.Calcbutton);
            this.Controls.Add(this.Deliverydaytextbox);
            this.Controls.Add(this.DeliveryDayslabel);
            this.Controls.Add(this.Distancetextbox);
            this.Controls.Add(this.Distancelabel);
            this.Controls.Add(this.Peopletextbox);
            this.Controls.Add(this.Peoplelabel);
            this.Controls.Add(this.ResultsGroupbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResultsGroupbox.ResumeLayout(false);
            this.ResultsGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ResultsGroupbox;
        private System.Windows.Forms.Label LowestCompanyoutputlabel;
        private System.Windows.Forms.Label CompanyCoutputlabel;
        private System.Windows.Forms.Label CompanyCCostlabel;
        private System.Windows.Forms.Label CompanyBoutputlabel;
        private System.Windows.Forms.Label CompanyBCostlabel;
        private System.Windows.Forms.Label CompanyAoutputlabel;
        private System.Windows.Forms.Label CompanyACostlabel;
        private System.Windows.Forms.Label Peoplelabel;
        private System.Windows.Forms.TextBox Peopletextbox;
        private System.Windows.Forms.TextBox Distancetextbox;
        private System.Windows.Forms.Label Distancelabel;
        private System.Windows.Forms.TextBox Deliverydaytextbox;
        private System.Windows.Forms.Label DeliveryDayslabel;
        private System.Windows.Forms.Button Calcbutton;
    }
}

