namespace PaymentSystem.Api.DTOs
{
    public class MerchantUpdateRequestDTO
    {
        public string BusinessIdNumber { get; set; }
        public string BusinessName { get; set; }
        public string MerchantName { get; set; }
        public string MerchantSurname { get; set; }
        public DateTime DateOfEstablishment { get; set; }
        public decimal AverageTransactionVolume { get; set; }
    }
}
