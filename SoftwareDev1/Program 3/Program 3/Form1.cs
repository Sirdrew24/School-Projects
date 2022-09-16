/*  Program 3
 *  CIS 199-01
 *  Due 04/1/2021
 *  Grading ID: R0189
 *  
 *  This program is used to calculate the cost of ordering an item chosen by the user based off the quantity wanted and the farm the user wants to order from 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Program_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //when the GUI is ran/created the combo box is given the values in the array below
            InitializeComponent();

            string[] farmnamesA = { "NE", "NW", "SE", "SW" };//creates the array for the farm names to be used for the combo box
            for (int i = 0; i < farmnamesA.Length; i++)//steps through the farm names array
            {
                FarmCombobox.Items.Add(farmnamesA[i]);//adds the farm names to the combo box
            }
            FarmCombobox.SelectedIndex = 0;//sets combo box default to first farm
        }
        //click event used to calculate the costs and discount if any
        private void CalcButton_Click(object sender, EventArgs e)
        {
            string[] farmnamesA = { "NE", "NW", "SE", "SW" };//creates array for farms
            double[] ShipmentfeeA = { .06, .0717, .07, .0874 };//creates array for shipment fee

            int[] itemnumberA = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 };//creates array for item number
            double[] costperpoundA = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 };//creates array for cost per item

            int[] poundlowlimitsA = { 0, 6, 11, 21 };//creates array for pounds
            double[] discountA = { 0, .05, .10, .15 };//creates array for discount

            double shipmentfee = 0, costperpound = 0, discount = 0;
            int itemnumber, quantity;//creates variables used for calculations

            if (int.TryParse(ItemTextbox.Text, out itemnumber) & (itemnumber >= 10001 & itemnumber <= 10007))//tests to see if the value inputed for item number is valid
            {

            }
            else
            {
                MessageBox.Show("Invalid value for item number. Please enter an item number between 10001 and 10007.");//shows error message if user puts in an invalid value for item number
            }

            for (int i = 0; i < itemnumberA.Length; i++)//for loop goes through the item number array to find the item number inputed and changes costperpound to corresponding value
            {
                if (itemnumber == itemnumberA[i])
                {
                    costperpound = costperpoundA[i];//sets cost per pound to a value in the cost per pound array
                }
            }

            if (int.TryParse(QuantityTextbox.Text, out quantity) & quantity > 0)//tests to see if the value inputed for quantity is valid
            {

            }
            else
            {
                MessageBox.Show("Invalid value for quantity. Please enter a valid quantity greater than 0.");//shows error message if invalid value for quantity is entered
            }

            for (int i = 0; i < farmnamesA.Length; i++)//for loop goes through the farm name array to find the farm name that the user chose from the combo box and changes shipment fee to the corresponding value
            {
                if (FarmCombobox.SelectedIndex == i)
                {
                    shipmentfee = ShipmentfeeA[i];//sets shipment fee value to a value in the shipment fee array
                }
            }
            //if statments below are used to see which discount is needed based off the quantity given and the lower limits of the pounds
                if (quantity >= poundlowlimitsA[0] & quantity < poundlowlimitsA[1])
                {
                    discount = discountA[0];
                }
                else if (quantity >= poundlowlimitsA[1] & quantity < poundlowlimitsA[2])
                {
                    discount = discountA[1];
                }
                else if (quantity >= poundlowlimitsA[2] & quantity < poundlowlimitsA[3])
                {
                    discount = discountA[2];
                }
                else
                {
                    discount = discountA[3];
                }
            double InitialCost, DiscountedCost, ShipmentCost, TotalPrice;
            InitialCost = costperpound * quantity;
            DiscountedCost = InitialCost - (InitialCost * discount);        //formulas for evauluating the different costs
            ShipmentCost = DiscountedCost * shipmentfee;
            TotalPrice = DiscountedCost + ShipmentCost;

            InitialCostoutputLabel.Text = InitialCost.ToString("C", CultureInfo.GetCultureInfo("en-US"));//displays Initial cost
            DiscountedCostoutputLabel.Text = DiscountedCost.ToString("C", CultureInfo.GetCultureInfo("en-US"));//displays Discounted cost
            ShipmentCostoutputLabel.Text = ShipmentCost.ToString("C", CultureInfo.GetCultureInfo("en-US"));//displays Shipment cost
            TotalPriceoutputLabel.Text = TotalPrice.ToString("C", CultureInfo.GetCultureInfo("en-US"));//displays Total Price
        }
    }
}
