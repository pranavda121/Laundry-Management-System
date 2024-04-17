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
    public partial class Form8feedback : Form
    {
        public int orderid;
        OracleConnection conn;
        public Form8feedback(int order)
        {
            orderid = order;
            InitializeComponent();
            textBox3.Text = orderid.ToString();
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form5orderplacestud newForm = new Form5orderplacestud(0);
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int feedbackId = Convert.ToInt32(textBox2.Text);
            int orderId = Convert.ToInt32(textBox3.Text);
            int rating = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            string comments = textBox1.Text;

            try
            {
                ConnectDB();

                using (OracleCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO FEEDBACK (feedback_id, order_id, rating, comments) 
                                VALUES (:feedbackId, :orderId, :rating, :comments)";
                    cmd.Parameters.Add(":feedbackId", OracleDbType.Int32).Value = feedbackId;
                    cmd.Parameters.Add(":orderId", OracleDbType.Int32).Value = orderId;
                    cmd.Parameters.Add(":rating", OracleDbType.Int32).Value = rating;
                    cmd.Parameters.Add(":comments", OracleDbType.Clob).Value = comments;

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Feedback inserted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert feedback.");
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
