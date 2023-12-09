using Microsoft.EntityFrameworkCore;
using PaymentSystem.Domain.Abstractions;
using PaymentSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Dal.Repositories
{
    public class MerchantRepository : IMerchantRepository
    {
        private readonly DatabaseContext _context;
        public MerchantRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Merchant> AddMerchantAsync(Merchant merchant)
        {
            _context.Merchants.Add(merchant);
            await _context.SaveChangesAsync();
            return merchant;
        }

        public async Task<List<Merchant>> AllMerchantAsync()
        {
            return await _context.Merchants.ToListAsync();
        }

        public async Task<Merchant> MerchantByMerchantNumberAsync(string merchantNumber)
        {
           var merchant = await _context.Merchants
                .FirstOrDefaultAsync(b => b.MerchantNumber == merchantNumber);
            if (merchant == null)
            {
                return null;
            }
            return merchant;
        }

        public async Task<Merchant> DeleteMerchantAsync(string merchantNumber)
        {
           var merchant = await _context.Merchants.FirstOrDefaultAsync(b =>
           b.MerchantNumber == merchantNumber);
            if(merchant == null)
            {
                return null;
            }
            _context.Merchants.Remove(merchant);
            _context.SaveChanges();
            return merchant;
        }

        public async Task<Merchant> UpdateMerchantAsync(Merchant updatedMerchant)
        {
            _context.Merchants.Update(updatedMerchant);
            await _context.SaveChangesAsync();
            return updatedMerchant;
        }
    }
}
