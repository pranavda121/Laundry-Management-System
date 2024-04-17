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
    public partial class Form9studetailchange : Form
    {
        OracleConnection conn;
        public Form9studetailchange()
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
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ConnectDB();
            OracleCommand command1 = conn.CreateCommand();
            command1.CommandText = "@F:/Temp/prev - Copy/changepass.sql/";
            command1.CommandType = CommandType.Text;
            command1.Dispose();
            conn.Close();


            int studentId = Convert.ToInt32(textBox1.Text);
            string newPassword = textBox4.Text;

            try
            {
                conn.Open();

                using (OracleCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "ChangeStudentPassword";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_student_id", OracleDbType.Int32).Value = studentId;
                    cmd.Parameters.Add("p_new_password", OracleDbType.Varchar2).Value = newPassword;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Password updated successfully.");
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
     

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}