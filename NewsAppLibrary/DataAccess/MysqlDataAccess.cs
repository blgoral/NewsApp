using System.Data;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace NewsAppLibrary.DataAccess;

public class MysqlDataAccess : IDataAccess
{
    private readonly IDbConnection _connection;

    public MysqlDataAccess(IDbConnection connection)
    {
        _connection = connection;
    }
    
    public List<T> LoadData<T, U>(string sqlStatement, U parameters)
    {
        List<T> rows = _connection.Query<T>(sqlStatement, parameters).ToList();
        return rows;
    }

    public void SaveData<T>(string sqlStatement, T parameters)
    {
        _connection.Execute(sqlStatement, parameters);
    }
}