using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowServices.Helper
{
    public enum ResultCode
    {
        #region 全局code
        /*------------全局，-99-99 错误场景请使用负数，正常场景使用正数，例如：成功：0，失败：-1,-----------*/
        /// <summary>
        /// 成功
        /// </summary>
        Success = 0,

        /// <summary>
        /// 失败
        /// </summary>
        Faild = -1,

        /// <summary>
        /// 反射失败
        /// </summary>
        ReflectFail = -100,

        /// <summary>
        /// 接口管家网络异常, 该code已经在接口管家中使用，当请求接口管家服务不通的时候，会使用此code
        /// </summary>
        ApiManagerNetworkError = -99,

        /// <summary>
        /// 接口管家程序在调用新服务接口之前出错，例如转发服务bug，接口管家平台代码报错
        /// </summary>
        ApiManagerServiceError = -98,

        /// <summary>
        /// 当新服务接口请求不通或非接口错误，例如erp服务器停了，接口以外的程序执行报
        /// 接口管家转发请求新服务，当请求出异常的时候，会捕获异常，使用此code
        /// </summary>
        ApiRequestError = -97,

        /// <summary>
        /// 无效的返回数据，云端接收到接口返回数据会进行识别，如果返回结果是一个非json结构，会使用此code
        /// </summary>
        InvalidApiData = -96,

        /// <summary>
        /// 工作流站点无法访问
        /// </summary>
        WorkflowSiteConnectFail = -95,

        /// <summary>
        /// ERP数据库执行超时
        /// </summary>
        DatabaseTimeOut = -94,

        /// <summary>
        /// 接口请求超时
        /// </summary>
        ApiTimeOut = -93,

        /// <summary>
        /// 未知错误
        /// </summary>
        UnknownError = -90,

        /// <summary>
        /// ERP数据库连接失败
        /// </summary>
        DatabaseConnectFail = -89,

        /// <summary>
        /// ERP数据库被还原
        /// </summary>
        DatabaseReset = -88,

        /// <summary>
        /// 接口版本不正确
        /// </summary>
        ApiVersionError = -87,

        /// <summary>
        /// 验证不通过
        /// </summary>
        Noverify = 11,

        #endregion

        #region 列表code
        /*-----------------------列表，1开头，例如：1001--------------------------*/

        #endregion

        #region 详情code
        /*-----------------------详情，2开头，例如：1001--------------------------*/
        /// <summary>
        /// 流程被撤回
        /// </summary>
        Process_withdraw = 2001,

        /// <summary>
        /// 无流程查看权限
        /// </summary>
        NoProcessAuth = 2002,


        #endregion

        #region 列表code
        /*-----------------------处理，3开头，例如：13001--------------------------*/

        /// <summary>
        /// 需要在pc端处理
        /// </summary>
        NeedPcHandle = 3001,
        #endregion

        #region 列表code
        /*-----------------------步骤，4开头，例如：4001--------------------------*/

        /// <summary>
        /// 分支定义有误
        /// </summary>
        NoRelation = 4001,
        /// <summary>
        /// 空责任人步骤不允许跳过
        /// </summary>
        EmptyAuditorNotPass = 4002,
        #endregion

        #region 扩展校验code
        /*-----------------------详情，9开头，例如：9001--------------------------*/
        /// <summary>
        /// 校验当前节点发起的协商是否都已经回复（协商强控），以及其他个性化校验
        /// </summary>
        Process_VeridiedAssignAllReply = 9001

        #endregion
    }
}
