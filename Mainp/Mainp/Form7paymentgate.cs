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
    public partial class Form7paymentgate : Form
    {
        OracleConnection conn;
        private int student_Id;
        private int amount;
        private int orderid;
        private int paymentid;


        public Form7paymentgate(int total_amount, int order_id,int pay)
        {
            paymentid = pay;
            amount = total_amount;
            orderid = order_id;
            InitializeComponent();
            textBox1.Text = orderid.ToString();
            textBox3.Text = amount.ToString();
            textBox2.Text = pay.ToString();
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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8feedback newForm = new Form8feedback(orderid);
            newForm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5orderplacestud newForm = new Form5orderplacestud(student_Id);
            newForm.Show();
            this.Hide();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(textBox1.Text);
            int paymentId = Convert.ToInt32(textBox2.Text);
            decimal amount = Convert.ToDecimal(textBox3.Text);
            string paymentStatus = "paid";

            try
            {
                ConnectDB();

                using (OracleCommand cmd = conn.CreateCommand())
                {
                    // Insert payment record into PAYMENT table
                    cmd.CommandText = "INSERT INTO PAYMENT (PAYMENT_ID, ORDER_ID, AMOUNT, PAYMENT_DATE, PAYMENT_STATUS) " +
                                      "VALUES (:paymentId, :orderId, :amount, SYSDATE, :paymentStatus)";
                    cmd.Parameters.Add("paymentId", OracleDbType.Int32).Value = paymentId;
                    cmd.Parameters.Add("orderId", OracleDbType.Int32).Value = orderId;
                    cmd.Parameters.Add("amount", OracleDbType.Decimal).Value = amount;
                    cmd.Parameters.Add("paymentStatus", OracleDbType.Varchar2).Value = paymentStatus;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Payment added successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding payment: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
    

