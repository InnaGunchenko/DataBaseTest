using System;

namespace DBTestsAppProj.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        BikeStoresDbContext Get();
    }

    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private BikeStoresDbContext dataContext;
        
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }

        public BikeStoresDbContext Get()
        {
            return dataContext ?? (dataContext = new BikeStoresDbContext());
        }
    }
}
