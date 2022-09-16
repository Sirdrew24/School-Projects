using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_4
{
    class RepairRecord
    {
        private int _zip;
        private string _makeandmodel;
        private string _serialnum;
        private int _year;              //Declaration of variables (backing fields)
        private int _appointmenttime;
        private string _techname;
        private bool _warranty;

        public const int MIN_ZIP = 00000;
        public const int MAX_ZIP = 99999;
        public const int DEFAULT_ZIP = 40204;
        public const string DEFAULT_MAKEMODEL = "Unknown Make/Model";
        public const string DEFAULT_SERIAL = "A000000000";              //Constants used for validation and setting default values
        public const string DEFAULT_TECH = "John Smith";
        public const int MIN_APPOINTMENTTIME = 15;
        public const int MAX_APPOINTMENTTIME = 180;
        public const int DEFAULT_APPOINTMENTTIME = 30;

        //Precondition: 00000 <= z <= 99999, m is not blank, s = 10 characters, y >= 0, 15 <= a <= 180, t is not blank
        //Postcondition: The repair record has been initialized with the specified values for zip,
        //               make/model, serial number, year, appointment time, technician name, and warranty 
        public RepairRecord (int z, string m, string s, int y, int a, string t, bool w)
        {
            Zip = z;
            MakeandModel = m;
            Serialnum = s;
            Year = y;
            Appointmenttime = a;
            Techname = t;
            Warranty = w;
        }

        public int Zip
        {
            //Precondition: None
            //Postcondition: The value of _zip is returned
            get 
            { 
                return _zip;
            }

            //Precondition: 00000 <= value <= 99999
            //Postcondition: The _zip variable has been set to the value given
            set
            {
                if (value >= MIN_ZIP && value <= MAX_ZIP)
                    _zip = value;
                else
                    _zip = DEFAULT_ZIP;
            }
        }

        public string MakeandModel
        {
            //Precondition: None
            //Postcondition: The value of _makeandmodel is returned
            get
            {
                return _makeandmodel;
            }

            //Precondition: Value is not blank or is not a string
            //Postcondition: The _makeandmodel variable has been set to the value given
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _makeandmodel = value;
                else
                    _makeandmodel = DEFAULT_MAKEMODEL;
            }
        }

        public string Serialnum
        {
            //Precondition: None
            //Postcondition: The value of _serialnum is returned
            get
            {
                return _serialnum;
            }

            //Precondition: Value is 10 characters
            //Postcondition: The _serialnum variable has been set to the value given
            set
            {
                if (value.Length == 10)
                    _serialnum = value;
                else
                    _serialnum = DEFAULT_SERIAL;
            }
        }

        public int Year
        {
            //Precondition: None
            //Postcondition: The value of _year is returned
            get
            {
                return _year;
            }
            //Precondition: Value >= 0
            //Postcondition: The _year variable has been set to the value given
            set
            {
                if (value >= 0)
                    _year = value;
            }
        }

        public int Appointmenttime
        {
            //Precondition: None
            //Postcondition: The value of _appointmenttime is returned
            get
            {
                return _appointmenttime;
            }

            //Precondition: 15 <= value <= 180
            //Postcondition: The _appointmenttime variable has been set to the value given
            set
            {
                if (value >= 15 && value <= 180)
                    _appointmenttime = value;
                else
                    _appointmenttime = DEFAULT_APPOINTMENTTIME;
            }
        }

        public string Techname
        {
            //Precondition: None
            //Postcondition: The value of _techname is returned
            get
            {
                return _techname;
            }

            //Precondition: Value is not blank or is not a string
            //Postcondition: The _techname variable has been set to the value given
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _techname = value;
                else
                    _techname = DEFAULT_TECH;
            }
        }

        public bool Warranty
        {
            //Precondition: None
            //Postcondition: The value of _warranty is returned
            get
            {
                return _warranty;
            }

            //Precondition: Value must be True or False
            //Postcondition: The _warranty variable is set to the value given (true or false)
            set
            {
                _warranty = value;
            }
        }

        public double AppointmentHours
        {
            get
            {
                return Convert.ToDouble(_appointmenttime) / 60;
            }
        }
        //Precondition: None
        //Postcondition: A cost is returned that represents the cost of the appointment
        public double CalcCost()
        {
            double cost;
            const double COST_WITHOUT_WARRANTY = 25.00;
            const double COST_WITH_WARRANTY = 20.00;
            const double RATE_WITHOUT_WARRANTY = 1.50;

            if (Warranty == false)
                cost = COST_WITHOUT_WARRANTY + RATE_WITHOUT_WARRANTY * Appointmenttime;
            else
                cost = COST_WITH_WARRANTY;

            return cost;
        }

        //Precondition: None
        //Postcondition: A string is returned representing the repair record
        public override string ToString()
        {
            string result;

            result = $"Service Location Zip Code: {Zip}\n" +
                $"Year: {Year}\n" +
                $"Make and Model: {MakeandModel}\n" +
                $"Serial Number: {Serialnum}\n" +
                $"Appointment Length: {Appointmenttime}\n" +
                $"Appointment Hours: {AppointmentHours}\n" +
                $"Technician Name: {Techname}\n" +
                $"Waranty Coverage?: {Warranty}\n" +
                $"Calcualte Cost Output: {CalcCost()}\n";

            return result;
        }

        //Precondition: None
        //Postcondition: A message is shown to the user that contains all of the repair records that are stored
        public static void OutputRepairRecords(RepairRecord[] Repair)
        {
            for (int i = 0; i < Repair.Length; i++)
            {
                WriteLine(Repair[i].ToString());
            }
        }
    }
}
