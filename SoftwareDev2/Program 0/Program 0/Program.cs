﻿/* Brendon Carter
 * Program 0
 * CIS 200-75
 * Due: 9/7/2022
 * 
 * Description: This program creates an Address class, a Parcel class, and a Letter class that inherits from Parcel. The object of this program is to 
 *              show how inheritance works and do that by creating letters that will have to and from address' on them. Override methods such as the
 *              ToString method and creating a CalcCost method are used in this program as well.
 */
using static System.Console;

namespace Program_0
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

            Letter l1 = new(a1, a3, 0.50M); // Test Letter 1
            Letter l2 = new(a2, a4, 1.20M); // Test Letter 2
            Letter l3 = new(a4, a1, 1.70M); // Test Letter 3

            List<Parcel> parcels = new List<Parcel> { l1, l2, l3 }; // Test list of parcels

            //Disaply data
            WriteLine("Program 0 - List of Parcels\n");

            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("--------------------");
            }
        }
    }
}