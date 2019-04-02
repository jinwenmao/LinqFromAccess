using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Collections;
using BAL.LinqContext;
using System.Data.Linq;

namespace BAL.Service
{
    public class ContextDepartmentService
    {
        public void Save(Department dept)
        {
            //INSERT INTO Department ( 
            //[DepartmentID] ,
            //[Name] ,
            //[Budget] ,
            //[StartDate] ,
            //[Administrator] ) VALUES (123,'test1',456,'2010-4-12 0:00:00',456)

            StringBuilder strSql = new StringBuilder();
         
            strSql.Append("INSERT INTO Department (");
            strSql.Append("[DepartmentID],[Name],[Budget],[StartDate],[Administrator] )");
            strSql.Append(" values (");
            string dateTime = string.Empty;
            if (dept.StartDate == null)
            {
                dateTime = string.Empty;
            }
            else
            {
                DateTime dateTimeTemp=(DateTime)dept.StartDate;
                dateTime = dateTimeTemp.ToString("yyyy-MM-dd HH:mm:ss");
            }
            strSql.Append(string.Format("{0},'{1}',{2},'{3}',{4}", 
                dept.DepartmentID, dept.Name, dept.Budget,dateTime, dept.Administrator)) ;
            strSql.Append(")");

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

        public void Update()
        { }

        public void Delte()
        { }

        public int GetMaxId()
        {
            int maxId=0;
            StringBuilder strSql = new StringBuilder();
            //select Max([DepartmentID]) from Department

            strSql.Append("SELECT MAX([DepartmentID]) FROM Department");
            LinqConextClass context = new LinqConextClass();
            try
            {
                context.Open();
                DataContext dataContext = context.Context;
                IEnumerable collection = dataContext.ExecuteQuery((new int()).GetType(), strSql.ToString());
                foreach (int item in collection)
                {
                    maxId = item;
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
            return maxId;
        }

        public List<Department> GetList(string where)
        {
            List<Department> deplist = new List<Department>();
            StringBuilder strSql = new StringBuilder();
            //select [DepartmentID],[Name],[Budget],[StartDate],[Administrator] from Department
            strSql.Append("SELECT [DepartmentID],[Name],[Budget],[StartDate],[Administrator] FROM Department ");
            strSql.Append(where);
            LinqConextClass context = new LinqConextClass();
            try
            {
                context.Open();
                DataContext dataContext = context.Context;
                IEnumerable collections = dataContext.ExecuteQuery((new Department()).GetType(), strSql.ToString());
                foreach (var item in collections)
                {
                    Department temp = item as Department;
                    deplist.Add(temp);
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
            return deplist;
        }
    }
}
