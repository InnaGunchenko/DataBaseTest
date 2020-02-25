using DBTestsAppProj.Infrastructure;
using DBTestsAppProj.Models;

namespace DBTestsAppProj.Repository
{
    public class StockRepository : RepositoryBase<Stock>, IStockRepository
    {
        public StockRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        { }
    }

    public interface IStockRepository : IRepository<Stock>
    { }
}
