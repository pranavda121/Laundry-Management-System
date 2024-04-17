using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mainp
{
    public partial class Form5orderplacestud : Form
    {
        public int total;
        public int orderid;
        public int payment;
        OracleConnection conn;
        private int loggedInStudentId;


        public void connectdb()
        {
            conn = new OracleConnection("DATA SOURCE=LAPTOP-U5POKEKF:1522/XE;USER ID=SYSTEM;PASSWORD=password");
            try
            {
                conn.Open();
            }
            catch (Exception e) { }
        }
        private int GetProviderIdFromStudentId(int studentId)
        {
            int providerId = -1; 

            connectdb();

            try
            {
                using (OracleCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT hostel_num FROM STUDENT WHERE student_id = :studentId";
                    cmd.Parameters.Add("studentId", OracleDbType.Int32).Value = studentId;

                    object result = cmd.ExecuteScalar();

                    if (result != null) 
                    {
                        int hostelNum = Convert.ToInt32(result);

                        cmd.CommandText = "SELECT provider_id FROM LAUNDRY_PROVIDER WHERE hostel_num = :hostelNum";
                        cmd.Parameters.Clear(); 
                        cmd.Parameters.Add("hostelNum", OracleDbType.Int32).Value = hostelNum;

                        object providerIdResult = cmd.ExecuteScalar();

                        if (providerIdResult != null) 
                        {
                            providerId = Convert.ToInt32(providerIdResult);
                        }
                        else
                        {
                            MessageBox.Show("Provider ID not found for the given student ID.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hostel number not found for the given student ID.");
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

            return providerId;
        }
        public Form5orderplacestud(int student_Id)
        {
            InitializeComponent();
            loggedInStudentId = student_Id;
        }
        String abc;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connectdb();

            try
            {
                using (OracleCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT SERVICE_ID FROM LAUNDRY_SERVICE WHERE SERVICE_NAME = :serviceName";
                    cmd.Parameters.Add("serviceName", OracleDbType.Varchar2).Value = comboBox1.SelectedItem.ToString();

                    object serviceIdResult = cmd.ExecuteScalar();

                    if (serviceIdResult != null) 
                    {
                        int serviceId = Convert.ToInt32(serviceIdResult);

                        cmd.CommandText = "SELECT ITEM_ID FROM LAUNDRY_ITEM WHERE ITEM_NAME = :itemName";
                        cmd.Parameters.Clear(); 
                        cmd.Parameters.Add("itemName", OracleDbType.Varchar2).Value = comboBox3.SelectedItem.ToString();

                        object itemIdResult = cmd.ExecuteScalar();

                        if (itemIdResult != null) 
                        {
                            int itemId = Convert.ToInt32(itemIdResult);

                            int quantity = Convert.ToInt32(textBox2.Text); 
                            cmd.Parameters.Clear();
                            cmd.CommandText = "INSERT INTO LAUNDRY_ORDER (order_id, order_date, status, student_id, provider_id, service_id, item_id, quantity) " +
                                              "VALUES (:orderId, SYSDATE, :status, :studentId, :providerId, :serviceId, :itemId, :quantity)";
                            cmd.Parameters.Add("orderId", OracleDbType.Int32).Value = int.Parse(textBox1.Text); 
                            cmd.Parameters.Add("status", OracleDbType.Varchar2).Value = "Pending"; 
                            cmd.Parameters.Add("studentId", OracleDbType.Int32).Value = loggedInStudentId;
                            cmd.Parameters.Add("providerId", OracleDbType.Int32).Value = GetProviderIdFromStudentId(loggedInStudentId); 
                            cmd.Parameters.Add("serviceId", OracleDbType.Int32).Value = serviceId;
                            cmd.Parameters.Add("itemId", OracleDbType.Int32).Value = itemId;
                            cmd.Parameters.Add("quantity", OracleDbType.Int32).Value = quantity;

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Laundry order submitted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Item ID not found for the selected item name.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Service ID not found for the selected service name.");
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
            decimal serviceCost = GetServiceCost(comboBox1.SelectedItem.ToString());

            if (serviceCost != -1) 
            {
                int quantity = Convert.ToInt32(textBox2.Text); 
                decimal totalCost = serviceCost * quantity;

                MessageBox.Show("Total Cost:" + totalCost.ToString());

               total = (int)totalCost;
            }
            else
            {
                MessageBox.Show("Service cost not found for the selected service name.");
            }
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6servicemenu newForm = new Form6servicemenu();
            newForm.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7paymentgate newForm = new Form7paymentgate(total,orderid,payment);
            newForm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            showprev form = new showprev(loggedInStudentId);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9studetailchange newForm = new Form9studetailchange();
            newForm.Show();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            payment = int.Parse(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            orderid = int.Parse(textBox1.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            abc = comboBox3.SelectedItem as String;

        }
        private decimal GetServiceCost(string serviceName)
        {
            decimal serviceCost = -1; 

            connectdb();

            try
            {
                using (OracleCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT SERVICE_COST FROM LAUNDRY_SERVICE WHERE SERVICE_NAME = :serviceName";
                    cmd.Parameters.Add("serviceName", OracleDbType.Varchar2).Value = serviceName;

                    object serviceCostResult = cmd.ExecuteScalar();

                    if (serviceCostResult != null && serviceCostResult != DBNull.Value) 
                    {
                        serviceCost = Convert.ToDecimal(serviceCostResult);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving service cost: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return serviceCost;
        }
    }
}
