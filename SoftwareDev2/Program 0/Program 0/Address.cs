using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public class Address
    {
        public const int MIN_ZIP = 0;
        public const int MAX_ZIP = 99999;

        private string _name;
        private string _addressline1;
        private string _addressline2;
        private string _city;
        private string _state;
        private int _zip;

        // Precondition:  name, addressline1, city, state may not be null empty nor all whitespace
        // Postcondition: The address is created with specified values for name, addressline1, addressline2, city, state, and zip.
        public Address(string name, string addressline1, string addressline2, string city, string state, int zip)
        {
            Name = name;
            Addressline1 = addressline1;
            Addressline2 = addressline2;
            City = city;
            State = state;
            Zip = zip;
        }

        public Address(string name, string addressline1, string city, string state, int zipcode) : this(name, addressline1, string.Empty, city, state, zipcode)
        {
            // No body needed
            // Calls previous constructor sending empty string for addressline2
        }

        public string Name
        {
            // Precondition:  None
            // Postcondition: The address' name has been returned
            get { return _name; }

            // Precondition:  Value must not be null, empty nor all whitespace
            // Postcondition: The address' name has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException($"{nameof(Name)}", value, $"{nameof(Name)} must not be empty");
                else
                    _name = value.Trim();
            }
        }
        public string Addressline1
        {
            // Precondition:  None
            // Postcondition: The address' first address line has been returned
            get { return _addressline1; }

            // Precondition:  Value must not be null, empty nor whitespace
            // Postcondition: The address' first address line has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException($"{nameof(Addressline1)}", value, $"{nameof(Addressline1)} must not be empty");
                else
                    _addressline1 = value.Trim();
            }
        }
        public string Addressline2
        {
            // Precondition:  None
            // Postcondition: The address' second address line has been returned
            get { return _addressline2; }

            // Precondition:  None
            // Postcondition: The address' second address line has been set to the specified value
            set
            {
                if (value == null) // Just in case
                    value = string.Empty;
                else
                    _addressline2 = value.Trim();
            }
        }
        public string City
        {
            // Precondition:  None
            // Postcondition: The address' city has been returned
            get { return _city; }

            // Precondition:  Value can not be null, empty nor whitespace
            // Postcondition: The address' city has been set to the specified value
            set 
            {
                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException($"{nameof(City)}", value, $"{nameof(City)} must not be empty");
                else
                    _city = value.Trim();
            }
        }
        public string State
        {
            // Precondition:  None
            // Postcondition: The address' state has been returned
            get { return _state; }

            // Precondition:  Value can not be null, empty nor whitespace
            // Postcondition: The address' state has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException($"{nameof(State)}", value, $"{nameof(State)} must not be empty");
                else
                    _state = value.Trim();
            }
        }
        public int Zip
        {
            // Precondition:  None
            // Postcondition: The address' zip code has been returned
            get { return _zip; }
            
            // Precondition:  MIN_ZIP <= value <= MAX_ZIP
            // Postcondition: The address' zip code has been set to the specified value
            set
            {
                if (_zip < MIN_ZIP || _zip > MAX_ZIP)
                    throw new ArgumentOutOfRangeException($"{nameof(Zip)}", value, $"{nameof(Zip)} must be U.S. 5 digit zip code");
                else
                    _zip = value;
            }
        }

        public override string ToString()
        {
            string NL = Environment.NewLine;
            string result;

            result = $"{Name}{NL}{Addressline1}{NL}";

            if (!string.IsNullOrWhiteSpace(Addressline2))
                result += $"{Addressline2}{NL}";

            result += $"{City}, {State}, {Zip:D5}";

            return result;
        }
    }
}