using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
	public class TipCalculatorModel
	{
		public const double tipPercent1 = .15;
		public const double tipPercent2 = .20;
		public const double tipPercent3 = .25;

		// Validation for CostOfMeal field
		[Required(ErrorMessage = "Please enter the cost of meal")]
		[Range(0, double.MaxValue, ErrorMessage = "Cost of meal must be greater than 0")]
		public double CostOfMeal { get; set; } // generic getter and setter for CostOfMeal field

		public double Percent15Tip()
		{
			double TipAmount = CostOfMeal * tipPercent1;
			return TipAmount;
		}

		public double Percent20Tip() 
		{
			double TipAmount = CostOfMeal * tipPercent2;
			return TipAmount;
		}

		public double Percent25Tip()
		{
			double TipAmount = CostOfMeal * tipPercent3;
			return TipAmount;
		}
	}
}
