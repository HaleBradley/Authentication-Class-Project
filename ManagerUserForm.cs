using DatabaseFinal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseFinal
{
    public partial class ManagerUserForm : Form
    {
        int selectedEmployeeID;
        Employee tempEmp;
        PayHistory tempPayHistory;


        int selectedPayHistory;

        int selectedAddressId;
        Address tempAddress;

        int selectedDepartmentId;
        Department tempDepartment;

        int selectedAssignToEmployeeId;
        int selectedAssignToDepartmentId;
        AssignedTo tempAssignTo;

        public ManagerUserForm()
        {
            InitializeComponent();

            dataGridView1.DataSource = Employee.SelectAll();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.DataSource = PayHistory.SelectAll();
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addressDataGridView.DataSource = Address.SelectAll();
            addressDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            departmentDataGridView.DataSource = Department.SelectAll();
            departmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AssignToDataGridView.DataSource = AssignedTo.SelectAll();
            AssignToDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedEmployeeID = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            tempEmp = new Employee(selectedEmployeeID);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tempEmp != null)
            {

                if (!fnameTextBox.Text.Equals(""))
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
                if (!salaryTextBox.Text.Equals(""))
                {
                    tempEmp.Salary = double.Parse(salaryTextBox.Text);
                }
                if (!addressidTextBox.Text.Equals(""))
                {
                    tempEmp.AddressID = int.Parse(addressidTextBox.Text);
                }
                tempEmp.Update();
                dataGridView1.DataSource = Employee.SelectAll();
            }

            else
            {
                MessageBox.Show("Please select a employee");
            }
            }
           

        

        private void ManagerUserForm_Load(object sender, EventArgs e)
        {

        }

        private void ManagerUserForm_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Closing");
            System.Windows.Forms.Application.ExitThread();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tempEmp.DeleteID();
            dataGridView1.DataSource = Employee.SelectAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Fname;
            string Lname;
            string Email;
            string Pass;
            string Phone;
            double Salary;
            int AddressID;

            try
            {
                if (!fnameTextBox.Text.Equals(""))
                {
                    Fname = fnameTextBox.Text.Trim();
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }
                if (!lnameTextBox.Text.Equals(""))
                {
                    Lname = lnameTextBox.Text.Trim();
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }
                if (!emailTextBox.Text.Equals(""))
                {
                    Email = emailTextBox.Text.Trim();
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }
                if (!passTextBox.Text.Equals(""))
                {
                    Pass = passTextBox.Text.Trim();
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }
                if (!phoneTextBox.Text.Equals(""))
                {
                    Phone = phoneTextBox.Text.Trim();
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }
                if (!salaryTextBox.Text.Equals(""))
                {
                    Salary = double.Parse(salaryTextBox.Text.Trim());
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }
                if (!addressidTextBox.Text.Equals(""))
                {
                    AddressID = int.Parse(addressidTextBox.Text.Trim());
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }
                Employee newTempEmp = new Employee(Fname, Lname, Email, Pass, Phone, Salary, AddressID);

                dataGridView1.DataSource = Employee.SelectAll();

                ClearEmployeeInfoTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Add Employee. All Text Boxes Must Have a Value");
            }
        }

        private void Payamount_TextChanged(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // tempPayHistory = new PayHistory(5,123239,"1000-01-01");

            if (tempPayHistory != null)
            {
                if (!payamountTextBox.Text.Equals(""))
                {
                    tempPayHistory.PayAmount = decimal.Parse(payamountTextBox.Text.ToString());
                }

                if (!dateBoxTextBox.Text.Equals(""))
                {
                    tempPayHistory.Date = dateBoxTextBox.Text;
                    DateTime date = new DateTime();
                    date = DateTime.Parse(dateBoxTextBox.Text);
                    tempPayHistory.Date = date.ToString("yyyy'-'MM'-'dd");
                }

                tempPayHistory.Update();
                dataGridView2.DataSource = PayHistory.SelectAll();
            }
            else
            {
                MessageBox.Show("Please select an Employee");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ClearEmployeeInfoTextBoxes()
        {
            fnameTextBox.Clear();
            lnameTextBox.Clear();
            emailTextBox.Clear();
            passTextBox.Clear();
            phoneTextBox.Clear();
            salaryTextBox.Clear();
            addressidTextBox.Clear();
        }

        private void ClearAddressTextBoxes()
        {
            lineTextBox.Clear();
            cityTextBox.Clear();
            stateTextBox.Clear();
            zipcodeTextBox.Clear();
            countryTextBox.Clear();
        }

        private void ClearDepartmentTextBoxes()
        {
            departmentAddressIdTextBox.Clear();
            nameTextBox.Clear();
        }

        private void ClearAssignToTextBoxes()
        {
            assignedEmployeeIdTextBox.Clear();
            assignedDepartmentIdTextBox.Clear();
        }

        private void ClearPayHistoryTextBoxes()
        {
            payamountTextBox.Clear();
            dateBoxTextBox.Clear();
        }

        private void addressSubmitButton_Click(object sender, EventArgs e)
        {
            if (tempAddress != null)
            {


                if (!lineTextBox.Text.Equals(""))
                {
                    tempAddress.SetLine(lineTextBox.Text);
                }
                if (!cityTextBox.Text.Equals(""))
                {
                    tempAddress.SetCity(cityTextBox.Text);
                }
                if (!stateTextBox.Text.Equals(""))
                {
                    tempAddress.SetState(stateTextBox.Text);
                }
                if (!zipcodeTextBox.Text.Equals(""))
                {
                    tempAddress.SetZipCode(zipcodeTextBox.Text);
                }
                if (!countryTextBox.Text.Equals(""))
                {
                    tempAddress.SetCountry(countryTextBox.Text);
                }
                tempAddress.Update();

                ClearAddressTextBoxes();

                addressDataGridView.DataSource = Address.SelectAll();
            }
            else
            {
                MessageBox.Show("Please select a Address");
            }
           
        }
    

        private void addressAddButton_Click(object sender, EventArgs e)
        {
            int tempAddressId;
            string tempLine;
            string tempCity;
            string tempState;
            string tempZipcode;
            string tempCountry;

            try
            {
                if (!lineTextBox.Text.Equals(""))
                {
                    tempLine = lineTextBox.Text.Trim();
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }
                if (!cityTextBox.Text.Equals(""))
                {
                    tempCity = cityTextBox.Text.Trim();
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }
                if (!stateTextBox.Text.Equals(""))
                {
                     tempState = stateTextBox.Text.Trim();
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }
                if (!zipcodeTextBox.Text.Equals(""))
                {
                    tempZipcode = zipcodeTextBox.Text.Trim();
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }
                if (!countryTextBox.Text.Equals(""))
                {
                    tempCountry = countryTextBox.Text.Trim();
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }
              
                Address newTempAddress = new Address(tempLine, tempCity, tempState, tempZipcode, tempCountry);

                addressDataGridView.DataSource = Address.SelectAll();

                ClearAddressTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Add Address. All Text Boxes Must Have a Value");
            }
        }

        

        private void addressDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedAddressId = Convert.ToInt32(addressDataGridView.SelectedCells[0].Value.ToString());
            tempAddress = new Address(selectedAddressId);
        }

        private void departmentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDepartmentId = Convert.ToInt32(departmentDataGridView.SelectedCells[0].Value.ToString());
            tempDepartment = new Department(selectedDepartmentId);
        }

        private void AssignToDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedAssignToEmployeeId = Convert.ToInt32(AssignToDataGridView.SelectedCells[0].Value.ToString());
            selectedAssignToDepartmentId = Convert.ToInt32(AssignToDataGridView.SelectedCells[1].Value.ToString());

            tempAssignTo = new AssignedTo(selectedAssignToEmployeeId, selectedAssignToDepartmentId);

            //tempAssignTo = new AssignedTo(Convert.ToInt32(AssignToDataGridView.SelectedCells[0].Value.ToString()), Convert.ToInt32(AssignToDataGridView.SelectedCells[1].Value.ToString()));
        }

        private void departmentSubmitButton_Click(object sender, EventArgs e)
        {
            if (tempDepartment != null)
            {
                if (!departmentAddressIdTextBox.Text.Equals(""))
                {
                    tempDepartment.AddressId = int.Parse(departmentAddressIdTextBox.Text);
                }
                if (!nameTextBox.Text.Equals(""))
                {
                    tempDepartment.Name = nameTextBox.Text;
                }

                tempDepartment.Update();

                ClearDepartmentTextBoxes();

                departmentDataGridView.DataSource = Department.SelectAll();
            }
            else
            {
                MessageBox.Show("Please select an employee");
            }
        }

        private void departmentAddButton_Click(object sender, EventArgs e)
        {
            int tempAddressId;
            string tempName;
 
            try
            {
                if (!departmentAddressIdTextBox.Text.Equals(""))
                {
                    tempAddressId = int.Parse(departmentAddressIdTextBox.Text.Trim());
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }
                if (!nameTextBox.Text.Equals(""))
                {
                    tempName = nameTextBox.Text.Trim();
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }
               
                tempDepartment = new Department(tempAddressId, tempName);
                departmentDataGridView.DataSource = Department.SelectAll();
                ClearDepartmentTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Add Department. All Text Boxes Must Have a Value");
            }
        }

        private void assignedToAddButton_Click(object sender, EventArgs e)
        {
            int tempEmployeeId;
            int tempDepartmentId;

            try
            {
                if (!assignedEmployeeIdTextBox.Text.Equals(""))
                {
                    tempEmployeeId = int.Parse(assignedEmployeeIdTextBox.Text.Trim());
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }
                if (!assignedDepartmentIdTextBox.Text.Equals(""))
                {
                    tempDepartmentId = int.Parse(assignedDepartmentIdTextBox.Text.Trim());
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }

                tempAssignTo = new AssignedTo(tempEmployeeId, tempDepartmentId);
                tempAssignTo.Insert();
                AssignToDataGridView.DataSource = AssignedTo.SelectAll();
                ClearAssignToTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Add That Relationship. All Text Boxes Must Have a Value");
            }
        }

        private void assignedToDeleteButton_Click(object sender, EventArgs e)
        {
            tempAssignTo.Delete();
            AssignToDataGridView.DataSource = AssignedTo.SelectAll();
        }

        private void payHistoryAdd_Click(object sender, EventArgs e)
        {
            int tempEmployeeId;
            decimal tempPayAmount;
            string tempDate;

            try
            {
                if (!payHistoryEmployeeIdTextBox.Text.Equals(""))
                {
                    tempEmployeeId = int.Parse(payHistoryEmployeeIdTextBox.Text.Trim());
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }
                if (!payamountTextBox.Text.Equals(""))
                {
                    tempPayAmount = decimal.Parse(payamountTextBox.Text.Trim());
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }
                if (!dateBoxTextBox.Text.Equals(""))
                {
                    tempDate = dateBoxTextBox.Text.Trim();
                }
                else
                {
                    throw new Exception("Invalid Inputs");
                }

                tempPayHistory = new PayHistory(tempEmployeeId, tempPayAmount, tempDate);
                tempPayHistory.Insert();
                dataGridView2.DataSource = PayHistory.SelectAll();
                ClearPayHistoryTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Add Pay History. All Text Boxes Must Have a Value");
            }
        }

        private void deletePayhistoryButton_Click(object sender, EventArgs e)
        {
            tempPayHistory = new PayHistory(selectedPayHistory);
            tempPayHistory.Delete();
            dataGridView2.DataSource=PayHistory.SelectAll();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedPayHistory = Convert.ToInt32(dataGridView2.SelectedCells[0].Value.ToString());
            MessageBox.Show(selectedPayHistory + "");
            tempPayHistory = new PayHistory(selectedPayHistory);
        }

        private void SS(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addressDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
