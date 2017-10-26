using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Fulu.WorkflowService.API.Models;
using WorkflowServices.Helper;
using Newtonsoft.Json;
using ICH.Data.Sugar;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fulu.WorkflowService.API.Controllers
{
    [Route("api/ProcessDesign")]
    [EnableCors("any")]
    public class ProcessDesignController : Controller
    {
        // GET: api/values
        [HttpGet]
        public object Get()
        {
            var defualtStepEntity = new DDStepDefineEntity() {
                Title = "工作流流程设计器" + Math.Round(0.00, 15).ToString(),
                InitNum = 2,
                StepModuleList = new List<DDStepModuleDefineEntity>() {
                    new DDStepModuleDefineEntity(){
                        StepId="000000000000",                        
                        StepName ="开始",
                        Height=28,
                        Left=42,
                        Top=38,
                        Width=28,
                        StepType="startround"
                    },
                    new DDStepModuleDefineEntity(){
                        StepId="111111111111",
                        StepName ="归档",
                        Height=28,
                        Left=797,
                        Top=42,
                        Width=28,
                        StepType="endround"
                    }
                },
                StepRelationModuleList = new List<DDStepRelationModuleDefineEntity>() {
                    new DDStepRelationModuleDefineEntity(){
                        StepDefinitionGuid="000000000000",
                        NextStepDefinitionGuid="111111111111",
                        LineName="直接归档",
                        LineDisplayType="sl"
                    }
                }
            };

            return new  ResponseSucess(defualtStepEntity);
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public object Post([FromBody]DDStepDefineEntity ProcessInfo)
        {
            var db = SqlSugarFactory.GetInstance();
            var processDefineGuid = Guid.NewGuid().ToString();
            ProcessInfo.StepModuleList.ForEach(item =>
            {
                item.StepDefinitionGuid= Guid.NewGuid().ToString();
                item.ProcessDefinitionGuid = processDefineGuid;
            });
            ProcessInfo.StepRelationModuleList.ForEach(item=>
            {
                item.RelationDefinitionGuid = Guid.NewGuid().ToString();
                item.ProcessDefinitionGuid = processDefineGuid;
            });
            db.Ado.BeginTran();
            try
            {
                var count1 = db.Insertable(ProcessInfo.StepModuleList).ExecuteCommand();
                var count2 = db.Insertable(ProcessInfo.StepRelationModuleList).ExecuteCommand();
                db.Ado.CommitTran();
            }
            catch (Exception ex)
            {
                db.Ado.RollbackTran();
                return new ResponseError(ex.StackTrace,ResultCode.ApiManagerNetworkError);
            }
            
            //SqlSugarFactory.GetInstance().Insertable(entity).ExecuteReturnEntity()
            //var y=JsonConvert.DeserializeObject<DDStepDefineEntity>(x);
            return new ResponseSucess();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
