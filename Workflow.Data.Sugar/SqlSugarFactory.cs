using System;
using System.Configuration;
using SqlSugar;
using ICH.Util;
using ICH.Data.Conn;
using System.Collections.Generic;
using ICH.Data.Sugar.Model;

namespace ICH.Data.Sugar
{
    /// <summary>
    /// SqlSugar工厂
    /// </summary>
    public class SqlSugarFactory
    {
        /// <summary>
        /// 定义仓储
        /// </summary>
        /// <param name="connString">连接字符串或数据库KEY</param>
        /// <param name="dbType">数据库类型</param>
        /// <returns></returns>
        public static SqlSugarClient GetInstance(string connString, DbType dbType)
        {
            if (!ValidateUtil.IsGuidByParse(connString))
                return SqlSugarBase.GetInstance(connString, dbType);

            var entity = DBContext.GetConnectionManage(Config.GetValue("DB_KEY"), connString);

            SqlSugarClient client;

            string connectionStr;
            //判断当前主链接是否可用
            try
            {
                connectionStr = entity.PkConnection;

                client = SqlSugarBase.GetInstance(connectionStr, Types[entity.DBType]);

                client.Ado.GetScalar("select 1+1");

                return client;
            }
            catch (Exception)
            {
                //说明主服务器不可用
                connectionStr = entity.SpareConnection;

                client = SqlSugarBase.GetInstance(connectionStr, Types[entity.DBType]);

                client.Ado.GetScalar("select 1+1");

                return client;
            }
        }

        /// <summary>
        /// 定义仓储（基础库）
        /// </summary>
        /// <returns></returns>
        public static SqlSugarClient GetInstance()
        {
            var appServices = new AppServices();
            var config = appServices.GetAppSettings<AppSettingsEntity>("ApiSettings");
            //var config = ConfigurationManager.ConnectionStrings["BaseDb"];
            return GetInstance(config.ConnectionString, Types[config.ProviderName]);
        }


        private static readonly Dictionary<string, DbType> Types = new Dictionary<string, DbType>()
        {
            {"MySql.Data.MySqlClient",DbType.MySql},
            {"System.Data.SqlClient",DbType.SqlServer},
            {"System.Data.SQLite",DbType.Sqlite},
            {"System.Data.OracleClient",DbType.Oracle},
            {"MySql",DbType.MySql},
            {"SqlServer",DbType.SqlServer},
            {"Sqlite",DbType.Sqlite},
            {"Oracle",DbType.Oracle},
        };
    }
}
