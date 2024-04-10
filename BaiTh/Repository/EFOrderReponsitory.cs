using BaiTh.Data;
using BaiTh.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiTh.Repository
{
    public class EFOrderReponsitory : IOrderResponsioty
    {
        private readonly ApplicationDbContext _context;

        public EFOrderReponsitory(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _context.Orders.ToListAsync();
        }

        
    }
}
