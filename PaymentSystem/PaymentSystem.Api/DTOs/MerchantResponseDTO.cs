namespace PaymentSystem.Api.DTOs
{
    public class MerchantResponseDTO
    {
        public string MerchantNumber { get; set; }
        public string BusinessIdNumber { get; set; }
        public string BusinessName { get; set; }
        public string MerchantName { get; set; }
        public string MerchantSurname { get; set; }
        public DateTime DateOfEstablishment { get; set; }
        public decimal AverageTransactionVolume { get; set; }
    }
}
