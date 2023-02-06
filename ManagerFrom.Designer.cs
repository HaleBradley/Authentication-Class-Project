namespace DatabaseFinal
{
    partial class ManagerFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DepartmentGridView = new System.Windows.Forms.DataGridView();
            this.DepartmentLb = new System.Windows.Forms.Label();
            this.PayHistoryGridView = new System.Windows.Forms.DataGridView();
            this.PayHistoryLb = new System.Windows.Forms.Label();
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.AddressGridView = new System.Windows.Forms.DataGridView();
            this.AssignedToGridView = new System.Windows.Forms.DataGridView();
            this.Employees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayHistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignedToGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartmentGridView
            // 
            this.DepartmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentGridView.Location = new System.Drawing.Point(82, 70);
            this.DepartmentGridView.Name = "DepartmentGridView";
            this.DepartmentGridView.RowHeadersWidth = 51;
            this.DepartmentGridView.RowTemplate.Height = 24;
            this.DepartmentGridView.Size = new System.Drawing.Size(304, 150);
            this.DepartmentGridView.TabIndex = 0;
            // 
            // DepartmentLb
            // 
            this.DepartmentLb.AutoSize = true;
            this.DepartmentLb.Location = new System.Drawing.Point(187, 29);
            this.DepartmentLb.Name = "DepartmentLb";
            this.DepartmentLb.Size = new System.Drawing.Size(84, 16);
            this.DepartmentLb.TabIndex = 1;
            this.DepartmentLb.Text = "Departments";
            // 
            // PayHistoryGridView
            // 
            this.PayHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PayHistoryGridView.Location = new System.Drawing.Point(76, 309);
            this.PayHistoryGridView.Name = "PayHistoryGridView";
            this.PayHistoryGridView.RowHeadersWidth = 51;
            this.PayHistoryGridView.RowTemplate.Height = 24;
            this.PayHistoryGridView.Size = new System.Drawing.Size(310, 150);
            this.PayHistoryGridView.TabIndex = 2;
            // 
            // PayHistoryLb
            // 
            this.PayHistoryLb.AutoSize = true;
            this.PayHistoryLb.Location = new System.Drawing.Point(187, 273);
            this.PayHistoryLb.Name = "PayHistoryLb";
            this.PayHistoryLb.Size = new System.Drawing.Size(73, 16);
            this.PayHistoryLb.TabIndex = 3;
            this.PayHistoryLb.Text = "PayHistory";
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGridView.Location = new System.Drawing.Point(565, 70);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.RowHeadersWidth = 51;
            this.EmployeeGridView.RowTemplate.Height = 24;
            this.EmployeeGridView.Size = new System.Drawing.Size(330, 150);
            this.EmployeeGridView.TabIndex = 4;
            // 
            // AddressGridView
            // 
            this.AddressGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddressGridView.Location = new System.Drawing.Point(565, 309);
            this.AddressGridView.Name = "AddressGridView";
            this.AddressGridView.RowHeadersWidth = 51;
            this.AddressGridView.RowTemplate.Height = 24;
            this.AddressGridView.Size = new System.Drawing.Size(330, 150);
            this.AddressGridView.TabIndex = 5;
            // 
            // AssignedToGridView
            // 
            this.AssignedToGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignedToGridView.Location = new System.Drawing.Point(1007, 70);
            this.AssignedToGridView.Name = "AssignedToGridView";
            this.AssignedToGridView.RowHeadersWidth = 51;
            this.AssignedToGridView.RowTemplate.Height = 24;
            this.AssignedToGridView.Size = new System.Drawing.Size(328, 150);
            this.AssignedToGridView.TabIndex = 6;
            // 
            // Employees
            // 
            this.Employees.AutoSize = true;
            this.Employees.Location = new System.Drawing.Point(682, 29);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(76, 16);
            this.Employees.TabIndex = 7;
            this.Employees.Text = "Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(696, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1095, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Department Members";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UpdateAll
            // 
            this.UpdateAll.Location = new System.Drawing.Point(1007, 309);
            this.UpdateAll.Name = "UpdateAll";
            this.UpdateAll.Size = new System.Drawing.Size(105, 45);
            this.UpdateAll.TabIndex = 10;
            this.UpdateAll.Text = "Update Employee";
            this.UpdateAll.UseVisualStyleBackColor = true;
            this.UpdateAll.Click += new System.EventHandler(this.UpdateAll_Click);
            // 
            // ManagerFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 540);
            this.Controls.Add(this.UpdateAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.AssignedToGridView);
            this.Controls.Add(this.AddressGridView);
            this.Controls.Add(this.EmployeeGridView);
            this.Controls.Add(this.PayHistoryLb);
            this.Controls.Add(this.PayHistoryGridView);
            this.Controls.Add(this.DepartmentLb);
            this.Controls.Add(this.DepartmentGridView);
            this.Name = "ManagerFrom";
            this.Text = "ManagerFrom";
            this.Load += new System.EventHandler(this.ManagerFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayHistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignedToGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DepartmentGridView;
        private System.Windows.Forms.Label DepartmentLb;
        private System.Windows.Forms.DataGridView PayHistoryGridView;
        private System.Windows.Forms.Label PayHistoryLb;
        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.DataGridView AddressGridView;
        private System.Windows.Forms.DataGridView AssignedToGridView;
        private System.Windows.Forms.Label Employees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UpdateAll;
    }
}