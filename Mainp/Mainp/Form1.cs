using Oracle.ManagedDataAccess.Client;


namespace Mainp
{


    public partial class Form1 : Form
    {
        OracleConnection Conn;
        public Form1()
        {
            InitializeComponent();
        }
      public void  ConnectDB()
        {
            Conn = new OracleConnection("DATA SOURCE=LAPTOP-U5POKEKF:1522/XE;USER ID=SYSTEM;PASSWORD=password");
            try
            {
                Conn.Open();
            }
            catch (Exception e) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2studentlogin newForm = new Form2studentlogin();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4serviceprologin newForm = new Form4serviceprologin();
            newForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
