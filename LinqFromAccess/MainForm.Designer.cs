namespace LinqFromAccess
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSerachAll = new System.Windows.Forms.Button();
            this.btnAddLinq = new System.Windows.Forms.Button();
            this.btnSearchall = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.btnDeleteDept = new System.Windows.Forms.Button();
            this.btnSerachDept = new System.Windows.Forms.Button();
            this.btnMaxId = new System.Windows.Forms.Button();
            this.btnAddDeptList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSerachAll
            // 
            this.btnSerachAll.Location = new System.Drawing.Point(12, 12);
            this.btnSerachAll.Name = "btnSerachAll";
            this.btnSerachAll.Size = new System.Drawing.Size(433, 45);
            this.btnSerachAll.TabIndex = 0;
            this.btnSerachAll.Text = "查询所有";
            this.btnSerachAll.UseVisualStyleBackColor = true;
            this.btnSerachAll.Click += new System.EventHandler(this.btnSerachAll_Click);
            // 
            // btnAddLinq
            // 
            this.btnAddLinq.Location = new System.Drawing.Point(6, 20);
            this.btnAddLinq.Name = "btnAddLinq";
            this.btnAddLinq.Size = new System.Drawing.Size(105, 31);
            this.btnAddLinq.TabIndex = 1;
            this.btnAddLinq.Text = "Linq增加一条";
            this.btnAddLinq.UseVisualStyleBackColor = true;
            this.btnAddLinq.Click += new System.EventHandler(this.btnAddLinq_Click);
            // 
            // btnSearchall
            // 
            this.btnSearchall.Location = new System.Drawing.Point(6, 68);
            this.btnSearchall.Name = "btnSearchall";
            this.btnSearchall.Size = new System.Drawing.Size(105, 31);
            this.btnSearchall.TabIndex = 2;
            this.btnSearchall.Text = "查询全部";
            this.btnSearchall.UseVisualStyleBackColor = true;
            this.btnSearchall.Click += new System.EventHandler(this.btnSearchall_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除一条数据";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddLinq);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSearchall);
            this.groupBox1.Location = new System.Drawing.Point(24, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 204);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "testtale";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddDeptList);
            this.groupBox2.Controls.Add(this.btnMaxId);
            this.groupBox2.Controls.Add(this.btnAddDept);
            this.groupBox2.Controls.Add(this.btnDeleteDept);
            this.groupBox2.Controls.Add(this.btnSerachDept);
            this.groupBox2.Location = new System.Drawing.Point(245, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 204);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "部门";
            this.groupBox2.AutoSizeChanged += new System.EventHandler(this.v);
            // 
            // btnAddDept
            // 
            this.btnAddDept.Location = new System.Drawing.Point(6, 20);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(105, 31);
            this.btnAddDept.TabIndex = 1;
            this.btnAddDept.Text = "Linq增加一条";
            this.btnAddDept.UseVisualStyleBackColor = true;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // btnDeleteDept
            // 
            this.btnDeleteDept.Location = new System.Drawing.Point(6, 107);
            this.btnDeleteDept.Name = "btnDeleteDept";
            this.btnDeleteDept.Size = new System.Drawing.Size(105, 31);
            this.btnDeleteDept.TabIndex = 3;
            this.btnDeleteDept.Text = "删除一条部门数据";
            this.btnDeleteDept.UseVisualStyleBackColor = true;
            this.btnDeleteDept.AutoSizeChanged += new System.EventHandler(this.v);
            this.btnDeleteDept.Click += new System.EventHandler(this.btnDeleteDept_Click);
            // 
            // btnSerachDept
            // 
            this.btnSerachDept.Location = new System.Drawing.Point(6, 68);
            this.btnSerachDept.Name = "btnSerachDept";
            this.btnSerachDept.Size = new System.Drawing.Size(105, 31);
            this.btnSerachDept.TabIndex = 2;
            this.btnSerachDept.Text = "查询部门全部";
            this.btnSerachDept.UseVisualStyleBackColor = true;
            this.btnSerachDept.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMaxId
            // 
            this.btnMaxId.Location = new System.Drawing.Point(6, 151);
            this.btnMaxId.Name = "btnMaxId";
            this.btnMaxId.Size = new System.Drawing.Size(105, 31);
            this.btnMaxId.TabIndex = 4;
            this.btnMaxId.Text = "ID最大值";
            this.btnMaxId.UseVisualStyleBackColor = true;
            this.btnMaxId.Click += new System.EventHandler(this.btnMaxId_Click);
            // 
            // btnAddDeptList
            // 
            this.btnAddDeptList.Location = new System.Drawing.Point(117, 20);
            this.btnAddDeptList.Name = "btnAddDeptList";
            this.btnAddDeptList.Size = new System.Drawing.Size(64, 31);
            this.btnAddDeptList.TabIndex = 5;
            this.btnAddDeptList.Text = "批量增加部门";
            this.btnAddDeptList.UseVisualStyleBackColor = true;
            this.btnAddDeptList.Click += new System.EventHandler(this.btnAddDeptList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 302);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSerachAll);
            this.Name = "MainForm";
            this.Text = "测试窗口";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSerachAll;
        private System.Windows.Forms.Button btnAddLinq;
        private System.Windows.Forms.Button btnSearchall;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddDept;
        private System.Windows.Forms.Button btnDeleteDept;
        private System.Windows.Forms.Button btnSerachDept;
        private System.Windows.Forms.Button btnMaxId;
        private System.Windows.Forms.Button btnAddDeptList;
    }
}

