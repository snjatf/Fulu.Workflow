using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using SqlSugar;

namespace Fulu.WorkflowService.API.Models
{
    /// <summary>
    /// DDProcessModuleDefineEntity
    /// </summary>
    [SugarTable("DDProcessModuleDefine")]
    public partial class DDProcessModuleDefineEntity
	{
		#region Model
		private string _processdefinitionguid;
		private int _versionno;
		private int _versionstatus;
		private string _processguid;
		private string _processkindguid;
		private string _processkindname;
		private string _processname;
		private int? _formtype;
		private string _businesstypeguid;
		private int? _isactive;
		private int? _canusermodify;
		private string _savefolder;
		private DateTime? _modifydate;
		private string _modifymember;
		private string _modifymembername;
		private string _description;
		private string _bt_domainxml;
		private string _watchmembers;
		private string _watchmembersname;
		private string _formguid;
		private int? _candatasave;
		private string _businesstypename;
		private string _extendformurl;
		private string _application;
		private string _namecodingrule;
		private string _codecodingrule;
		private string _isautosave;
		private string _processcomparedomain;
		private string _iswfinitiate;
		private string _businessobjectguid;
		private string _lockedby;
		private DateTime? _lockeddatetime;
		private string _publishversionname;
		private string _publishdescription;
		private string _publisherguid;
		private DateTime? _publishdatetime;
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
		public int VersionNo
		{
			set{ _versionno=value;}
			get{return _versionno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int VersionStatus
		{
			set{ _versionstatus=value;}
			get{return _versionstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProcessGuid
		{
			set{ _processguid=value;}
			get{return _processguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProcessKindGuid
		{
			set{ _processkindguid=value;}
			get{return _processkindguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProcessKindName
		{
			set{ _processkindname=value;}
			get{return _processkindname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProcessName
		{
			set{ _processname=value;}
			get{return _processname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FormType
		{
			set{ _formtype=value;}
			get{return _formtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BusinessTypeGuid
		{
			set{ _businesstypeguid=value;}
			get{return _businesstypeguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsActive
		{
			set{ _isactive=value;}
			get{return _isactive;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CanUserModify
		{
			set{ _canusermodify=value;}
			get{return _canusermodify;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SaveFolder
		{
			set{ _savefolder=value;}
			get{return _savefolder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ModifyDate
		{
			set{ _modifydate=value;}
			get{return _modifydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ModifyMember
		{
			set{ _modifymember=value;}
			get{return _modifymember;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ModifyMemberName
		{
			set{ _modifymembername=value;}
			get{return _modifymembername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BT_DomainXML
		{
			set{ _bt_domainxml=value;}
			get{return _bt_domainxml;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WatchMembers
		{
			set{ _watchmembers=value;}
			get{return _watchmembers;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WatchMembersName
		{
			set{ _watchmembersname=value;}
			get{return _watchmembersname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FormGUID
		{
			set{ _formguid=value;}
			get{return _formguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CanDataSave
		{
			set{ _candatasave=value;}
			get{return _candatasave;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BusinessTypeName
		{
			set{ _businesstypename=value;}
			get{return _businesstypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExtendFormUrl
		{
			set{ _extendformurl=value;}
			get{return _extendformurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Application
		{
			set{ _application=value;}
			get{return _application;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NameCodingRule
		{
			set{ _namecodingrule=value;}
			get{return _namecodingrule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CodeCodingRule
		{
			set{ _codecodingrule=value;}
			get{return _codecodingrule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsAutoSave
		{
			set{ _isautosave=value;}
			get{return _isautosave;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProcessCompareDomain
		{
			set{ _processcomparedomain=value;}
			get{return _processcomparedomain;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsWFInitiate
		{
			set{ _iswfinitiate=value;}
			get{return _iswfinitiate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BusinessObjectGuid
		{
			set{ _businessobjectguid=value;}
			get{return _businessobjectguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LockedBy
		{
			set{ _lockedby=value;}
			get{return _lockedby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LockedDateTime
		{
			set{ _lockeddatetime=value;}
			get{return _lockeddatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PublishVersionName
		{
			set{ _publishversionname=value;}
			get{return _publishversionname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PublishDescription
		{
			set{ _publishdescription=value;}
			get{return _publishdescription;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PublisherGuid
		{
			set{ _publisherguid=value;}
			get{return _publisherguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PublishDateTime
		{
			set{ _publishdatetime=value;}
			get{return _publishdatetime;}
		}
		#endregion Model


		
	}
}

