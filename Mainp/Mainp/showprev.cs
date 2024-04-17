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
    public partial class showprev : Form
    {
        OracleConnection Conn;
        OracleDataAdapter adpt;
        DataTable dt;
        int studid;

        public showprev(int loggedinStudentid)
        {
            studid = loggedinStudentid;
            InitializeComponent();
        }
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
            try
            {
                ConnectDB();

                using (OracleCommand cmd = Conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT 
                                            o.ORDER_ID,
                                            o.STATUS,
                                            ls.SERVICE_NAME,
                                            i.ITEM_NAME
                                        FROM 
                                            Laundry_ORDER o
                                        JOIN 
                                            LAUNDRY_ORDER lo ON o.ORDER_ID = lo.ORDER_ID
                                        JOIN 
                                            LAUNDRY_SERVICE ls ON lo.SERVICE_ID = ls.SERVICE_ID
                                        JOIN 
                                            LAUNDRY_ITEM i ON lo.ITEM_ID = i.ITEM_ID
                                        WHERE
                                            o.STUDENT_ID = :studentId";
                    cmd.Parameters.Add(":studentId", OracleDbType.Int32).Value = studid;

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void showprev_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showdata();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5orderplacestud form = new Form5orderplacestud(studid);
            form.Show();
            this.Hide();

        }
    }
}
