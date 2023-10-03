using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace Registration.Repository;

public class MysqlBase
{
    protected readonly IConfiguration _configuration;
    protected MySqlConnection _mysqlConnection;

    public MysqlBase(IConfiguration configuration)
    {
        _configuration = configuration;

        //var conStr = _configuration.GetConnectionString("DefaultConnectionMySQL");
        var conStr = _configuration.GetValue<string>("DefaultConnectionMySQL");
        _mysqlConnection = new MySqlConnection(conStr);
    }
}
