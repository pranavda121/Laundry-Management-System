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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mainp
{
    public partial class Form2studentlogin : Form
    {
        OracleConnection conn;
        public int studentid;
        public Form2studentlogin()
        {
            InitializeComponent();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3reg newForm = new Form3reg();
            newForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectDB();

            try
            {
                using (OracleCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM Student WHERE student_id = :id AND password = :password";
                    cmd.Parameters.Add("id", OracleDbType.Int32).Value = int.Parse(textBox1.Text); // Assuming idTextBox is for student ID
                    cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = textBox2.Text; // Assuming passwordTextBox is for password

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        studentid =int.Parse(textBox1.Text);
                        // Password is correct, redirect to another form
                        Form5orderplacestud newForm = new Form5orderplacestud(studentid);
                        newForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        // Password is incorrect
                        MessageBox.Show("Incorrect password");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
