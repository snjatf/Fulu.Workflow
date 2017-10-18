using System;
using ICH.Cache.Redis;
using ICH.Util;
using Newtonsoft.Json;

namespace ICH.Data.Conn
{
    public class DBContext
    {
        [Serializable]
        [JsonObject(Title = "apiClass")]
        private class ApiClass
        {
            [JsonProperty("result")]
            public ConnectionManage Result { get; set; }

            [JsonProperty("error_code")]
            public int? ErrorCode { get; set; }

            [JsonProperty("reason")]
            public string Reason { get; set; }
        }

        public static ConnectionManage GetConnectionManage(string apiKey, string dbKey)
        {
            ConnectionManage entity = RedisCache.Get<ConnectionManage>("DB_Connection");

            if (entity != null)
            {
                return entity;
            }

            var ss = string.Format("key={0}&entityKey={1}", apiKey, dbKey);
            var result = HttpMethods.PostExecuteResult(Config.GetValue("GetDb"), "POST", ss);
            var api = result.ToObject<ApiClass>();
            entity = api.Result;
            if (!string.IsNullOrEmpty(entity.PkConnection))
                entity.PkConnection = DESEncrypt.Decrypt(entity.PkConnection, entity.BasicsId);
            if (!string.IsNullOrEmpty(entity.SpareConnection))
                entity.SpareConnection = DESEncrypt.Decrypt(entity.SpareConnection, entity.BasicsId);
            RedisCache.Set("DB_Connection", entity);

            return entity;
        }
    }
}
