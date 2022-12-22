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
    [Authorize]
    public class InventoryController : ControllerBase
    {
        private readonly IConfiguration _config;
        public InventoryController(IConfiguration config)
        {
            _config = config;
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public void Post(InventoryModel item)
        {
            InventoryData data = new InventoryData(_config);
            data.SaveInventoryRecord(item);
        }

        [Authorize(Roles = "Manager,Admin")]
        [Route("GetInventoryReport")]
        [HttpGet]
        public List<InventoryModel> GetInventoryReport()
        {
            InventoryData data = new InventoryData(_config);
            return data.GetInventory();
        }
    }
}
