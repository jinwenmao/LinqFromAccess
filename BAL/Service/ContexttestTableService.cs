using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.OleDb;
using BAL.LinqContext;
using System.Data.Linq;
using System.Collections;

namespace BAL.Service
{
    public class ContexttestTableService
    {
        public void Save(testtable table)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into testtable(");
            strSql.Append("col1,col2)");
            strSql.Append(" values (");
            strSql.Append(string.Format("'{0}','{1}'",table.col1,table.col2));
            strSql.Append(")");
            
            LinqConextClass context = new LinqConextClass();
            try
            {
                context.Open();
                DataContext dataContext = context.Context;
                int x=dataContext.ExecuteCommand(strSql.ToString());
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                context.Close();
            }
        }

        public void Update(testtable table)
        { }

        public void Delete(testtable table)
        {
            StringBuilder strSql = new StringBuilder();
            //delete from testtable where col1='55'

            strSql.Append("delete from testtable ");
            strSql.Append(string.Format("where col1='{0}'",table.col1));
            //strSql.Append("where '{0}'='{0}' and col1='{1}'");
            LinqConextClass context = new LinqConextClass();
            try
            {
                context.Open();
                DataContext dataContext = context.Context;
                int x = dataContext.ExecuteCommand(strSql.ToString());
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                context.Close();
            }
        }

        public void GetById(string id)
        { }

        public List<testtable> GetList(string where)
        {
            List<testtable> testList = new List<testtable>();
            StringBuilder strSql = new StringBuilder();
            //select col1,col2 from testtable;
            strSql.Append("select col1,col2 from testtable");
            strSql.Append(where);
            LinqConextClass context = new LinqConextClass();
            try
            {
                context.Open();
                DataContext dataContext = context.Context;
                IEnumerable collections = dataContext.ExecuteQuery((new testtable()).GetType(), strSql.ToString());
                foreach (var item in collections)
                {
                    testtable temp = item as testtable;
                    testList.Add(temp);
                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                context.Close();
            }
            return testList;
        }

    }
}
