using BSRMDataManager.Library.DataAccess;
using BSRMDataManager.Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace BSRMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Cashier")]
    public class ProductController : ControllerBase
    {
        private readonly IConfiguration _config;
        public ProductController(IConfiguration config)
        {
            _config = config;
        }
        [HttpGet]
        public List<ProductModel> GetAllProducts()
        {
            ProductData data = new ProductData(_config);

            return data.GetProducts();
        }
    }
}
