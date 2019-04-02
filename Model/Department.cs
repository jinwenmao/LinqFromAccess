using System;
namespace Model
{
	/// <summary>
	/// 实体类Department 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Department
	{
		public Department()
		{}
		#region Model
		private int _departmentid;
		private string _name;
		private int _budget;
		private DateTime? _startdate;
		private int _administrator;
		/// <summary>
		/// 
		/// </summary>
		public int DepartmentID
		{
			set{ _departmentid=value;}
			get{return _departmentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Budget
		{
			set{ _budget=value;}
			get{return _budget;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? StartDate
		{
            set { _startdate = value; }
			get{return _startdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Administrator
		{
			set{ _administrator=value;}
			get{return _administrator;}
		}
		#endregion Model

	}
}

