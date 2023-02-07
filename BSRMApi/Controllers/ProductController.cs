using BSRMDataManager.Library.DataAccess;
using BSRMDataManager.Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BSRMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Cashier")]
    public class ProductController : ControllerBase
    {
        private readonly IProductData _productData;

        public ProductController(IProductData ProductData)
        {
            _productData = ProductData;
        }

        [HttpGet]
        public List<ProductModel> GetAllProducts()
        {
            return _productData.GetProducts();
        }
    }
}
