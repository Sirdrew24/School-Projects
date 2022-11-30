using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog4
{
    public partial class ChooseAddressForm : Form
    {
        private List<Address> addresseList;

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display
        public ChooseAddressForm(List<Address> addresses)
        {
            InitializeComponent();
            addresseList = addresses;
        }

        public int AddressIndex
        {
            get { return ChooseAddressComboBox.SelectedIndex; }

            set
            {
                if ((value >= 1) && (value < addresseList.Count))
                    ChooseAddressComboBox.SelectedIndex = value;
                else
                    throw new ArgumentOutOfRangeException("AddressIndex", value, "Index must be valid");
            }
        }

        private void ChooseAddressForm_Load(object sender, EventArgs e)
        {
            foreach (Address a in addresseList)
            {
                ChooseAddressComboBox.Items.Add(a.Name);
            }

            ChooseAddressComboBox.SelectedIndex = 0;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ChooseAddressComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (ChooseAddressComboBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(ChooseAddressComboBox, "");
            }
        }
    }
}
