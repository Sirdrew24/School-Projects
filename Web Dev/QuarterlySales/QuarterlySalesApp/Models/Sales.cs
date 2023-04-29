using System.ComponentModel.DataAnnotations;

namespace QuarterlySalesApp.Models
{
    public class Sales
    {
        public Employee Employee { get; set; }
        public int SalesId { get; set; }

        [Required(ErrorMessage = "Please enter the sales quarter.")]
        [Range(1, 4, ErrorMessage = "Please enter a valid quarter between 1 and 4.")]
        public int Quarter { get; set; }

        [Required(ErrorMessage = "Please enter the sales year.")]
        [Range(2001, int.MaxValue, ErrorMessage = "Please enter a valid year.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Please enter the sales amount.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a valid amount greater than 0.")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Please enter the employee ID.")]
        public int EmployeeId { get; set; }
    }
}
