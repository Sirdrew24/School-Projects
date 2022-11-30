using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class AddressForm : Form
    {
        public const String DEFAULT_STATE = "KY";

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display
        public AddressForm()
        {
            InitializeComponent();

            List<string> states = new List<string> { "CA", "IN", "KY", "MD", "ME", "NC", "OH", "SC", "TN", "TX" };
            
            foreach (string state in states)
                StateCombobox.Items.Add(state);

            State = DEFAULT_STATE;
        }

        internal string AddressName
        {
            get { return NameTextbox.Text; }

            set { NameTextbox.Text = value; }
        }

        internal string Address1
        {
            get { return AddressTextbox.Text; }

            set { AddressTextbox.Text = value; }
        }

        internal string Address2
        {
            get { return Address2Textbox.Text; }

            set { Address2Textbox.Text = value; }
        }

        internal string City
        {
            get { return CityTextbox.Text; }

            set { CityTextbox.Text = value; }
        }

        internal string ZipText
        {
            get { return ZipTextbox.Text; }

            set { ZipTextbox.Text = value; }
        }

        internal string State
        {
            get
            {
                if (StateCombobox.SelectedIndex != -1)
                    return StateCombobox.SelectedItem.ToString();
                else
                    return "";
            }

            set { StateCombobox.SelectedItem = value; }
        }

        private void StateCombobox_Validating(object sender, CancelEventArgs e)
        {
            if (StateCombobox.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(StateCombobox, "Must select a state!");
            }
        }

        private void ZipText_Validating(object sender, CancelEventArgs e)
        {
            int zip;

            if (!int.TryParse(ZipTextbox.Text, out zip)
                || (zip < Address.MIN_ZIP) || (zip > Address.MAX_ZIP))
            {
                e.Cancel = true;
                ZipTextbox.SelectAll();
                errorProvider.SetError(ZipTextbox, "Invalid zip code! Enter 5 digit zip code");
            }
        }

        private void RequiredTextFields_Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = sender as TextBox;

            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                e.Cancel = true;
                const int SUFFIX = 3;
                string name;
                name = textbox.Name.Substring(0, textbox.Name.Length - SUFFIX);
                errorProvider.SetError(textbox, $"Must enter a value for {name}!");
            }
        }

        private void AllFields_Validated(object sender, EventArgs e)
        {
            Control control = sender as Control;
            errorProvider.SetError(control, "");
        }

        private void CancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
    }
}
