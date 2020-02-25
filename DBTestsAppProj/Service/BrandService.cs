using DBTestsAppProj.Models;
using DBTestsAppProj.Repository;
using System.Collections.Generic;

namespace DBTestsAppProj.Service
{
    public interface IBrandService
    {
        IEnumerable<Brand> GetBrands();
        Brand GetBrandById(int id);
    }

    public class BrandService : IBrandService
    {
        private readonly IBrandRepository brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            this.brandRepository = brandRepository;
        }

        public IEnumerable<Brand> GetBrands()
        {
            return brandRepository.GetAll();
        }

        public Brand GetBrandById(int id)
        {
            return brandRepository.GetById(id);
        }
    }
}
