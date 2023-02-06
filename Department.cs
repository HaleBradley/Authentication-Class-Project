using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DatabaseFinal
{
    public class Department
    {
        private int DepartmentId { get; set; }
        public int AddressId { get; set; }
        public string Name { get; set; } 

        private static NpgsqlConnection _connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=;User Id=postgres;Password=;");

        public Department(int addressId, string dname) 
        {
            this.AddressId = addressId; 
            this.Name = dname;
            Insert();
        }

        public Department(int departmentId){
            DataTable temp = Select(departmentId);
            
            this.DepartmentId = Convert.ToInt32(temp.Rows[0][0].ToString());
            this.AddressId = Convert.ToInt32(temp.Rows[0][1].ToString());
            this.Name = temp.Rows[0][2].ToString();
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

        public static DataTable Select(int deptId)
        {
           return GetConnection("select * from department where departmentid = " + deptId);
        }

        public static DataTable Select(string name)
        {
            return GetConnection("select * from department where dname = '" + name + "'");
        }

        public static DataTable SelectAll()
        {
            return GetConnection("select * from department");
        }

        public void Delete()
        {
            GetConnection("Delete from department where departmentid = " + this.DepartmentId);
        }
        public void DeleteName()
        {
            GetConnection("Delete from department where dname = '" + this.Name +"'");
        }

        public void Update()
        {
            GetConnection("UPDATE Department Set dname = '" + this.Name + "', " + "addressid = " + this.AddressId + ", departmentid ="+ this.DepartmentId +" where departmentid = " + this.DepartmentId);
        }
        public void Insert()
        {
            GetConnection("INSERT INTO department(addressid, dname) VALUES(" + this.AddressId + ", '" + this.Name + "')");
        }

        private int SelectDepartmentID()
        {
            return Convert.ToInt32(GetConnection("SELECT departmentID FROM deparment WHERE addressID = '" +
            this.AddressId + "' AND dName = '" + this.Name + "'").Rows[0][0].ToString());
        }

        public override string ToString()
        {
            return "DepartmentId: " + this.DepartmentId + " AddressID: " + AddressId + " dName: " + Name; 
        }

    }
}
