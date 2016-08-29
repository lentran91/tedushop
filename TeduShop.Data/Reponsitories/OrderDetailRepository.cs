using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Reponsitories
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        
    }
    public class OrderDetailRepository : RepositoryBase<OrderDetail> , IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
