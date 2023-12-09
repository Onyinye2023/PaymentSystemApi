using AutoMapper;
using PaymentSystem.Api.DTOs;
using PaymentSystem.Domain.Models;

namespace PaymentSystem.Api.AutoMappings
{
    public class MerchantMappingProfile : Profile
    {
        public MerchantMappingProfile()
        {
            CreateMap<MerchantRequestDTO, Merchant>();
            CreateMap<Merchant, MerchantRequestDTO>();
           
            
            CreateMap<MerchantResponseDTO, Merchant>();
            CreateMap<Merchant, MerchantResponseDTO>();

            CreateMap<MerchantUpdateRequestDTO, Merchant>();
            CreateMap<Merchant, MerchantUpdateRequestDTO>();
        }
    }
}
