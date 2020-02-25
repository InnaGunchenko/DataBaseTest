using BoDi;
using DBTestsAppProj.Infrastructure;
using DBTestsAppProj.Models;
using DBTestsAppProj.Repository;
using DBTestsAppProj.Service;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DbTests.Steps
{
    [Binding]
    public class SelectTestingSteps : BaseSteps
    {
        IProductService productService;
        Product product;
        List<Product> products;

        public SelectTestingSteps(IObjectContainer objectContainer) : base(objectContainer)
        {
            this.ObjectContainer.Resolve<IDatabaseFactory>();
            this.ObjectContainer.Resolve<IProductRepository>();
            this.productService = this.ObjectContainer.Resolve<IProductService>();
        }

        [When(@"select all from entity where Id = (.*)")]
        public void WhenGetEntityById(int id)
        {
            product = productService.GetProductById(id);
            product.Should().NotBeNull();
        }

        [Then(@"the result should be")]
        public void ThenTheResultShouldBeOnTheScreen(Table entity)
        {
            dynamic data = entity.CreateDynamicInstance();
            product.ProductName.Should().BeEquivalentTo(data.ProductName);
            product.BrandId.Should().Equals(data.BrandId);
            product.CategoryId.Should().Equals(data.CategoryId);
            product.ModelYear.Should().Equals(data.ModelYear);
            product.ListPrice.Should().Equals(data.ListPrice);
        }

        [When(@"select all from entity")]
        public void WhenSelectAllFromEntity()
        {
            products = (List<Product>)productService.GetProducts();
        }

        [Then(@"Check table rows for duplicates as (.*)")]
        public void CheckTableRowsForDuplicates(string nameDuplicate)
        {
            (
                from product in products
                group product by new
                {
                    ProductName = product.ProductName,
                    BrandId = product.BrandId,
                    CategoryId = product.CategoryId,
                    ModelYear = product.ModelYear,
                    ListPrice = product.ListPrice
                } into gr
                select new { Name = gr.Key.ProductName, Count = gr.Count() } into s
                where s.Count > 1
                select s.Name
               )
            .ToList()
            .FirstOrDefault()
            .ToString()
            .Should()
            .BeEquivalentTo(nameDuplicate);
        }
    }
}
