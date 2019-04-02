using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BAL.Service;
using Model;

namespace LinqFromAccess
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSerachAll_Click(object sender, EventArgs e)
        {
            testtableService service = new testtableService();
            List<testtable> testTableList = service.GetList("");
            StringBuilder strBuilder = new StringBuilder();
            foreach (testtable item in testTableList)
            {
                strBuilder.AppendLine(string.Format("testtable :**col1,{0},**col2,{1}",item.col1,item.col2));
            }
            MessageBox.Show(strBuilder.ToString());
        }

        private void btnAddLinq_Click(object sender, EventArgs e)
        {
            ContexttestTableService service = new ContexttestTableService();
            testtable table = new testtable();
            table.col1 = "99999";
            table.col2 = "000000";
            service.Save(table);
            MessageBox.Show("增加数据成功！");
        }

        private void btnSearchall_Click(object sender, EventArgs e)
        {
            ContexttestTableService service = new ContexttestTableService();
            List<testtable> listTable=service.GetList("");
            MessageBox.Show(string.Format("总个数：{0}",listTable.Count));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ContexttestTableService service = new ContexttestTableService();
            testtable table=new testtable();
            table.col1="66";
            service.Delete(table);
            MessageBox.Show("删除成功！");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ContextDepartmentService deptService = new ContextDepartmentService();
            List<Department> depList = deptService.GetList("");
            MessageBox.Show(string.Format("总个数：{0}",depList.Count));
        }

        private void btnDeleteDept_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {

        }

        private void v(object sender, EventArgs e)
        {

        }

        private void btnMaxId_Click(object sender, EventArgs e)
        {
            ContextDepartmentService deptService = new ContextDepartmentService();
            MessageBox.Show(deptService.GetMaxId().ToString());
        }

        private void btnAddDeptList_Click(object sender, EventArgs e)
        {
            ContextDepartmentService deptService = new ContextDepartmentService();
            for (int i = 0; i < 100; i++)
            {
                Department dept = new Department();
                dept.DepartmentID = deptService.GetMaxId() + 1;
                dept.Administrator = 99 + i;
                dept.Budget = 100 + i;
                dept.Name = i.ToString();
                dept.StartDate = DateTime.Now;
                deptService.Save(dept);
            }
        }
    }
}
