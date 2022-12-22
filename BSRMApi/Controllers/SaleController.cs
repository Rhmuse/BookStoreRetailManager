using BSRMDataManager.Library.DataAccess;
using BSRMDataManager.Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Security.Claims;

namespace BSRMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SaleController : ControllerBase
    {
        private readonly IConfiguration _config;
        public SaleController(IConfiguration config)
        {
            _config = config;
        }

        [Authorize(Roles = "Cashier")]
        [HttpPost]
        public void Post(SaleModel sale)
        {
            SaleData data = new SaleData(_config);
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            data.SaveSale(sale, userId);
        }

        [Authorize(Roles = "Manager,Admin")]
        [Route("GetSalesReport")]
        [HttpGet]
        public List<SaleReportModel> GetSalesReport()
        {
            SaleData data = new SaleData(_config);
            return data.GetSaleReports();
        }
    }
}
