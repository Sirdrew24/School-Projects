/* Brendon Carter
 * CIS 200
 * Fall 2022
 * Exam 2 Part 3
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace CIS200E2P3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Exam Part 3\nBy: Brendon Carter\nCIS 200\nFall 2022", "About Exam Part 3");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string input;

            if (!string.IsNullOrWhiteSpace(InputTextBox.Text))
            {
                input = InputTextBox.Text;

                OutputListbox.Items.Add(input);

                InputTextBox.Clear();
                InputTextBox.Focus();
            }
            else
                MessageBox.Show("Must not be empty", "Text Error");

        }
    }
}
