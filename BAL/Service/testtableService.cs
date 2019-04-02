using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;

namespace BAL.Service
{
    public class testtableService
    {
        private testtableDAL dal = new testtableDAL();
        public void Save(testtable table)
        {
            dal.Add(table);
        }

        public void Update(testtable table)
        {
            dal.Update(table);
        }

        public void Delete(testtable table)
        {
        }

        public void GetMode(string id)
        { }

        public List<testtable> GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
    }
}
