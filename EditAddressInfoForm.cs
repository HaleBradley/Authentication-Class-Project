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
    public partial class EditAddressInfoForm : Form
    {
        private int addressID;
        public EditAddressInfoForm()
        {
            InitializeComponent();
        }

        private void EditAddressInfoForm_Load(object sender, EventArgs e)
        {
            DataTable dtTemp = Employee.Select(LoginForm.currentUserId);
            addressID = int.Parse(dtTemp.Rows[0]["addressid"].ToString());

            addressInfoDataGridView.DataSource = Address.SelectByAddressID(addressID);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Address tempAdd = new Address(addressID);
            if (!lineTextBox.Text.Equals(""))
            {
                tempAdd.SetLine(lineTextBox.Text);
            }
            if (!cityTextBox.Text.Equals(""))
            {
                tempAdd.SetCity(cityTextBox.Text);
            }
            if (!stateTextBox.Text.Equals(""))
            {
                tempAdd.SetState(stateTextBox.Text);
            }
            if (!zipcodeTextBox.Text.Equals(""))
            {
                tempAdd.SetZipCode(zipcodeTextBox.Text);
            }
            if (!countryTextBox.Text.Equals(""))
            {
                tempAdd.SetCountry(countryTextBox.Text);
            }
            tempAdd.Update();

            addressInfoDataGridView.DataSource = Address.SelectByAddressID(addressID);

            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            lineTextBox.Text = "";
            cityTextBox.Text = "";
            stateTextBox.Text = "";
            zipcodeTextBox.Text = "";
            countryTextBox.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            EmployeeFrom employeeFrom = new EmployeeFrom();
            employeeFrom.Show();
            this.Hide();
        }
    }
}
