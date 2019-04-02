using System;
namespace Model
{
	/// <summary>
	/// 实体类testtable 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class testtable
	{
		public testtable()
		{}
		#region Model
		private string _col1;
		private string _col2;
		/// <summary>
		/// 
		/// </summary>
		public string col1
		{
			set{ _col1=value;}
			get{return _col1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string col2
		{
			set{ _col2=value;}
			get{return _col2;}
		}
		#endregion Model

	}
}

