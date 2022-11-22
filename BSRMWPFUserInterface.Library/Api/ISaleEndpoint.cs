using BSRMWPFUserInterface.Library.Models;
using System.Threading.Tasks;

namespace BSRMWPFUserInterface.Library.Api
{
    public interface ISaleEndpoint
    {
        Task PostSale(SaleModel sale);
    }
}