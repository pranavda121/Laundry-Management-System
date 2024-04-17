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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mainp
{
    public partial class Form10servicecheck : Form
    {
        public int loggedInProviderId;
        public int orderid;
        OracleConnection conn;
        public Form10servicecheck(int providerId)
        {
            InitializeComponent();
            loggedInProviderId = providerId;
        }
        public void ConnectDB()
        {
            conn = new OracleConnection("DATA SOURCE=LAPTOP-U5POKEKF:1522/XE;USER ID=SYSTEM;PASSWORD=password");
            try
            {
                conn.Open();
            }
            catch (Exception e) { }
        }

        public Form10servicecheck()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {



        }
        private void UpdateOrderStatus()
        {
            int orderId = Convert.ToInt32(textBox1.Text);
            string status = comboBox1.SelectedItem.ToString();

            try
            {
                ConnectDB();

                using (OracleCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"UPDATE LAUNDRY_ORDER 
                                SET STATUS = :status
                                WHERE ORDER_ID = :orderId";

                    cmd.Parameters.Add(":status", OracleDbType.Varchar2).Value = status;

                    cmd.Parameters.Add(":orderId", OracleDbType.Int32).Value = orderId;
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order status updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No order found with the provided Order ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form11feedbackview newForm = new Form11feedbackview(loggedInProviderId);
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pending newForm = new pending(loggedInProviderId);
            newForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Completed newForm = new Completed(loggedInProviderId);
            newForm.Show();
            this.Hide();    
        }
    }
}
