using BSRMDataManager.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace BSRMWPFUserInterface.Library.Api
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }
        Task<AuthenticatedUser> Authenticate(string userName, string password);
        Task GetLoggedInUserAsync(string token);
        void LogOffUser();
    }
}