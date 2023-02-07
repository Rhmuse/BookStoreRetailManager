using BSRMDataManager.Library.Internal.DataAccess;
using BSRMDataManager.Library.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace BSRMDataManager.Library.DataAccess
{
    public class UserData : IUserData
    {

        private readonly ISqlDataAccess _sql;

        public UserData(IConfiguration config, ISqlDataAccess sql)
        {

            _sql = sql;
        }
        public List<UserModel> GetUserById(string Id)
        {
            var output = _sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", new { Id }, "BSRMData");

            return output;
        }
    }
}
