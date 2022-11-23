using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BSRMDataManager.Library.Internal.DataAccess
{
    internal class SqlDataAccess : IDisposable
    {
        public string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public List<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(storedProcedure, parameters,
                    commandType: CommandType.StoredProcedure).AsList();

                return rows;
            }
        }

        public void SaveData<T>(string storedProcedure, T parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(storedProcedure, parameters,
                        commandType: CommandType.StoredProcedure);
            }
        }

        private IDbConnection _connection;
        private IDbTransaction _transaction;

        public void StartTransaction(string connectionStringName)
        {
            _connection = new SqlConnection(connectionStringName);

            _connection.Open();

            _transaction = _connection.BeginTransaction();
        }

        public List<T> LoadDataInTransaction<T, U>(string storedProcedure, U parameters)
        {
            {
                List<T> rows = _connection.Query<T>(storedProcedure, parameters,
                    commandType: CommandType.StoredProcedure,
                    transaction: _transaction)
                    .AsList();

                return rows;
            }
        }

        public void SaveDataInTransaction<T>(string storedProcedure, T parameters)
        {
            {
                _connection.Execute(storedProcedure, parameters,
                        commandType: CommandType.StoredProcedure,
                        transaction: _transaction);
            }
        }

        public void CommitTransation()
        {
            _transaction?.Commit();
            _connection?.Close();
        }

        public void RollBackTransaction()
        {
            _transaction?.Rollback();
            _connection?.Close();
        }

        public void Dispose()
        {
            CommitTransation();
        }
    }
}
