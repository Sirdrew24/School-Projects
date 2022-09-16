/* Program 2
   CIS 199-01
   Due 02/16/2021
   By: R0189

   This program creates a GUI that takes in dimensions from the user, cost of soil from the user, and whether the user wants fertilzer
   or if it is the users first garden so that it can create an estimate on how much it would cost to make a garden 
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

namespace Program_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This click event calculates the estimate for building a garden at certian dimensions inputted by the user, and using the soil cost inputted by the user
        private void CalcButton_Click(object sender, EventArgs e)
        {
            const int sqftTosqyards = 9,            //creates a constant that is used when finding how many square yards there are
                      firstgardenfee = 50;          //creates a constant that is used whenever it is the customers first garden
            const double WastePercent = 1.10,       //creates a constant that is used as waste for finding soil cost
                         LaborCostconst = 3.25,     //creates a constant that is used for finding LaborCost
                         Fertilizerprice = 4.25;    //creates a constant that is used for finding cost of fertilizer

            double MaxWidth,        //variable used for width of garden
                   MaxLength,       //variable used for length of garden
                   SoilPrice,       //variable used for price of soil per square yard
                   SoilCost,        //variable used for soil cost
                   FertilizerCost,  //variable used for fertilizer cost
                   LaborCost,       //variable used for LaborCost
                   TotalCost,       //variable used for TotalCost
                   SqYards;         //variable used for square yards
            int Fertilizer,         //variable used for if the customer want fertilizer or not
                Garden;             //variable used for if it is the customers first garden or not

            MaxWidth = double.Parse(MaxWidthTextBox.Text);      //collects value for MaxWidth from user
            MaxLength = double.Parse(MaxLengthTextBox.Text);    //collects value for MaxLength from user
            SoilPrice = double.Parse(SoilPriceTextBox.Text);    //collects value for SoilPrice from user
            Fertilizer = int.Parse(FertilizerTextBox.Text);     //collects value for Fertilizer from user
            Garden = int.Parse(FirstGardenTextBox.Text);        //collects value for Garden from user

            SqYards = (MaxWidth * MaxLength) / sqftTosqyards;                                       //assigns SqYards value by multiplying Width and Length and then dividing result by constant 9
            SquareYardsoutputLabel.Text = SqYards.ToString("F1");                                   //outputs Sqyards into Label with 1 digit of precision

            SoilCost = (SoilPrice * SqYards) * WastePercent;                                        //assigns SoilCost value by muiltiplying Soilprice(per sq yard) and SqYards and then multiplying by WastePercent
            SoilCostoutputLabel.Text = SoilCost.ToString("C",CultureInfo.GetCultureInfo("en-US"));  //outputs SoilCost into Label with currency formatting

            FertilizerCost = 0; //initializes FertilizerCost variable
            if (Fertilizer == 0){    //beginning of if statement
                FertilizerCostoutputLabel.Text = "$0.00";                                           //if statement used for if Fertilizer value is 0 output is set to $0.00 and outputs it to FertilizerCostoutputLabel
            }//ending of if statement
            else if(Fertilizer == 1){//beginning of elseif statement
                FertilizerCost = (SqYards * Fertilizerprice);                                       //assigns FertilzerCost value by multiplying Sqyards and Fertilizer price constant
                FertilizerCostoutputLabel.Text = FertilizerCost.ToString("C", CultureInfo.GetCultureInfo("en-US")); //elseif statement is used for if Fertilizer value is 1 output is set to FertilizerCost and outputs it to FerilizerCostoutputLabel
            }//ending of elseif statment

            LaborCost = (SqYards * LaborCostconst); //assigns Laborcost value by multiplying SqYards and LaberCost constant
            if(Garden == 0){//beginning of if statement
                LaborCostoutputLabel.Text = LaborCost.ToString("C", CultureInfo.GetCultureInfo("en-US")); //if statement is used for if the garden value is 0 output is set to LaborCost and outputs it to LaborCostoutputLabel
            }//ending of if statement
            else if(Garden == 1) {//beginning of elseif statement
                LaborCost = LaborCost + firstgardenfee; //computes LaborCost by adding LaborCost and firstgardenfee
                LaborCostoutputLabel.Text = LaborCost.ToString("C", CultureInfo.GetCultureInfo("en-US")); //elseif statement is used for if the garden value is 1 output is set to LaborCost plus firstgardenfee and outputs it to LaborCostoutputLabel
            }//ending of elseif statement

                TotalCost = SoilCost + FertilizerCost + LaborCost; //computes TotalCost by adding SoilCost, FertilizerCost, and LaborCost
                TotalCostoutputLabel.Text = TotalCost.ToString("C", CultureInfo.GetCultureInfo("en-US")); //outputs TotalCost to TotalCostoutputLabel


        }
    }
}
