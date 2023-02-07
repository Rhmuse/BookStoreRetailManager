using BSRMDataManager.Library.Models;
using System.Collections.Generic;

namespace BSRMDataManager.Library.DataAccess
{
    public interface IProductData
    {
        ProductModel GetProductById(int productId);
        List<ProductModel> GetProducts();
    }
}