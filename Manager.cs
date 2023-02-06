using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DatabaseFinal
{
    public class Manager
    {
        private int EmployeeId { get; set; }

        private int ManagedDepartemtId { get; set; }

        private static NpgsqlConnection _connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=;User Id=postgres;Password=;");

        public Manager(int employeeId, int managedDepartemtId)
        {
            EmployeeId = employeeId;
            ManagedDepartemtId = managedDepartemtId;
           
        }

        private static DataTable GetConnection(string statment)
        {
            _connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = _connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = statment;
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
            GetConnection("INSERT INTO manager(employeeid, manageddepartmentid) VALUES(" + this.EmployeeId + ", " + this.ManagedDepartemtId + ")");
        }

        public static DataTable Select(int empId)
        {
            return GetConnection("select * from manager where employeeid = " + empId);
        }

        public static DataTable SelectManagedDepartment(int manDeptId)
        {
            return GetConnection("select * from manager where manageddepartmentid = " + manDeptId);
        }
        public static DataTable SelectID()
        {
            return GetConnection("select employeeid from manager;");
        }

        public static DataTable SelectAll()
        {
            return GetConnection("select * from manager");
        }

        public void Delete()
        {
            GetConnection("Delete from manager where employeeid = " + this.EmployeeId);
        }

        public void DeleteManagedDepartment()
        {
            GetConnection("Delete from from manager where manageddepartmentid = " + this.ManagedDepartemtId);
        }
        public void Update()
        {
            GetConnection("UPDATE manager Set manageddepartmentid = '" + this.ManagedDepartemtId + "', employeeid =" + this.EmployeeId +" where manageddepartmentid = " + this.ManagedDepartemtId);
        }

        public override string ToString()
        {
            return "EmployeeId: " + this.EmployeeId + " ManagedDepartmentId: "+ this.ManagedDepartemtId;
        }


    }
}
