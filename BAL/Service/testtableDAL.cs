using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Model;
using System.Collections.Generic;

namespace BAL.Service
{
	/// <summary>
	/// 数据访问类testtable。
	/// </summary>
	public class testtableDAL
	{
        public testtableDAL()
		{}
		#region  成员方法



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(testtable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into testtable(");
			strSql.Append("col1,col2)");
			strSql.Append(" values (");
			strSql.Append("@col1,@col2)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@col1", OleDbType.VarChar,255),
					new OleDbParameter("@col2", OleDbType.VarChar,255)};
			parameters[0].Value = model.col1;
			parameters[1].Value = model.col2;

			DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(testtable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update testtable set ");
			strSql.Append("col1=@col1,");
			strSql.Append("col2=@col2");
			strSql.Append(" where ");
			OleDbParameter[] parameters = {
					new OleDbParameter("@col1", OleDbType.VarChar,255),
					new OleDbParameter("@col2", OleDbType.VarChar,255)};
			parameters[0].Value = model.col1;
			parameters[1].Value = model.col2;

			DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(string id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from testtable ");
			strSql.Append(" where col1 =@id ");
            OleDbParameter parameter = new OleDbParameter("@id", OleDbType.VarChar);
            parameter.Value = id;
            OleDbParameter[] parameters = { parameter };

			DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public testtable GetModel(string id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select col1,col2 from testtable ");
            strSql.Append(" where col1 =@id");
            OleDbParameter parameter = new OleDbParameter("@id", OleDbType.VarChar);
            parameter.Value = id;
            OleDbParameter[] parameters = {parameter};

			testtable model=new testtable();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.col1=ds.Tables[0].Rows[0]["col1"].ToString();
				model.col2=ds.Tables[0].Rows[0]["col2"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<testtable> GetList(string strWhere)
		{
            List<testtable> listTable= new List<testtable>();
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select col1,col2 ");
			strSql.Append(" FROM testtable ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            DataSet set=DbHelperOleDb.Query(strSql.ToString());
            int rowCount=set.Tables[0].Rows.Count;
            DataTable setTable=set.Tables[0];
            if(rowCount>0)
            {
                for(int i=0;i<rowCount;i++)
                {
                    testtable  table=new testtable();
                    table.col1=setTable.Rows[i]["col1"].ToString();
                    table.col2=setTable.Rows[i]["col2"].ToString();
                    listTable.Add(table);
                }
            }
            return listTable;
		}

		#endregion  成员方法
	}
}

