using BSRMDataManager.Library.DataAccess;
using BSRMDataManager.Library.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace BSRMDataManager.Controllers
{
    [Authorize]
    public class InventoryController : ApiController
    {
        public void Post(InventoryModel item)
        {
            InventoryData data = new InventoryData();
            data.SaveInventoryRecord(item);
        }

        [Route("GetInventoryReport")]
        public List<InventoryModel> GetInventoryReport()
        {
            InventoryData data = new InventoryData();
            return data.GetInventory();
        }
    }
}
