using DBTestsAppProj.Models;
using DBTestsAppProj.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTestsAppProj.Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
    }

    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository brandRepository)
        {
            this.productRepository = brandRepository;
        }

        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetAll();
        }

        public Product GetProductById(int id)
        {
            return productRepository.GetById(id);
        }
    }
}
