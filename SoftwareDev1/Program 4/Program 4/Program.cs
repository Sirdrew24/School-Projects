/*  Program 4
    CIS 199-01
    Due: 04/18/2021
    Grading ID: R0189

    Description: This program represents a record of the repair that car repair technicians may carry out
                 at an automobile repair company
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_4
{
    class Program
    {
        static void Main(string[] args)
        {
            RepairRecord[] Repair = new RepairRecord[6];//creates an array with 6 objects
            Repair[0] = new RepairRecord(41051, "Ford F150", "C493768459", 2011, 45, "Bob Jones", false);
            Repair[1] = new RepairRecord(40203, "Toyota Matrix", "C857395785", 2005, 60, "Monica Fitzgerald", true);
            Repair[2] = new RepairRecord(40202, "Telsa Model 3", "C583953958", 2019, 15, "Bob Jones", false);               //data sent to RepairRecord class to output Repair records
            Repair[3] = new RepairRecord(40208, "Mclaren F1", "C968486749", 2020, 120, "Mike Lewis", true);
            Repair[4] = new RepairRecord(40212, "Gallifreyan Tardis", "C968857575", 2500, 150, "The Doctor", true);
            Repair[5] = new RepairRecord(40211, "Correllian Tie Fighter", "C565756555", 3600, 80, "Luke Skywalker", false);
            RepairRecord.OutputRepairRecords(Repair);//invokes OutputRepairRecords Method

            WriteLine("After Change:\n");
            Repair[0] = new RepairRecord(50121, "Ford F150", "C493768459", 2011, 45, "Bob Jones", false);
            Repair[1] = new RepairRecord(40203, "Chevy Silverado", "C857395785", 2005, 60, "Monica Fitzgerald", true);
            Repair[2] = new RepairRecord(40202, "Telsa Model 3", "C583953958", 2019, 15, "Bob Jones", false);               //modified data sent to RepairRecord class to output Repair records
            Repair[3] = new RepairRecord(40208, "Mclaren F1", "C968525749", 2020, 100, "Mike Lewis", true);
            Repair[4] = new RepairRecord(40212, "Gallifreyan Tardis", "C968857575", 2400, 150, "The Doctor", true);
            Repair[5] = new RepairRecord(40211, "T-65 X-Wing", "C565756555", 3600, 80, "Luke Skywalker", false);
            RepairRecord.OutputRepairRecords(Repair);//invokes OutputRepairRecords Method
        }
    }
}
