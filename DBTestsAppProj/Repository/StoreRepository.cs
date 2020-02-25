using DBTestsAppProj.Infrastructure;
using DBTestsAppProj.Models;

namespace DBTestsAppProj.Repository
{
    public class StoreRepository : RepositoryBase<Store>, IStoreRepository
    {
        public StoreRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        { }
    }

    public interface IStoreRepository : IRepository<Store>
    { }
}
