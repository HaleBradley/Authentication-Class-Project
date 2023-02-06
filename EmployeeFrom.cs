using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseFinal
{
    public partial class EmployeeFrom : Form
    {
        public EmployeeFrom()
        {
            InitializeComponent();
        }

        private void EmployeeFrom_Load(object sender, EventArgs e)
        {
            payHistoryDataGridView.DataSource = PayHistory.Select(LoginForm.currentUserId);
            personalInfoDataGridView.DataSource = Employee.Select(LoginForm.currentUserId);
            addressInfoDataGridView.DataSource = Address.SelectByAddressID(LoginForm.currentUserId);
        }

        private void personalInfoEditButton_Click(object sender, EventArgs e)
        {
            EditEmployeeInfoForm employeeEditForm = new EditEmployeeInfoForm();
            employeeEditForm.Show();
            this.Hide();
        }

        private void addressInformationEditButton_Click(object sender, EventArgs e)
        {
            EditAddressInfoForm addressEditForm = new EditAddressInfoForm();
            addressEditForm.Show();
            this.Hide();
        }
    }
}
