using BoDi;
using DBTestsAppProj.Infrastructure;
using DBTestsAppProj.Repository;
using DBTestsAppProj.Service;
using TechTalk.SpecFlow;

namespace DbTests.Hooks
{
    [Binding]
    public class TestInitializer
    {
        private static IObjectContainer objectContainer;

        [BeforeTestRun(Order = 1)]
        public static void SetUpEnvironment(IObjectContainer objectContainer)
        {
            TestInitializer.objectContainer = objectContainer;
            objectContainer.RegisterTypeAs<DatabaseFactory, IDatabaseFactory>();
            objectContainer.RegisterTypeAs<ProductRepository, IProductRepository>();
            objectContainer.RegisterTypeAs<ProductService, IProductService>();

        }
    }
}
