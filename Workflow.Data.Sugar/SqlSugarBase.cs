using System.Collections.Generic;
using SqlSugar;

namespace ICH.Data.Sugar
{
    public class SqlSugarBase
    {
        
        public static SqlSugarClient GetInstance(string connectionString, DbType dbType)
        {
            var db = new SqlSugarClient(new ConnectionConfig { ConnectionString = connectionString, DbType =dbType, IsAutoCloseConnection = true });
            db.Ado.IsEnableLogEvent = true;
            //db.Ado.LogEventStarting = (sql, pars) =>
            //{
            //    Console.WriteLine(sql + "\r\n" + db.RewritableMethods.SerializeObject(pars));
            //    Console.WriteLine();
            //};
            return db;
        }
    }
}
