using System.ComponentModel.DataAnnotations;

namespace PaymentSystem.Api.DTOs
{
    public class CustomerRequestDTO
    {
        [Required]
        [StringLength(11)]
        public string NationalId { get; set; }
       
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string CustomerName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string CustomerSurname { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(11)]
        public string PhoneNumber { get; set; }
        public int TransactionHistory { get; set; }
    }
}
