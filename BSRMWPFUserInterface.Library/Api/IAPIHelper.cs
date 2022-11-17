using BSRMDataManager.Models;
using System.Threading.Tasks;

namespace BSRMWPFUserInterface.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
        Task GetLoggedInUserAsync(string token);
    }
}