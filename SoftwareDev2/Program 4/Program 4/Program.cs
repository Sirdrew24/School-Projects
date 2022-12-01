/* Brendon Carter
 * Program 1B
 * CIS 200-75
 * Due: 10/12/2022
 * 
 * Description: This program Uses the classes that were created in program 0 and program 1A to add a linq query to them. The object of this program is to 
 *              build off of program 0 and program 1A by using linq to query through parcels that are created. Override methods such as the
 *              ToString method and a CalcCost method are used in this program as well.
 */
using System.Diagnostics.Metrics;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Text;
using static System.Console;
using System.Security.Cryptography.X509Certificates;

namespace Program_4
{
    class Program
    {
        // Precondition:  None
        // PostCondition: Small list of Parcels is created and displayed

        static void Main(string[] args)
        {
            // Verbose setting - true means complete output of parcel data
            //                   false means only relevant data output
            bool VERBOSE = false;

            Address a1 = new("John Smith", "123 Any St.", "Apt. 45", "Louisville", "KY", 40202);            // Test Address 1
            Address a2 = new("Jane Doe", "987 Main St.", "Beverly Hills", "CA", 90210);                     // Test Address 2
            Address a3 = new("James Kirk", "654 Roddenberry Way", "Suite 321", "El Paso", "TX", 79901);     // Test Address 3
            Address a4 = new("John Crichton", "678 Pau Place", "Apt. 7", "Portland", "ME", 04101);          // Test Address 4
            Address a5 = new("Bob Burgers", "1234 Place", "Boston", "MA", 12345);                           // Test Address 5
            Address a6 = new("Brendon", "123 down St.", "Apt. 24", "Louisville", "KY", 97654);              // Test Address 6
            Address a7 = new("Karen", "Green Ave.", "Boston", "MA", 59467);                                 // Test Address 7
            Address a8 = new("Bob Kirk", "Great Place","Apt. 5", "Indianapolis", "IN", 12345);              // Test Address 8


            Letter l1 = new(a1, a2, 3.95M);                                                                 // Test letter 1
            Letter l2 = new(a3, a4, 4.25M);                                                                 // Test letter 2
            GroundPackage gp1 = new(a5, a6, 14, 10, 5, 12.5);                                               // Test ground package 1
            GroundPackage gp2 = new(a7, a8, 8.5, 9.5, 6.5, 2.5);                                            // Test ground package 2
            NextDayAirPackage ndap1 = new(a1, a3, 25, 15, 15, 85, 7.50M);                                   // Test next day air package 1
            NextDayAirPackage ndap2 = new(a3, a5, 9.5, 6.0, 5.5, 5.25, 5.25M);                              // Test next day air package 2
            TwoDayAirPackage tdap1 = new(a4, a1, 46.5, 39.5, 28.0, 80.5, TwoDayAirPackage.Delivery.Saver);  // Test two day air package 1
            TwoDayAirPackage tdap2 = new(a8, a1, 15.0, 9.5, 6.5, 75.5, TwoDayAirPackage.Delivery.Early);    // Test two day air package 2
            TwoDayAirPackage tdap3 = new(a6, a4, 12.0, 12.0, 6.0, 5.5, TwoDayAirPackage.Delivery.Saver);    // Test two day air package 3

            List<Parcel> parcels = new(); // Test list of parcels

            parcels.Add(l1);
            parcels.Add(l2);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(tdap1);
            parcels.Add(tdap2);
            parcels.Add(tdap3);

            //Disaply data
            WriteLine("Original List:");
            WriteLine("====================");

            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();

            // Parcels by Destination Zip (desc)
            var parcelsByDestZip =
                from p in parcels
                orderby p.DestinationAddress.Zip descending
                select p;

            WriteLine("Parcels by Destination Zip (desc):");
            WriteLine("====================");

            foreach (Parcel p in parcelsByDestZip)
            {
                if (VERBOSE)
                {
                    WriteLine(p);
                    WriteLine("====================");
                }
                else
                    WriteLine($"{p.DestinationAddress.Zip:D5}");
            }
            Pause();

            // Parcels by cost
            var parcelsByCost =
                from p in parcels
                orderby p.CalcCost()
                select p;

            WriteLine("Parcels by Cost:");
            WriteLine("====================");

            foreach (Parcel p in parcelsByCost)
            {
                if (VERBOSE)
                {
                    WriteLine(p);
                    WriteLine("====================");
                }
                else
                    WriteLine($"{p.CalcCost(),8:C}");
            }
            Pause();

            // Parcels by type and cost (desc)
            var parcelsByTypeCost =
                from p in parcels
                orderby p.GetType().ToString(), p.CalcCost() descending
                select p;

            WriteLine("Parcels by Type and Cost (desc):");
            WriteLine("====================");

            foreach (Parcel p in parcelsByTypeCost)
            {
                if (VERBOSE)
                {
                    WriteLine(p);
                    WriteLine("====================");
                }
                else
                    WriteLine($"{p.GetType().ToString(), -17} {p.CalcCost(), 8:C}");
            }
            Pause();

            // Heavy AirPackages by Weight (desc)
            var heavyAirPackagesByWeight =
                from p in parcels
                let ap = p as AirPackage // Downcast if AirPackage, null otherwise
                where (ap != null) && ap.IsHeavy() // Safe becuase of short-circuit
                orderby ap.Weight descending
                select ap;

            WriteLine("Heavy AirPackages by Weight (desc):");
            WriteLine("====================");

            foreach (AirPackage ap in heavyAirPackagesByWeight)
            {
                if (VERBOSE)
                {
                    WriteLine(ap);
                    WriteLine("====================");
                }
                else
                    WriteLine("{0,-17} {1,4:F1}", ap.GetType().ToString(), ap.Weight);
            }
        }

        // Precondition:  None
        // Postcondition: Pauses program execution until the user presses Enter and then clears the screen
        public static void Pause()
        {
            WriteLine("Press Enter to Continue...");
            ReadLine();

            Clear(); // Clear screen
        }
    }
}