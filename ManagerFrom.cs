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
    public partial class ManagerFrom : Form
    {
        public ManagerFrom()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ManagerFrom_Load(object sender, EventArgs e)
        {

            Manager manager = new Manager(LoginForm.currentUserId, 2);

            DepartmentGridView.DataSource = Department.SelectAll();

            AddressGridView.DataSource = Address.SelectAll();

            EmployeeGridView.DataSource = Employee.SelectAll();

            PayHistoryGridView.DataSource = PayHistory.SelectAll();

            AssignedToGridView.DataSource = AssignedTo.SelectAll();

        }

        private void UpdateAll_Click(object sender, EventArgs e)
        {

            ManagerUserForm form = new ManagerUserForm();
            this.Hide();
            form.Show();
        }
    }
}
