using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Mainp
{
    public partial class Form3reg : Form
    {
        OracleConnection Conn;
        public Form3reg()
        {
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB();




            OracleCommand cmd = Conn.CreateCommand();

            cmd.CommandText = "INSERT INTO Student VALUES (" +
                              textBox2.Text + ", '" +  // Assuming textBox1.Text is for the second column
                              textBox1.Text + "', '" + // Assuming textBox2.Text is for the first column
                              textBox3.Text + "', " + // Assuming textBox3.Text is for the third column
                              textBox4.Text + ", '" + // Assuming textBox4.Text is for the fourth column
                              textBox5.Text + "')";
            cmd.CommandType = CommandType.Text;
            MessageBox.Show("Data inserted successfully");

            cmd.ExecuteNonQuery();
            cmd.Dispose();  
            Conn.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}