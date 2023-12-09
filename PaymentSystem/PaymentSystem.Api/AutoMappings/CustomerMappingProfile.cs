using AutoMapper;
using PaymentSystem.Api.DTOs;
using PaymentSystem.Domain.Models;

namespace PaymentSystem.Api.AutoMappings
{
    public class CustomerMappingProfile : Profile
    {
        public CustomerMappingProfile()
        {
            CreateMap<CustomerRequestDTO, Customer>();
            CreateMap<Customer, CustomerRequestDTO>();
            
            CreateMap<CustomerResponseDTO, Customer>();
            CreateMap<Customer, CustomerResponseDTO>();
            
            CreateMap<CustomerUpdateRequestDTO, Customer>();
            CreateMap<Customer, CustomerUpdateRequestDTO>();
        }
    }
}
