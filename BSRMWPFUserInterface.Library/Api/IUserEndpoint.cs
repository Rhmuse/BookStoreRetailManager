using BSRMWPFUserInterface.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BSRMWPFUserInterface.Library.Api
{
    public interface IUserEndpoint
    {
        Task<List<UserModel>> GetAll();
        Task<Dictionary<string, string>> GetAllRoles();
        Task AddRoleToUser(string userId, string roleName);
        Task RemoveRoleFromUser(string userId, string roleName);
    }
}