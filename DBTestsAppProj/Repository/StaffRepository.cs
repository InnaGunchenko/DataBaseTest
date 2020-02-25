using DBTestsAppProj.Infrastructure;
using DBTestsAppProj.Models;

namespace DBTestsAppProj.Repository
{
    public class StaffRepository : RepositoryBase<Staff>, IStaffRepository
    {
        public StaffRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        { }
    }

    public interface IStaffRepository : IRepository<Staff>
    { }
}