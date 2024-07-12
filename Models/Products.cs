using System.ComponentModel.DataAnnotations;

namespace SupplyTracker.Models
{
    public class Products
    {
        /// <summary>
        /// The ID of product
        /// </summary>
        [Key]
        public int ProductID { get; set; }

        /// <summary>
        /// The name of product
        /// </summary>
        [Required(ErrorMessage ="Please input the product's name")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        /// <summary>
        /// The lot number of the product
        /// </summary>
        [Required(ErrorMessage = "Please input the lot number")]
        [Display(Name = "Lot number")]
        [Range(0,double.MaxValue)]
        public int LotNumber { get; set; }

        /// <summary>
        /// The price of product
        /// </summary>
        [Required(ErrorMessage = "Please input the price")]
        [DataType(DataType.Currency)]
        [Range(0, double.MaxValue)]
        public double Price { get; set; }

        /// <summary>
        /// The unit of supply for the product
        /// </summary>
        [Required(ErrorMessage = "Please input the unit of supply")]
        [Display(Name = "Unit of Supply")]
        public string UnitOfSupply { get; set; }

        /// <summary>
        /// The date of product's production
        /// </summary>
        [Required(ErrorMessage = "Please input the date of product's production")]
        [Display(Name = "Production date")]
        [DataType(DataType.Date)]
        public DateTime DateOfProduct { get; set; }

        /// <summary>
        /// The date of product's expiration
        /// </summary>
        [Required(ErrorMessage = "Please input the date of product's expiration")]
        [Display(Name = "Expiration date")]
        [DataType(DataType.Date)]
        public DateTime DateOfExpire { get; set; }

        /// <summary>
        /// The category code of product
        /// </summary>
        [Required(ErrorMessage = "Please input the product category code")]
        [Display(Name = "Category Code")]
        public int ProductCategoryCode { get; set; }

        /// <summary>
        /// The vendor code for product
        /// </summary>
        [Required(ErrorMessage = "Please input the vendor code")]
        [Display(Name = "Vendor Code")]
        public int VendorCode { get; set; }
    }
}
