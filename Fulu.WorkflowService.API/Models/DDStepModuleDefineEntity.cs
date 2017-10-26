using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using SqlSugar;

namespace Fulu.WorkflowService.API.Models
{
    /// <summary>
    /// DDStepModuleDefineEntity
    /// </summary>
    [SugarTable("myworkflowstepmoduledefinition")]
    public partial class DDStepModuleDefineEntity
	{

        #region Model
        private string _stepdefinitionguid;
        private string _processdefinitionguid;
        private string _processkindguid;
        private string _stepid;
        private string _stepname;
        private string _steptype;
        private string _description;
        private int _cancancel;
        private int _canclose;
        private int _canassign;
        private string _hiddendomain;
        private string _editdomain;
        private int? _top;
        private int? _left;
        private int? _height;
        private int? _width;
        private string _ideadomain;
        private string _ideaptype;
        private string _approveattention;
        private int _handlemode;
        private int _passmode;
        private int _candocdelete;
        private int _canendprocess;
        private int _canrollback;
        private int _canupload;
        private int _candownload;
        /// <summary>
        /// 
        /// </summary>
        public string StepDefinitionGuid
        {
            set { _stepdefinitionguid = value; }
            get { return _stepdefinitionguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ProcessDefinitionGuid
        {
            set { _processdefinitionguid = value; }
            get { return _processdefinitionguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ProcessKindGuid
        {
            set { _processkindguid = value; }
            get { return _processkindguid; }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string StepId
        {
            set { _stepid = value; }
            get { return _stepid; }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string StepName
        {
            set { _stepname = value; }
            get { return _stepname; }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string StepType
        {
            set { _steptype = value; }
            get { return _steptype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CanCancel
        {
            set { _cancancel = value; }
            get { return _cancancel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CanClose
        {
            set { _canclose = value; }
            get { return _canclose; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CanAssign
        {
            set { _canassign = value; }
            get { return _canassign; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string HiddenDomain
        {
            set { _hiddendomain = value; }
            get { return _hiddendomain; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EditDomain
        {
            set { _editdomain = value; }
            get { return _editdomain; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Top
        {
            set { _top = value; }
            get { return _top; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Left
        {
            set { _left = value; }
            get { return _left; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Height
        {
            set { _height = value; }
            get { return _height; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Width
        {
            set { _width = value; }
            get { return _width; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IdeaDomain
        {
            set { _ideadomain = value; }
            get { return _ideadomain; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IdeapType
        {
            set { _ideaptype = value; }
            get { return _ideaptype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ApproveAttention
        {
            set { _approveattention = value; }
            get { return _approveattention; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int HandleMode
        {
            set { _handlemode = value; }
            get { return _handlemode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int PassMode
        {
            set { _passmode = value; }
            get { return _passmode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CanDocDelete
        {
            set { _candocdelete = value; }
            get { return _candocdelete; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CanEndProcess
        {
            set { _canendprocess = value; }
            get { return _canendprocess; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CanRollBack
        {
            set { _canrollback = value; }
            get { return _canrollback; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CanUpload
        {
            set { _canupload = value; }
            get { return _canupload; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CanDownload
        {
            set { _candownload = value; }
            get { return _candownload; }
        }
        #endregion Model



    }
}

