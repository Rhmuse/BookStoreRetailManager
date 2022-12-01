using BSRMDataManager.Library.DataAccess;
using BSRMDataManager.Library.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace BSRMDataManager.Controllers
{
    [Authorize(Roles = "Cashier")]
    public class ProductController : ApiController
    {
        public List<ProductModel> GetAllProducts()
        {
            ProductData data = new ProductData();

            return data.GetProducts();
        }
    }
}
