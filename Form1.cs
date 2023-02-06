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
using Npgsql;

namespace DatabaseFinal
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*try
            {
                //Defalut 
                MessageBox.Show("connected");
                
                //connecting to gridview
                dataGridView1.DataSource =  Employee.Select(2);
                dataGridView1.DataSource = Employee.SelectID();
                

                
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

        }
    }
}
