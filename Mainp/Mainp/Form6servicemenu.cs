using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mainp
{
    public partial class Form6servicemenu : Form
    {
        OracleConnection Conn;
        OracleDataAdapter adpt;
        DataTable dt;
        public void ConnectDB()
        {


            Conn = new OracleConnection("DATA SOURCE=LAPTOP-U5POKEKF:1522/XE;USER ID=SYSTEM;PASSWORD=password");
            try
            {
                Conn.Open();
            }
            catch (Exception e) { }
        }
        public Form6servicemenu()
        {
            InitializeComponent();
        }
        public void showdata()
        {
            ConnectDB();
            adpt = new OracleDataAdapter("Select * from laundry_service", Conn);
            dt = new DataTable();

            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            Conn.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5orderplacestud newForm = new Form5orderplacestud(0);
            newForm.Show();
        }



        private void Form6servicemenu_Load(object sender, EventArgs e)
        {

        }




        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showdata();

        }

    }
}