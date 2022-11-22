using BSRMDataManager.Library.Internal.DataAccess;
using BSRMDataManager.Library.Models;
using System.Collections.Generic;
using System.Linq;

namespace BSRMDataManager.Library.DataAccess
{
    public class ProductData
    {
        public List<ProductModel> GetProducts()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<ProductModel, dynamic>("dbo.spProduct_GetAll", new { }, "BSRMData");

            return output;
        }

        public ProductModel GetProductById(int productId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<ProductModel, dynamic>("dbo.spProduct_GetById", new { Id = productId }, "BSRMData").FirstOrDefault();

            return output;
        }
    }
}
