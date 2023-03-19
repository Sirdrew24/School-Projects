/* Brendon Carter
 * Program 2
 * CIS 200
 */
using Prog2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class Prog3Form : Form
    {
        private UserParcelView upv; // The UserParcelView

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test addresses are added to the list of address
        public Prog3Form()
        {
            InitializeComponent();

            upv = new UserParcelView();

            /*// Test Data
            upv.AddAddress("John Smith", "123 Any St.", "Apt. 45", "Louisville", "KY", 40202); // Test Address 1
            upv.AddAddress("Jane Doe", "987 Main St.", "Beverly Hills", "CA", 90210); // Test Address 2
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321", "El Paso", "TX", 79901); // Test Address 3
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7", "Portland", "ME", 04101); // Test Address 4
            upv.AddAddress("John Doe", "111 Market St.", "", "Jeffersonville", "IN", 47130); // Test Address 5
            upv.AddAddress("Jane Smith", "55 Hollywood Blvd.", "Apt. 9", "Los Angeles", "CA", 90212); // Test Address 6
            upv.AddAddress("Captain Robert Crunch", "21 Cereal Rd.", "Room 987", "Bethesda", "MD", 20810); // Test Address 7
            upv.AddAddress("Vlad Dracula", "6543 Vampire Way", "Apt. 1", "Bloodsucker City", "TN", 37210); // Test Address 8

            upv.AddLetter(upv.AddressAt(0), upv.AddressAt(1), 3.95M);
            upv.AddLetter(upv.AddressAt(2), upv.AddressAt(3), 4.25M);
            upv.AddGroundPackage(upv.AddressAt(4), upv.AddressAt(5), 14, 10, 5, 12.5);
            upv.AddGroundPackage(upv.AddressAt(6), upv.AddressAt(7), 8.5, 9.5, 6.5, 2.5);
            upv.AddNextDayAirPackage(upv.AddressAt(0), upv.AddressAt(2), 25, 15, 15, 85, 7.50M);
            upv.AddNextDayAirPackage(upv.AddressAt(2), upv.AddressAt(4), 9.5, 6.0, 5.5, 5.25, 5.25M);
            upv.AddNextDayAirPackage(upv.AddressAt(1), upv.AddressAt(6), 10.5, 6.5, 9.5, 15.5, 5.00M);
            upv.AddTwoDayAirPackage(upv.AddressAt(4), upv.AddressAt(6), 46.5, 39.5, 28.0, 80.5, TwoDayAirPackage.Delivery.Saver);
            upv.AddTwoDayAirPackage(upv.AddressAt(7), upv.AddressAt(0), 15, 9.5, 6.5, 75.5, TwoDayAirPackage.Delivery.Early);
            upv.AddTwoDayAirPackage(upv.AddressAt(5), upv.AddressAt(3), 12.0, 12.0, 6.0, 5.5, TwoDayAirPackage.Delivery.Saver);*/
        }
        
        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Program 3\nBy: Brendon Carter\nCIS 200\nFall 2022", "About Program 3");
        }

        // Precondition:  File, Open menu item activated
        // Postcondition: The UserParcelView is read in from a file using object serialization, replacing existing upv
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter reader = new BinaryFormatter();
            FileStream input = null;
            DialogResult result;
            string fileName;
            UserParcelView temp;

            using (OpenFileDialog fileChooser = new OpenFileDialog()) // Create Open
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (fileName == string.Empty)
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        input = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                        temp = (UserParcelView)reader.Deserialize(input);

                        upv = temp;
                    }

                    catch (IOException)
                    {
                        MessageBox.Show("I/O Error Reading From File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    catch (SerializationException)
                    {
                        MessageBox.Show("Serialization Error Reading From File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        input?.Close();
                    }
                }
            }
        }

        // Precondition:  File, Save As menu item activated
        // Postcondition: The list of addressess is saved to a file using object serialization
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream output = null;
            DialogResult result;
            string fileName;

            using (SaveFileDialog fileChooser = new SaveFileDialog()) // Create Save
            {
                fileChooser.CheckFileExists = false;

                // retrieve the result of the dialog box
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (fileName == String.Empty)
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        output = new FileStream(fileName, FileMode.Create, FileAccess.Write);

                        formatter.Serialize(output, upv);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("I/O Error Writing to File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (SerializationException)
                    {
                        MessageBox.Show("Serialization Error Writing to File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        output?.Close();
                    }
                }
            }
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: Thye application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Insert, Address menu item activated
        // Postcondition: The Address dialog box is displayed. If data entered are OK,
        //                an Address is created and added to the list of address
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AddressForm addressForm = new AddressForm(); // The address dialog box from
            DialogResult result = addressForm.ShowDialog(); // Show from as dialog
            int zip; // Address zip code

            if (result == DialogResult.OK) // Only add if OK
            {
                if (int.TryParse(addressForm.ZipText, out zip))
                {
                    upv.AddAddress(addressForm.AddressName, addressForm.Address1,
                        addressForm.Address2, addressForm.City,
                        addressForm.State, zip);
                }
                else
                    MessageBox.Show("Problem with Address Validation!", "Validation Error");
            } 

            addressForm.Dispose();
        }

        // Precondition:  Insert, Letter menu item activated
        // Postcondition: The Letter dialog box is displayed. If data entered are OK,
        //                a Letter is created and added to the list of letters.                    
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm;
            DialogResult result;
            decimal fixedCost;

            if (upv.AddressCount < LetterForm.MIN_ADDRESSES)
            {
                MessageBox.Show("Need" + LetterForm.MIN_ADDRESSES + "addresses to create Letter!", "Addresses Error");
                return;
            }

            letterForm = new LetterForm(upv.AddressList);
            result = letterForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (decimal.TryParse(letterForm.FixedCostText, out fixedCost))
                {
                    upv.AddLetter(upv.AddressAt(letterForm.OriginAddressIndex),
                        upv.AddressAt(letterForm.DestinationAddressIndex), fixedCost);
                }
                else
                    MessageBox.Show("Problem with Letter Validation!", "Validation Error");
            }

            letterForm.Dispose();
        }
        
        // Precondition:  Report, List Addresses menu item activated
        // Postcondition: The list of addresses is disaplyed in the Main text box
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            String NL = Environment.NewLine;

            result.Append("Addresses:");
            result.Append(NL);
            result.Append(NL);

            foreach (Address a in upv.AddressList)
            {
                result.Append(a.ToString());
                result.Append(NL);
                result.Append("---------------------------------");
                result.Append(NL);
            }

            MainTextBox.Text = result.ToString();

            // Put cursor at the start of the report
            MainTextBox.Focus();
            MainTextBox.SelectionStart = 0;
            MainTextBox.SelectionLength = 0;
        }

        // Precondition:  Insert, List Letter menu item activated
        // Postcondition: The list of letters is disaplyed in the Main text box
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal totalCost = 0;
            string NL = Environment.NewLine;

            MainTextBox.Clear();
            MainTextBox.AppendText("Parcels:");
            MainTextBox.AppendText(NL);
            MainTextBox.AppendText(NL);

            foreach (Parcel p in upv.ParcelList)
            {
                MainTextBox.AppendText(p.ToString());
                MainTextBox.AppendText(NL);
                MainTextBox.AppendText("---------------------------------");
                MainTextBox.AppendText(NL);
                totalCost += p.CalcCost();
            }

            MainTextBox.AppendText(NL);
            MainTextBox.AppendText($"Total Cost: {totalCost:C}");

            // Put cursor at the start of the report
            MainTextBox.Focus();
            MainTextBox.SelectionStart = 0;
            MainTextBox.SelectionLength = 0;
        }

        private void editaddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (upv.AddressList.Count > 0)
            {
                ChooseAddressForm chooseAddForm = new ChooseAddressForm(upv.AddressList);
                DialogResult result = chooseAddForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int editIndex;
                    editIndex = chooseAddForm.AddressIndex;

                    if (editIndex >= 0)
                    {
                        Address editAddress = upv.AddressAt(editIndex);
                        AddressForm addressForm = new AddressForm();

                        addressForm.AddressName = editAddress.Name;
                        addressForm.Address1 = editAddress.Address1;
                        addressForm.Address2 = editAddress.Address2;
                        addressForm.City = editAddress.City;
                        addressForm.State = editAddress.State;
                        addressForm.ZipText = $"{editAddress.Zip:D5}";

                        result = addressForm.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            editAddress.Name = addressForm.AddressName;
                            editAddress.Address1 = addressForm.Address1;
                            editAddress.Address2 = addressForm.Address2;
                            editAddress.City = addressForm.City;
                            editAddress.State = addressForm.State;
                            if (int.TryParse(addressForm.ZipText, out int zip))
                                editAddress.Zip = zip;
                            else
                                MessageBox.Show("Problem with Zip Validation!", "Validation Error");
                        }
                        addressForm.Dispose();
                    }
                }
                chooseAddForm.Dispose();
            }
            else
                MessageBox.Show("No addresses to edit!", "No Addresses");
        }

		private void englishToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
		}

		private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-MX");
            InitializeComponent();
		}
	}
}
