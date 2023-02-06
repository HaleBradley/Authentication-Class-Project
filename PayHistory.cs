using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DatabaseFinal
{
    //so this represents one payhistory record?
    public class PayHistory
    {
        private static NpgsqlConnection _connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=;User Id=postgres;Password=;");
        private int EmployeeId { set; get; }
        public decimal PayAmount { set; get; }
        public string Date { set; get; }

        //Constructors

        public PayHistory(int employeeid, decimal payAmount, string date)
        {
            this.EmployeeId = employeeid;
            this.PayAmount = payAmount;
            this.Date = date;
           
        }

        public PayHistory(int employeeId)
        {
            DataTable temp = Select(employeeId);

            this.EmployeeId = Convert.ToInt32(temp.Rows[0][0].ToString());
            this.PayAmount = Convert.ToDecimal(temp.Rows[0][1].ToString());
            this.Date = temp.Rows[0][2].ToString();
        }

        private static DataTable GetConnection(string statment)
        {
            DataTable dataTable = new DataTable();
            try
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
            catch(Exception e)
            {
               
                MessageBox.Show(e.Message.ToString());
                return dataTable;
            }
        }

        //TODO What do we do with this
        public void Insert()
        {
            //command
            GetConnection("INSERT INTO pay_history(employeeid, payAmount, payDate) VALUES(" + this.EmployeeId + ", " + this.PayAmount + ", '" + this.Date + "')");
        }

        //What do we do with the returned data?
       
        public static DataTable Select(int empID)
        {
           
            return GetConnection("select * from pay_history where employeeid = " + empID);
            
        }

        public static DataTable SelectAll()
        {
            return GetConnection("select * from pay_history ORDER BY paydate");
        }

        public void Delete()
        {
           
            GetConnection("Delete from pay_history where employeeid = " + this.EmployeeId);
        }


        public void Update()
        {
            GetConnection("UPDATE pay_history Set employeeid = " + this.EmployeeId + " , payamount =" + this.PayAmount + " , paydate ='" +this.Date + "' where employeeid = " + this.EmployeeId + ";");
        }

        public override string ToString()
        {
            return "Employee-ID: " + EmployeeId + " PayAmmount: " + PayAmount + " Date: " + Date;
        }


    }
}
