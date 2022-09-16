/*Program 2
  CIS 199-01
  Due 03/11/2021
  Grading ID: R0189

  This program collects the data needed to create a catering order through 3 different companys (A, B, and C). This program takes the data
  and then calculates how much each company would cost and shows which company would be the least expensive.
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

namespace Program_2
{
    public partial class Form1 : Form
    {
        //Company A const
        const int costperperson_A = 1,
                  deliveryday1_A = 20,
                  deliveryday2_A = 17,
                  deliveryday3_A = 15,
                  deliveryday4567_A = 10,
                  deliveryday7plus_A = 7;
        const double costpermile_A = .02;
        //Company B const
        const int deliveryday1234_B = 10,
                  deliveryday4plus_B = 7;
        const double costpermile_B = .10,
                     costperpersonunder10_B = 20,
                     costperperson10to50_B = 10,
                     costperperson50to100_B = 5,
                     costperperson100to200_B = 3,
                     costperperson200plus_B = .15;
        //Company C const
        const int deliverycost_C = 20;
        const double costfor1000mileplus_C = 40,
                     costfor750to1000miles_C = 35,
                     costfor500to750miles_C = 25,
                     costfor200to500miles_C = 15,
                     costfor0to200miles_C = 10,
                     costperperson_C = .25;
        //variables used to collect inputs from user and variable used to calculate the cost for each company
        int numpeople,
            deliverydays,
            deliverycostA,
            deliveryCostB;
        double distance,
               CompanyACost,
               CompanyBCost,
               costperpersonB,
               CompanyCCost,
               distancecostC;
        //const variables used when tryparsing the inputs from the users
        const int minpeople = 1,
                  mindeliverydays = 1;
        const double mindistance = 0.0;
        public Form1()
        {
            InitializeComponent();
        }
        //click event used to calculate the prices for each company and show which one is the cheapest
        private void Calcbutton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Peopletextbox.Text, out numpeople) && (numpeople >= minpeople))//decides if input for people is valid
            {

            }
            else
            {
                MessageBox.Show("Invalid Value for People");//if people is invalid prompts user
            }
            
            if (double.TryParse(Distancetextbox.Text, out distance) && (distance >= mindistance))//decides if input for distance is valid
            {

            }
            else
            {
                MessageBox.Show("Invalid Value for distance");//if distance is invalid prompts user
            }
            
            if (int.TryParse(Deliverydaytextbox.Text, out deliverydays) && (deliverydays >= mindeliverydays))//decides if input for delivery days is valid
            {

            }
            else
            {
                MessageBox.Show("Invalid Value for delivery days");//if delivery days is invalid prompts user
            }

            //calculations for Company A
            if (deliverydays == 1)
            {
                deliverycostA = deliveryday1_A;
            }
            else if (deliverydays == 2)
            {
                deliverycostA = deliveryday2_A;
            }
            else if (deliverydays == 3)
            {
                deliverycostA = deliveryday3_A;
            }
            else if (deliverydays > 3 && deliverydays < 7 )
            {
                deliverycostA = deliveryday4567_A;
            }
            else
            {
                deliverycostA = deliveryday7plus_A;
            }

            CompanyACost = (numpeople * costperperson_A) + (distance * costpermile_A) + deliverycostA;//calculates the total cost for Company A
            CompanyAoutputlabel.Text = CompanyACost.ToString("C",CultureInfo.GetCultureInfo("en-US"));//displays the CompanyA cost

            //calculations for Company B
            if (numpeople >= 200)
            {
                costperpersonB = costperperson200plus_B;
            }
            else if (numpeople >= 100)
            {
                costperpersonB = costperperson100to200_B;
            }
            else if (numpeople >= 50)
            {
                costperpersonB = costperperson50to100_B;
            }
            else if (numpeople >= 10)
            {
                costperpersonB = costperperson10to50_B;
            }
            else
            {
                costperpersonB = costperpersonunder10_B;
            }

            if (deliverydays <= 4)
            {
                deliveryCostB = deliveryday1234_B;
            }
            else
            {
                deliveryCostB = deliveryday4plus_B;
            }

            CompanyBCost = (numpeople * costperpersonB) + deliveryCostB + (distance * costpermile_B);//calculates the total cost for Company B
            CompanyBoutputlabel.Text = CompanyBCost.ToString("C",CultureInfo.GetCultureInfo("en-US"));//displays the CompanyB cost

            //calculations for Company C
            if (distance >= 1000)
            {
                distancecostC = costfor1000mileplus_C;
            }
            else if (distance >= 750)
            {
                distancecostC = costfor750to1000miles_C;
            }
            else if (distance >= 500)
            {
                distancecostC = costfor500to750miles_C;
            }
            else if (distance >= 200)
            {
                distancecostC = costfor200to500miles_C;
            }
            else
            {
                distancecostC = costfor0to200miles_C;
            }

            CompanyCCost = (numpeople * costperperson_C) + deliverycost_C + distancecostC;//calculates the total cost for Company C
            CompanyCoutputlabel.Text = CompanyCCost.ToString("C", CultureInfo.GetCultureInfo("en-US"));//displays the CompanyC cost

            //if statements to decide which Company is cheapest

            if (CompanyACost < CompanyBCost && CompanyACost < CompanyCCost)
            {
                LowestCompanyoutputlabel.Text = "The lowest cost company is: A";
            }
            else if (CompanyBCost < CompanyACost && CompanyBCost < CompanyCCost)
            {
                LowestCompanyoutputlabel.Text = "The lowest cost company is: B";
            }
            else
            {
                LowestCompanyoutputlabel.Text = "The lowest cost company is: C";
            }
        }   
    }
}
