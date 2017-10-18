using System;
using Microsoft.AspNetCore.Mvc;
using WorkflowServices.Models;
using WorkflowServices.Helper;
using ICH.Data.Sugar;

namespace WorkflowServices.Controllers
{
    [Produces("application/json")]
    [Route("api/FormDesign")]
    public class FormDesignController : Controller
    {
        [HttpGet("{formGuid}")]
        public object Get(string formGuid)
        {
            var cache = new MemoryCacheService();
            var formEntiy = (DdFormModuleEntity)cache.Get(formGuid);
            if (formEntiy == null)
            {
                formEntiy = SqlSugarFactory.GetInstance().Queryable<DdFormModuleEntity>().With(SqlSugar.SqlWith.NoLock).InSingle(formGuid);
                if (formEntiy == null)
                {
                    return new ResponseError("没找到对应的表单模板数据。", ResultCode.NoProcessAuth);
                }
                else
                {
                    MemoryCacheService.Set(formGuid, formEntiy);
                    return new ResponseSucess(formEntiy);
                }
            }
            else
            {
                return new ResponseSucess(formEntiy);
            }
        }

        /// <summary>
        ///     保存接口 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]
        public object Post([FromBody]DdFormModuleEntity entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Layout))
            {
                return new ResponseError("提交表单模板数据不能为空。", ResultCode.NoRelation);
            }
            if (entity.Id == null || Guid.Empty.Equals(entity.Id))
            {
                entity.Id = Guid.NewGuid();
            }
            var executedEntity = SqlSugarFactory.GetInstance().Insertable(entity).ExecuteReturnEntity();
            return new ResponseSucess(executedEntity);
        }



    }
}