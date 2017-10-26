using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using SqlSugar;

namespace Fulu.WorkflowService.API.Models
{
    /// <summary>
    /// DDStepRelationModuleDefineEntity。
    /// </summary>
    [SugarTable("myworkflowrelationmoduledefinition")]
    public partial class DDStepRelationModuleDefineEntity
	{
		#region Model
		private string _relationdefinitionguid;
		private string _processdefinitionguid;
		private string _stepdefinitionguid;
		private string _nextstepdefinitionguid;
		private string _lineid;
		private string _linename;
		private string _expressionstru;
		private string _linedisplaytype;
		private string _remark;
        /// <summary>
        /// 
        /// </summary>
        public string RelationDefinitionGuid
		{
			set{ _relationdefinitionguid=value;}
			get{return _relationdefinitionguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProcessDefinitionGuid
		{
			set{ _processdefinitionguid=value;}
			get{return _processdefinitionguid;}
		}
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public string StepDefinitionGuid
		{
			set{ _stepdefinitionguid=value;}
			get{return _stepdefinitionguid;}
		}
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "to")]
        public string NextStepDefinitionGuid
		{
			set{ _nextstepdefinitionguid=value;}
			get{return _nextstepdefinitionguid;}
		}
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string LineId
		{
			set{ _lineid=value;}
			get{return _lineid;}
		}
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string LineName
		{
			set{ _linename=value;}
			get{return _linename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExpressionStru
		{
			set{ _expressionstru=value;}
			get{return _expressionstru;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LineDisplayType
		{
			set{ _linedisplaytype=value;}
			get{return _linedisplaytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model


		
	}
}

