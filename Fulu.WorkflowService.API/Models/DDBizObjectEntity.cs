using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fulu.WorkflowService.API.Models
{
    /// <summary>
    ///     业务对象实体
    /// </summary>
    public class DDBizObjectEntity
    {
        public string Name { get; set; }
        public List<DDBizObjectItem> FieldList { get; set; }
    }

    public class DDBizObjectItem {
        public string Name { get; set; }
        public string DataType { get; set; }
        public List<DDBizObjectItem> Rows { get; set; }
    }
}
