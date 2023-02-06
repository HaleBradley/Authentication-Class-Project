using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseFinal
{
    public class Employee
    {
        private int EmployeeID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Phone { get; set; }
        public double Salary { get; set; }
        public int AddressID { get; set; }

        private static NpgsqlConnection _connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=;User Id=postgres;Password=;");
        
        public Employee(string fname, string lname, string email, string pass, string phone, double salary, int addressID)
        { 
            this.Fname = fname;
            this.Lname = lname;
            this.Email = email;
            this.Pass = pass;
            this.Phone = phone;
            this.Salary = salary;
            this.AddressID = addressID;
            Insert();
        }

        public Employee(int employeeID)
        {
            DataTable temp = Select(employeeID);
        
            this.EmployeeID = Convert.ToInt32(temp.Rows[0][0].ToString());
            this.Fname = temp.Rows[0][1].ToString();
            this.Lname = temp.Rows[0][2].ToString();
            this.Email = temp.Rows[0][3].ToString();
            this.Pass = temp.Rows[0][4].ToString();
            this.Phone = temp.Rows[0][5].ToString();
            this.Salary = Convert.ToDouble(temp.Rows[0][6].ToString());
            this.AddressID = Convert.ToInt32(temp.Rows[0][7].ToString());
        }

        private static DataTable GetConnection(string statement)
        {
            _connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = _connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = statement;
            //Prepares the sql statement
            cmd.Prepare();

            //data adapter
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmd.Dispose();
            _connection.Close();
            return dt;
        }

        public void Insert()
        {
            GetConnection("INSERT INTO employee(fname, lname, email, pass, phone, salary, addressID) VALUES('" + Fname + "', '" + Lname + "', '" + Email + "', '" + Pass + "', '" + Phone + "', " + Salary + ", " + AddressID + ")");
        }

        
        private int SelectEmployeeID()
        {
            return Convert.ToInt32(GetConnection("SELECT employeeID FROM employee" + 
            "WHERE fname = '" + this.Fname + "' AND lname = '" + this.Lname + "' AND " +
            "email = '" + this.Email + "' AND pass = '" + this.Pass + "' AND " +
            "phone = '" + this.Phone + "' AND salary = " + this.Salary +
            " AND addressID = " + this.AddressID) );
        }
        

        public static DataTable Select(int employeeID)
        {
            return GetConnection("SELECT * FROM employee WHERE employeeID = " + employeeID);
        }

        public static DataTable Select(string email)
        {
            return GetConnection("SELECT * FROM employee WHERE email = '" + email + "'");
        }

        public static DataTable SelectID()
        {
            return GetConnection("select employeeid from employee;");
        }
        public static DataTable SelectPassword(string pass)
        {
            return GetConnection("select pass from employee where pass = '" + pass + "'");
        }

        public static DataTable SelectAll()
        {
            return GetConnection("select * from employee");
        }


        public void DeleteID()
        {
            GetConnection("DELETE FROM assigned_to WHERE employeeID = " + EmployeeID);
            GetConnection("DELETE FROM manager WHERE employeeID = " + EmployeeID);
            GetConnection("DELETE FROM pay_history WHERE employeeID = " + EmployeeID);
            GetConnection("DELETE FROM employee WHERE employeeID = " + EmployeeID);
        }

        public void DeleteEmail()
        {
            DataTable dtTemp = GetConnection("SELECT employeeID FROM employee WHERE email = '" + Email + "'");
            int id = int.Parse(dtTemp.Rows[0][0].ToString());

            GetConnection("DELETE FROM assigned_to WHERE employeeID = " + id);
            GetConnection("DELETE FROM manager WHERE employeeID = " + id);
            GetConnection("DELETE FROM pay_history WHERE employeeID = " + id);
            GetConnection("DELETE FROM employee WHERE employeeID = " + id);
        }

        public void Update()
        {
            GetConnection("UPDATE employee SET fname = '" + Fname + "', lname = '" + Lname + "', email = '"
                + Email + "', pass = '" + Pass + "', phone = '" + Phone + "', salary = " + Salary + ", addressID = " + AddressID + " WHERE employeeid = " + EmployeeID);
        }

        public override string ToString()
        {
            return "EmployeeID: " + EmployeeID + ", Fname: " + Fname + ", Lname: " + Lname + ", Email: " + Email + ", Pass: " + Pass + ", Phone: " + Phone + ", Salary: " + Salary + ", AddressID: " + AddressID; ;
        }

    }
}
