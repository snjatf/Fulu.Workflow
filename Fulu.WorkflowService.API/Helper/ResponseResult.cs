using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowServices.Helper
{
    public class ResponseResult<T>
    {
        [JsonProperty("data")]
        public T Data { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; } = 200;

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("stacktrace"), JsonIgnore]
        public string StackTrace { get; set; }

        [JsonProperty("context"),JsonIgnore]
        public Dictionary<string, object> Context { get; set; }

        [JsonProperty("warning"), JsonIgnore]
        public string Warning { get; set; }

        public ResponseResult()
        {
            this.Data = default(T);
            this.Code = 0;
            this.Message = string.Empty;
        }

        public ResponseResult(T data, int code, string message)
        {
            this.Data = data;
            this.Code = code;
            this.Message = message;
        }

        public ResponseResult(T data, int code, string message, bool needCompress)
        {
            //if (needCompress)
            //    this.Data = (T)(object)CommonHelper.Compress(JsonHelper.ToJson(data));
            //else
                this.Data = data;
            this.Code = code;
            this.Message = message;
        }

        #region 根据ResultCode返回结果

        /// <summary>
        /// 根据ResultCode 返回结果
        /// </summary>
        /// <param name="data"></param>
        /// <param name="code"></param>
        /// <param name="message"></param>
        public ResponseResult(T data, ResultCode code, string message)
        {
            this.Data = data;
            this.Code = (int)code;
            this.Message = message;
        }

        /// <summary>
        /// 返回结果带Trace信息
        /// </summary>
        /// <param name="data"></param>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="stackTrace"></param>
        public ResponseResult(T data, ResultCode code, string message, string stackTrace)
        {
            this.Data = data;
            this.Code = (int)code;
            this.Message = message;
            this.StackTrace = stackTrace;
        }

        /// <summary>
        /// 返回带压缩和上下文的结果集
        /// </summary>
        /// <param name="data"></param>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="needCompress"></param>
        public ResponseResult(T data, ResultCode code, string message, bool needCompress, Dictionary<string, object> context)
        {
            //if (needCompress)
            //    this.Data = (T)(object)CommonHelper.Compress(JsonHelper.ToJson(data));
            //else
                this.Data = data;
            this.Code = (int)code;
            this.Message = message;
            this.Context = context;
        }

        /// <summary>
        /// 返回结果集和Contex信息
        /// </summary>
        /// <param name="data"></param>
        /// <param name="code"></param>
        /// <param name="message"></param>
        public ResponseResult(T data, ResultCode code, string message, Dictionary<string, object> context)
        {
            this.Data = data;
            this.Code = (int)code;
            this.Message = message;
            this.Context = context;
        }

        #endregion

        /// <summary>
        /// 对象输出成JSON字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            ResponseResult<T> instance = new ResponseResult<T>();
            instance.Data = this.Data;
            instance.Code = this.Code;
            instance.Message = this.Message;
            instance.Context = this.Context;
            instance.StackTrace = this.StackTrace;
            instance.Warning = this.Warning;
            instance.Status = this.Status;
            return JsonConvert.SerializeObject(instance);
        }
    }

    /// <summary>
    /// 返回成功信息
    /// </summary>
    [Serializable]
    public class ResponseSucess : ResponseResult<object>
    {
        public ResponseSucess() : base(null, 0, string.Empty) { }

        public ResponseSucess(object data) : base(data, 0, string.Empty) { }

        public ResponseSucess(object data, bool needCompress) : base(data, 0, string.Empty, needCompress) { }

        #region 返回带上下文信息的结果集

        /// <summary>
        /// 返回普通结果集
        /// </summary>
        /// <param name="data"></param>
        /// <param name="context"></param>
        public ResponseSucess(object data, Dictionary<string, object> context) : base(data, ResultCode.Success, string.Empty, context) { }

        /// <summary>
        /// 返回带压缩功能的结果集
        /// </summary>
        /// <param name="data"></param>
        /// <param name="needCompress"></param>
        /// <param name="context"></param>
        public ResponseSucess(object data, bool needCompress, Dictionary<string, object> context) : base(data, ResultCode.Success, string.Empty, needCompress, context) { }

        #endregion
    }

    /// <summary>
    /// 返回失败信息
    /// </summary>
    [Serializable]
    public class ResponseError : ResponseResult<object>
    {
        public ResponseError() : base(null, -1, string.Empty) { }

        public ResponseError(string message) : base(null, -1, message) { }

        public ResponseError(string message, ResultCode code) : base(null, code, message) { }

        /// <summary>
        /// 记录带堆栈的错误信息
        /// </summary>
        /// <param name="code">错误编码枚举</param>
        /// <param name="message">错误消息</param>
        /// <param name="stackTrace">错误堆栈信息</param>
        public ResponseError(ResultCode code, string message, string stackTrace) : base(null, code, message, stackTrace) { }
    }

    /// <summary>
    /// 返回通知
    /// </summary>
    [Serializable]
    public class ResponseNotice : ResponseResult<object>
    {
        /// <summary>
        /// 返回带code类型的通知
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        public ResponseNotice(ResultCode code, string message) : base(null, code, message) { }
    }
}
