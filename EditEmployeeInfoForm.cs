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
    public partial class EditEmployeeInfoForm : Form
    {
        public EditEmployeeInfoForm()
        {
            InitializeComponent();
        }

        private void EditEmployeeInfoForm_Load(object sender, EventArgs e)
        {
            personalInfoDataGridView.DataSource = Employee.Select(LoginForm.currentUserId);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Employee tempEmp = new Employee(LoginForm.currentUserId);
            if(!fnameTextBox.Text.Equals(""))
            {
                tempEmp.Fname = fnameTextBox.Text;
            }
            if (!lnameTextBox.Text.Equals(""))
            {
                tempEmp.Lname = lnameTextBox.Text;
            }
            if (!emailTextBox.Text.Equals(""))
            {
                tempEmp.Email = emailTextBox.Text;
            }
            if (!passTextBox.Text.Equals(""))
            {
                tempEmp.Pass = passTextBox.Text;
            }
            if (!phoneTextBox.Text.Equals(""))
            {
                tempEmp.Phone = phoneTextBox.Text;
            }
            tempEmp.Update();

            personalInfoDataGridView.DataSource = Employee.Select(LoginForm.currentUserId);

            ClearTextBoxes();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            EmployeeFrom employeeFrom = new EmployeeFrom();
            employeeFrom.Show();
            this.Hide();
        }

        private void ClearTextBoxes()
        {
            fnameTextBox.Text = "";
            lnameTextBox.Text = "";
            emailTextBox.Text = "";
            passTextBox.Text = "";
            phoneTextBox.Text = "";
        }
    }
}
