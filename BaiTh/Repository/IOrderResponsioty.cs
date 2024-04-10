using BaiTh.Models;

namespace BaiTh.Repository
{
    public interface IOrderResponsioty
    {
        Task<IEnumerable<Order>> GetAllAsync();
        
    }
}
