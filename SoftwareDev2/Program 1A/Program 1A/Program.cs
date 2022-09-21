/* Brendon Carter
 * Program 1A
 * CIS 200-75
 * Due: 9/7/2022
 * 
 * Description: This program creates an Address class, a Parcel class, and a Letter class that inherits from Parcel. The object of this program is to 
 *              show how inheritance works and do that by creating letters that will have to and from address' on them. Override methods such as the
 *              ToString method and creating a CalcCost method are used in this program as well.
 */
using System.Diagnostics.Metrics;
using System.Net;
using static System.Console;

namespace Program_1A
{
    class Program
    {
        // Precondition:  None
        // PostCondition: Small list of Parcels is created and displayed

        static void Main(string[] args)
        {
            Address a1 = new("John Smith", "123 Any St.", "Apt. 45", "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new("Jane Doe", "987 Main St.", "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new("James Kirk", "654 Roddenberry Way", "Suite 321", "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new("John Crichton", "678 Pau Place", "Apt. 7", "Portland", "ME", 04101); // Test Address 4

            Letter l1 = new(a1, a2, 3.95M); // Test letter 
            GroundPackage gp1 = new(a3, a4, 14, 10, 5, 12.5); // Test ground package
            NextDayAirPackage ndap1 = new(a1, a3, 25, 15, 15, 85, 7.50M); // Test next day air package
            TwoDayAirPackage tdap1 = new(a4, a1, 46.5, 39.5, 28.0, 80.5, TwoDayAirPackage.Delivery.Saver); // Test two day air package

            List<Parcel> parcels = new(); // Test list of parcels

            parcels.Add(l1);
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(tdap1);

            //Disaply data
            WriteLine("Original List:");
            WriteLine("====================");

            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
        }
    }
}