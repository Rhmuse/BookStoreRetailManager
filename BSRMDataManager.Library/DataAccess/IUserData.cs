using BSRMDataManager.Library.Models;
using System.Collections.Generic;

namespace BSRMDataManager.Library.DataAccess
{
    public interface IUserData
    {
        List<UserModel> GetUserById(string Id);
    }
}