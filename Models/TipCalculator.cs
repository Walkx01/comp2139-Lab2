using System.ComponentModel.DataAnnotations;

namespace lab2.Models
{
    public class TipCalculator
    {
        [Required (ErrorMessage ="Please enter a value for the cost of the meal")]
        [Range(0.0, 1000.0, ErrorMessage ="cost of meal must be greater than 0 and less or equal to $1000")]
       public double? MealCost { get; set; }

        public double calculateTip( double percent)
        {
            if (MealCost.HasValue)
            {
                var tip = MealCost.Value * percent;
                return tip;
            }
            else
            {
                return 0.0;
            }
        }

      
    }
}
