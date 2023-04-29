using Microsoft.AspNetCore.Mvc;
using QuarterlySalesApp.Models.Validation;
using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace QuarterlySalesApp.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Please enter the employee's first name.")]
        [StringLength (100)]
        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please enter the employee's last name.")]
        [StringLength(100)]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Please enter the employee's date of birth.")]
        [PastDate(ErrorMessage = "Birth date must be a valid date that's in the past.")]
        [Remote("CheckEmployee", "Validation", AdditionalFields = "Firstname, Lastname")]
        [Display(Name = "Birth Date")]
        public DateTime? DOB { get; set; }

        [Required(ErrorMessage = "Please enter the employee's date of hire.")]
        [PastDate(ErrorMessage = "Hire date must be a valid date that's in the past.")]
        //[GreaterThan("1/1/1995", ErrorMessage = "Hire date can't be before company was founded.")]
        [Display(Name = "Hire Date")]
        public DateTime? DateOfHire { get; set; }

        //[GreaterThan(0, ErrorMessage = "Please select a manager.")]
        [Remote("CheckManger", "Validation", AdditionalFields = "Firstname, Lastname, DOB")]
        [Display(Name = "Manager")]
        public int ManagerId { get; set; }

        public string Fullname
        {
            get { return $"{Firstname} {Lastname}"; }
        }
    }
}
