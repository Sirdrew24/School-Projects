using System;
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
    public partial class LetterForm : Form
    {
        public const int MIN_ADDRESSES = 2;

        private List<Address> addressList;

        // Precondition:  addresses.Count >= MIN_ADDRESSES
        // Postcondition: The form's GUI is prepared for display
        public LetterForm(List<Address> addresses)
        {
            InitializeComponent();

            addressList = addresses;
        }

        internal int OriginAddressIndex
        {
            // Precondition:  User has selected from origin address combobox
            // Postcondition: The index of the slected origin address returned
            get { return OriginAddressCombobox.SelectedIndex; }

            // Precondition:  -1 <= value < addressList.Count
            // Postcondition: The specified index is selected in origin address combobox
            set
            {
                if ((value >= -1) && (value < addressList.Count))
                    OriginAddressCombobox.SelectedIndex = value;
                else
                    throw new ArgumentOutOfRangeException("OriginAddressIndex", value, "Index must be valid");
            }
        }

        internal int DestinationAddressIndex
        {
            // Precondition:  User has selected from destination address combobox
            // Postcondition: The index of the slected destination address returned
            get { return DestinationAddressCombobox.SelectedIndex; }

            // Precondition:  -1 <= value < addressList.Count
            // Postcondition: The specified index is selected in destination address combobox
            set
            {
                if ((value >= -1) && (value < addressList.Count))
                    DestinationAddressCombobox.SelectedIndex = value;
                else
                    throw new ArgumentOutOfRangeException("DestinationAddressIndex", value, "Index must be valid");
            }
        }

        internal string FixedCostText
        {
            // Preconditon:  None
            // Postcondition: The text of form's fixed cost field is returned
            get { return FixedCostTextbox.Text; }

            // Precondition:  None
            // Postcondition: The text of form's fixed cost field is set to specified value
            set { FixedCostTextbox.Text = value; }
        }

        // Precondition  addressList.Count >= MIN_ADDRESSES
        // Postcondition The list of addresses is used to populate the origin and destination address combo boxes
        private void LetterForm_Load(object sender, EventArgs e)
        {
            if (addressList.Count < MIN_ADDRESSES)
            {
                MessageBox.Show("Need" + MIN_ADDRESSES + "addresses to create letter!", "Addresses Error");
                this.DialogResult = DialogResult.Abort;
            }
            else
            {
                foreach (Address a in addressList)
                {
                    OriginAddressCombobox.Items.Add(a.Name);
                    DestinationAddressCombobox.Items.Add(a.Name);
                }
            }
        }

        // Precondition:  Focus is shifting from fixed cost text box
        // Postcondition: If text is invalid, focus remains and error provider highlights the field

        private void FixedCostTextbox_Validating(object sender, CancelEventArgs e)
        {
            decimal fixedCost;
            bool valid = true;

            if (!decimal.TryParse(FixedCostTextbox.Text, out fixedCost))
                valid = false;
            else if (fixedCost < 0)
                valid = false;

            if (!valid)
            {
                e.Cancel = true;
                FixedCostTextbox.SelectAll();
                errorProvider.SetError(FixedCostTextbox, "Invalid cost! Enter an amount.");
            }
        }

        // Precondition:  Focus shifting from one of the address combo boxes sender is ComboBox
        // Postcondition: If no address selected, focus remains and error provider highlights the field
        private void AddressCombobox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cbo = sender as ComboBox;

            if (cbo.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(cbo, "Must select an address");
            }
            else if (OriginAddressCombobox.SelectedIndex != -1 && DestinationAddressCombobox.SelectedIndex == OriginAddressCombobox.SelectedIndex)
            {
                e.Cancel = true;
                errorProvider.SetError(cbo, "Must select different addresses");
            }
        }

        // Precondition:  Validating of sender not cancelled, so data OK sender is Control
        // Postcondition: Error provider cleared and focus allowed to change
        private void AllFields_Validated(object sender, EventArgs e)
        {
            Control control = sender as Control;
            errorProvider.SetError(control, "");
        }

        // Precondition:  User pressed OKButton
        // Postcondition: If invalid field on dialog, keep form open and give first invalid field the focus. Else return OK and close form
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Precondition:  user pressed CancelButton
        // Postcondition: Form closes
        private void CancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
