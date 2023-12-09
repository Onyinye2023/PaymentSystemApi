using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace PaymentSystem.Api.DTOs
{
    public class MerchantRequestDTO
    {
        [Required]
        [StringLength(11)]
        public string MerchantNumber { get; set; }
        [Required]
        public string BusinessIdNumber { get; set; }
        [Required]
        public string BusinessName { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string MerchantName { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string MerchantSurname { get; set; }
        
        [Required(ErrorMessage = "Please enter the date of business establishment.")]
        //[DataType(DataType.Date)]
        //[DateOfEstablishment(ErrorMessage = "Business establishment date must be a year or more in the past.")]
        public DateTime DateOfEstablishment { get; set; }
        
        public decimal AverageTransactionVolume { get; set; }
    }
}
