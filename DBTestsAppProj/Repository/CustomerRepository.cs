using DBTestsAppProj.Infrastructure;
using DBTestsAppProj.Models;

namespace DBTestsAppProj.Repository
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        { }
    }

    public interface ICustomerRepository : IRepository<Customer>
    { }
}
