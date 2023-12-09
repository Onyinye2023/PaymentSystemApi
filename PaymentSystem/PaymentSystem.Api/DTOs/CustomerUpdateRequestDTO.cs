﻿namespace PaymentSystem.Api.DTOs
{
    public class CustomerUpdateRequestDTO
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public int TransactionHistory { get; set; }
    }
}
