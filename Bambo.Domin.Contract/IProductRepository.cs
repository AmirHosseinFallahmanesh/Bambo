using Bambo.Core.Entites;
using System;
using System.Collections.Generic;

namespace Bambo.Domin.Contract
{
    public interface IProductRepository
    {
        List<Product> GetChippestProduct();
        List<Product> GetNewstProduct();
        (List<Product>, int Count) GetFilterProducts(string search, string category, int pageNumber, int PageSize);
        Product Get(int ProductId);
    }
}
