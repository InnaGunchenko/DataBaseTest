using DBTestsAppProj.Infrastructure;
using DBTestsAppProj.Models;

namespace DBTestsAppProj.Repository
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        { }
    }

    public interface IOrderRepository : IRepository<Order>
    { }
}
