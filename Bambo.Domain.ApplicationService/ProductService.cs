using Bambo.Core.Entites;
using Bambo.Domin.Contract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bambo.Domain.ApplicationService
{
    public class ProductService : IProdctService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public List<Product> GetChippestProduct()
        {
            return productRepository.GetNewstProduct();
        }

        public List<Product> GetNewestProduct()
        {
            return productRepository.GetChippestProduct()
               .Take(4).ToList();
        }

        public (List<Product>, int) ProductSearch(string q, string category, int pageNumber, int PageSize)
        {
            return productRepository.GetFilterProducts(q, category, pageNumber, PageSize);
        }
        public Product Get(int ProductId)
        {
            return productRepository.Get(ProductId);
        }
    }
}
