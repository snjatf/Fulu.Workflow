using System;
using Microsoft.AspNetCore.Mvc;
using WorkflowServices.Helper;
using ICH.Data.Sugar;
using Fulu.WorkflowService.API.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;

namespace WorkflowServices.Controllers
{
    [Produces("application/json")]
    [Route("api/FormDesign")]
    [EnableCors("any")]
    public class FormDesignController : Controller
    {
        [HttpGet("{formGuid}")]
        public object Get(string formGuid)
        {
            var cache = new MemoryCacheService();
            var formEntiy = (DdFormModuleEntity)cache.Get(formGuid);

            if (formEntiy == null)
            {
                //构建一个虚拟的业务对象结构
                var bizObj = new DDBizObjectEntity();
                bizObj.Name = "成本管理_合同变更审批";
                bizObj.FieldList = new List<DDBizObjectItem>() {
                new DDBizObjectItem(){
                    Name="用户名称",
                    DataType="text",
                },
                new DDBizObjectItem(){
                    Name="备注",
                    DataType="text",
                },
                new DDBizObjectItem(){
                    Name="性别",
                    DataType="text",
                },
                new DDBizObjectItem(){
                    Name="婚姻状态",
                    DataType="text",
                },
                new DDBizObjectItem(){
                    Name="性格描述",
                    DataType="text",
                },
                new DDBizObjectItem(){
                    Name="年龄",
                    DataType="number",
                },
                new DDBizObjectItem(){
                    Name="出生日期",
                    DataType="datetime",
                },
                new DDBizObjectItem(){
                    Name="github地址",
                    DataType="text",
                },
                new DDBizObjectItem(){
                    Name="审批意见",
                    DataType="text",
                },
                new DDBizObjectItem(){
                    Name="说明文字",
                    DataType="text",
                },
                new DDBizObjectItem(){
                    Name="期望薪资",
                    DataType="number",
                },
                new DDBizObjectItem(){
                    Name="年龄",
                    DataType="number",
                },
                new DDBizObjectItem(){
                    Name="工作经历",
                    DataType="table",
                    Rows=new List<DDBizObjectItem>(){
                        new DDBizObjectItem(){
                            Name="编号",
                            DataType="table_text"
                        },
                        new DDBizObjectItem(){
                            Name="公司名称",
                            DataType="table_text"
                        },
                        new DDBizObjectItem(){
                            Name="入职时间",
                            DataType="table_datetime"
                        },
                        new DDBizObjectItem(){
                            Name="工作时间",
                            DataType="table_number"
                        }
                    }
                }
            };

                formEntiy = SqlSugarFactory.GetInstance().Queryable<DdFormModuleEntity>().With(SqlSugar.SqlWith.NoLock).InSingle(formGuid);
                if (formEntiy == null)
                {
                    return new ResponseError("没找到对应的表单模板数据。", ResultCode.NoProcessAuth);
                }
                else
                {
                    formEntiy.BizObject = bizObj;
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