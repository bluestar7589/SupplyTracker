using System.ComponentModel.DataAnnotations;

namespace SupplyTracker.Models
{
    public class Customers
    {
        /// <summary>
        /// The unique ID of customer
        /// </summary>
        [Key]
        public int CustomerID { get; set; }


        /// <summary>
        /// First name of customer
        /// </summary>
        [Required(ErrorMessage ="Please input your first name")]
        [Display(Name ="First Name")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string FirstName { get; set; }


        /// <summary>
        /// Last name of customer
        /// </summary>
        [Required(ErrorMessage = "Please input your last name")]
        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string LastName { get; set; }


        /// <summary>
        /// Department's code where customer works
        /// </summary>
        [Required(ErrorMessage = "Please input your department code")]
        [Display(Name = "Department Code")]
        [DataType(DataType.Text)]
        public int DepartmentCode { get; set; }


        /// <summary>
        /// Customer's phone number
        /// </summary>
        [Required(ErrorMessage = "Please input your phone number")]
        [Display(Name = "Phone number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Customer's position
        /// </summary>
        [Required(ErrorMessage = "Please input your position")]
        public string Position { get; set; }

    }
}
