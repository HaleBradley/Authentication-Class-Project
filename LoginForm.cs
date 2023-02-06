using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseFinal;

namespace DatabaseFinal
{
    public partial class LoginForm : Form
    {
        public static int currentUserId;
        public LoginForm()
        {
            InitializeComponent();
        }

        bool PasswordCorrect;
        bool EmailCorrect;

        private void LoginForm_Load(object sender, EventArgs e)
        {


        }

        public int ValidateEmail()
        {
         
            DataTable Employeeids = Employee.Select(emailBox.Text.ToString());
               if (Employeeids.Rows[0]["email"].ToString() == emailBox.Text)
                {
                    EmailCorrect = true;
                }
                return int.Parse(Employeeids.Rows[0]["employeeID"].ToString());
            
            
            
        }








        public bool isManager(int empID)
        {
            DataTable manIds = Manager.SelectID();

            foreach (DataRow x in manIds.Rows)
            {
                int manId = int.Parse(x[0].ToString());
                if (empID == manId)
                {
                    return true;
                }
            }

            return false;
        }

        public void ValidatePassword(int empId)
        {
          
            DataTable Employeeids = Employee.Select(empId);
           
                if (Employeeids.Rows[0]["pass"].ToString() == PasswordBox.Text)
                {
                    PasswordCorrect = true;
                }
            
           
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            // DataTable Employeeids = Employee.Select(emailBox.Text.ToString());

            if (PasswordBox.Text != string.Empty && emailBox.Text != string.Empty)
            {
                try
                {
                    int empID = ValidateEmail();
                    ValidatePassword(empID);
                    currentUserId = empID;
                    if (this.isManager(empID) && EmailCorrect && PasswordCorrect)
                {
                    ManagerFrom employeeFrom = new ManagerFrom();
                    employeeFrom.Show();
                    this.Hide();
                }
                else if (EmailCorrect && PasswordCorrect)
                {
                    EmployeeFrom employeeFrom = new EmployeeFrom();
                    employeeFrom.Show();
                    this.Hide();



                }
                    
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Email or password was incorrect");
                }

            }
        }



    }
}
