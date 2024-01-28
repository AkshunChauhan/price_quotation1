using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class PriceQuotationModel
    {
        // Required attribute to ensure SalesPrice is provided
        [Required(ErrorMessage = "Sales price is required.")]
        // Range attribute to specify the valid range for SalesPrice
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a valid number greater than 0.")]
        public decimal SalesPrice { get; set; }

        // Required attribute to ensure DiscountPercent is provided
        [Required(ErrorMessage = "Discount percent is required.")]
        // Range attribute to specify the valid range for DiscountPercent
        [Range(0, 100, ErrorMessage = "Please enter a valid number between 0 and 100.")]
        public decimal DiscountPercent { get; set; }

        // Calculated property to get the discount amount
        public decimal DiscountAmount => SalesPrice * (DiscountPercent / 100);

        // Calculated property to get the total after discount
        public decimal Total => SalesPrice - DiscountAmount;
    }
}
