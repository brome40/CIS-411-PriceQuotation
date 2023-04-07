using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage = "Please enter a sales price.")]
        [Range(0.0, Int32.MaxValue, ErrorMessage =
               "Sales price must be greater than 0.")]
        public decimal? SalesPrice { get; set; }

        [Required(ErrorMessage = "Please enter a discount rate.")]
        [Range(0.0, 100.0, ErrorMessage =
               "Discount rate must be between 0 and 100.")]
        public decimal? DiscountRate { get; set; }

        public decimal? CalculateDiscount()
        {
            decimal? discount = SalesPrice * (DiscountRate / 100.0m);
            return discount;
        }

        public decimal? CalculateTotalCost()
        {
            return SalesPrice * CalculateDiscount();
        }
    }
}
