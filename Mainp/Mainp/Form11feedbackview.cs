using Mainp;
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
    public partial class Form11feedbackview : Form
    {
        int log;
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
        public void showdata()
        {
            ConnectDB();
            adpt = new OracleDataAdapter("SELECT feedback_id, order_id, rating, comments FROM FEEDBACK WHERE order_id IN (SELECT order_id FROM LAUNDRY_ORDER WHERE provider_id =" + log+ ")", Conn);
            dt = new DataTable();

            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            Conn.Close();

        }
        public Form11feedbackview(int id)
        {
            log = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10servicecheck form = new Form10servicecheck(log);
            form.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showdata();

        }
    }
}






