using BSRMDataManager.Library.Models;
using System.Collections.Generic;

namespace BSRMDataManager.Library.DataAccess
{
    public interface ISaleData
    {
        List<SaleReportModel> GetSaleReports();
        void SaveSale(SaleModel saleInfo, string cashierId);
    }
}