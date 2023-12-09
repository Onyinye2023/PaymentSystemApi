using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PaymentSystem.Api.DTOs;
using PaymentSystem.Domain.Abstractions;
using PaymentSystem.Domain.Models;

namespace PaymentSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MerchantController : ControllerBase
    {
        private readonly IMerchantRepository _merchantRepo;
        private readonly IMapper _mapper;
        public MerchantController(IMerchantRepository merchantRepo, IMapper mapper)
        {
            _merchantRepo = merchantRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> AllBusiness()
        {
            var businesses = await _merchantRepo.AllMerchantAsync();
            var businessesGet = _mapper.Map<List<MerchantResponseDTO>>(businesses);
            return Ok(businessesGet);
        }

        [HttpGet]
        [Route("{merchantNumber}")]
        public async Task<IActionResult> BusinessByMerchantNumber(string merchantNumber)
        {
            var business = await _merchantRepo.MerchantByMerchantNumberAsync(merchantNumber);

            if (business == null)
            {
                return NotFound($"No business found with the merchant number{merchantNumber}");
            }

            var getBusiness = _mapper.Map<MerchantResponseDTO>(business);
            return Ok(getBusiness);
        }

        [HttpPost]
        [Route("addBusiness")]
        public async Task<IActionResult> AddBusiness([FromBody] MerchantRequestDTO businessRequestdto)
        {
            var business = _mapper.Map<Merchant>(businessRequestdto);
            await _merchantRepo.AddMerchantAsync(business);
            var getBusiness = _mapper.Map<MerchantResponseDTO>(business);
           
            return CreatedAtAction(nameof(BusinessByMerchantNumber),
                new { merchantNumber = business.MerchantNumber }, business);
        }

        [HttpPut]
        [Route("{merchantNumber}")]
        public async Task<IActionResult> UpdateBusiness([FromBody] MerchantUpdateRequestDTO updated, string merchantNumber)
        {
            var toUpdate = _mapper.Map<Merchant>(updated);
            toUpdate.MerchantNumber = merchantNumber;
            await _merchantRepo.UpdateMerchantAsync(toUpdate);
            return NoContent();
        }

        [HttpDelete]
        [Route("{merchantNumber}")]
        public async Task<IActionResult> DeleteBusiness(string merchantNumber)
        {
            var business = await _merchantRepo.DeleteMerchantAsync(merchantNumber);
            if (business == null)
            {
                return NotFound($"No merchant found with the number{merchantNumber}");
            }
            return NoContent();
        }
    }
}
