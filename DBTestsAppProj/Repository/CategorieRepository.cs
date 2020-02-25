using DBTestsAppProj.Infrastructure;
using DBTestsAppProj.Models;

namespace DBTestsAppProj.Repository
{
    public class CategorieRepository : RepositoryBase<Categorie>, ICategorieRepository
    {
        public CategorieRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        { }
    }

    public interface ICategorieRepository : IRepository<Categorie>
    { }
}
