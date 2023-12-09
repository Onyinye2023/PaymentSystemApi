using PaymentSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Domain.Abstractions
{
    public interface IMerchantRepository
    {
        Task<Merchant> AddMerchantAsync(Merchant merchant);
        Task<Merchant> MerchantByMerchantNumberAsync(string merchantNumber);
        Task<List<Merchant>> AllMerchantAsync();
        Task<Merchant> UpdateMerchantAsync(Merchant updatedMerchant);
        Task<Merchant> DeleteMerchantAsync(string  merchantNumber);
    }
}
