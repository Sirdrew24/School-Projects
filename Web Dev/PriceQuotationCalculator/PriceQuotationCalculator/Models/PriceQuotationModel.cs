using System.ComponentModel.DataAnnotations;

namespace PriceQuotationCalculator.Models
{
	public class PriceQuotationModel
	{
		// Validation for Subtotal field
		[Required(ErrorMessage = "Please enter a subtotal.")]
		[Range(1,double.MaxValue, ErrorMessage ="Subtotal must be greater than 0.")]
		public double Subtotal { get; set; } // generic getter and setter for Subtotal field

		// Validation for DiscountPercent field
		[Required(ErrorMessage ="Please enter a discount percentage.")]
		[Range(1,100, ErrorMessage ="Discount percent must be between 1 and 100.")]
		public double DiscountPercent { get; set; } // generic getter and setter for DiscountPercent field

		public double CalculateDiscountAmount()
		{
			double DiscountAmount;
			DiscountAmount = DiscountPercent/100 * Subtotal;

			return DiscountAmount;
		}
		public double CalculateTotal()
		{
			double DiscountAmount, Total;
			DiscountAmount = DiscountPercent/100 * Subtotal;
			Total = Subtotal - DiscountAmount;

			return Total;
		}
	}
}
