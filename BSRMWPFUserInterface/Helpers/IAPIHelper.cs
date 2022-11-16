using BSRMDataManager.Models;
using System.Threading.Tasks;

namespace BSRMWPFUserInterface.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
    }
}