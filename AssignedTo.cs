using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

 namespace DatabaseFinal
{
    public class AssignedTo
    {
        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }

        private static NpgsqlConnection _connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=;User Id=postgres;Password=;");

        public AssignedTo(int employeeID, int departmentID)
        {
            this.EmployeeID = employeeID;
            this.DepartmentID = departmentID;
        }

        private static DataTable GetConnection(string statement)
        {
            _connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = _connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = statement;


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
            GetConnection("INSERT INTO assigned_to(employeeID, departmentID) VALUES(" + EmployeeID + ", " + DepartmentID + ")");
        }

        public static DataTable SelectEmployee(int employeeID)
        {
            return GetConnection("SELECT * FROM assigned_to WHERE employeeID = " + employeeID);
        }

        public static DataTable SelectDepartment(int departmentID)
        {
            return GetConnection("SELECT * FROM assigned_to WHERE departmentID = " + departmentID);
        }

        public static DataTable SelectAll()
        {
            return GetConnection("SELECT * FROM assigned_to");
        }

        public void Update()
        {
            GetConnection("UPDATE assigned_to SET employeeID = " + EmployeeID + ", departmentId = " + DepartmentID);
        }

        public DataTable Delete()
        {
            return GetConnection("DELETE FROM assigned_to WHERE employeeID = " + this.EmployeeID + " AND departmentId = " + this.DepartmentID);
        }

        public override string ToString()
        {
            return "EmployeeID: " + EmployeeID + ", DepartmentID: " + DepartmentID;
        }
    }
}
