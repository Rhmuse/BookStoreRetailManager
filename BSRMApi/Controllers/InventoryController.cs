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
        private readonly IInventoryData _inventoryData;

        public InventoryController(IConfiguration config, IInventoryData inventoryData)
        {
            _config = config;
            _inventoryData = inventoryData;
        }

        [Authorize(Roles = "Manager,Admin")]
        [Route("GetInventoryReport")]
        [HttpGet]
        public List<InventoryModel> GetInventoryReport()
        {
            return _inventoryData.GetInventory();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public void Post(InventoryModel item)
        {
            _inventoryData.SaveInventoryRecord(item);
        }
    }
}
