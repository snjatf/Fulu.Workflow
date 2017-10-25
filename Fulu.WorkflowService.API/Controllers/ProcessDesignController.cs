using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Fulu.WorkflowService.API.Models;
using WorkflowServices.Helper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fulu.WorkflowService.API.Controllers
{
    [Produces("application/json")]
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
                Nodes = new List<Node>() {
                    new Node(){
                        Id="000000000000",
                        Alt=true,
                        Name ="开始",
                        Height=28,
                        Left=42,
                        Top=38,
                        Width=28,
                        Type="startround"
                    },
                    new Node(){
                        Id="111111111111",
                        Alt=true,
                        Name ="归档",
                        Height=28,
                        Left=797,
                        Top=42,
                        Width=28,
                        Type="endround"
                    }
                },
                Lines = new List<Line>() {
                    new Line(){                        
                        From="000000000000",
                        Name="直接归档",
                        To="111111111111",
                        Type="sl",
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
        public void Post([FromBody]DDStepDefineEntity processInfo)
        {
            var x = processInfo;
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
