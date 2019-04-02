using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.Linq;
using System.Data;

namespace BAL.LinqContext
{
    public class LinqConextClass:IDisposable
    {
        private OleDbConnection oleConnection;
        private bool flagOpen=false;
        private DataContext context;

        public LinqConextClass()
        {
            oleConnection = new OleDbConnection(PubConstant.ConnectionString);
        }

        /// <summary>
        /// 获取执行的上下文
        /// </summary>
        public DataContext Context
        {
            get
            {
                if (oleConnection != null && oleConnection.State == ConnectionState.Open && flagOpen)
                {
                    context = new DataContext(oleConnection);
                    return context;
                }
                else
                {
                    throw new Exception("打开数据库连接失败！");
                    return null;
                }
            }
        }

        public void  Open()
        {
            if (oleConnection != null)
            {
                oleConnection.Open();
                flagOpen = true;
            }
        }

        public void  Close()
        {
            if (oleConnection != null)
            {
                oleConnection.Close();
                flagOpen = false;
            }
        }

        #region IDisposable 成员

        public void Dispose()
        {
            if (oleConnection != null)
            {
                oleConnection.Close();
                oleConnection.Dispose();
            }
            if (context != null)
            {
                context.Connection.Close();
                context.Dispose();
            }
        }

        #endregion
    }
}
