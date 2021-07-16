using Bambo.Core.Entites;
using System.Collections.Generic;

namespace Bambo.Domin.Contract
{
    public interface IProdctService
    {
       

        List<Product> GetChippestProduct();
        List<Product> GetNewestProduct();

        (List<Product>, int) ProductSearch(string q, string category, int pageNumber, int PageSize);
        Product Get(int ProductId);
    }
}
