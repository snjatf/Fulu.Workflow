using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fulu.WorkflowService.API.Models
{
    public class DDStepDefineEntity
    {
        /// <summary>
        ///     标题
        /// </summary>
        public string Title { get; set; }
        public int InitNum { get; set; }
        [JsonProperty(PropertyName ="nodes")]
        public List<DDStepModuleDefineEntity> StepModuleList { get; set; }
        public List<StepArea> Areas { get; set; }
        [JsonProperty(PropertyName = "lines")]
        public List<DDStepRelationModuleDefineEntity> StepRelationModuleList { get; set; }
    }

    public class StepArea {

    }
    public class Node {
        public string Id { get; set; }
        public bool Alt { get; set; }
        public int Height { get; set; }
        public int Left { get; set; }
        public string Name { get; set; }

        public int Top { get; set; }
        public string Type { get; set; }
        public int Width { get; set; }
    }

    public class Line {
        public string From { get; set; }
        public string Name { get; set; }
        public string To { get; set; }
        public string Type { get; set; }
    }
}
