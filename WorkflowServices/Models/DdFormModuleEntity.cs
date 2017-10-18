using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowServices.Models
{
    /// <summary>
    ///     表单模板实体 add by zhuangsd 2017年10月17日10:56:31
    /// </summary>
    [SugarTable("DDWorkflowFormModule")]
    public class DdFormModuleEntity
    {
        /// <summary>
        ///     表单模板主键
        /// </summary>
        public Guid? Id { get; set; }
        /// <summary>
        ///     表单模板结构数据
        /// </summary>
        public string Layout { get; set; }
    }
}
