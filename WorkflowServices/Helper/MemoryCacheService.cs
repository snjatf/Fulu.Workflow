using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowServices.Helper
{
    public class MemoryCacheService
    {
        static MemoryCache cache = new MemoryCache(new MemoryCacheOptions());
        /// <summary>
        /// 获取缓存值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object Get(string key)
        {
            object val = null;
            if (key != null && cache.TryGetValue(key, out val))
            {
                return val;
            }
            else
            {
                return default(object);
            }
        }
        /// <summary>
        /// 添加缓存内容
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void Set(string key, object value)
        {
            if (key != null)
            {
                cache.Set(key, value);
            }
        }

    }
}
