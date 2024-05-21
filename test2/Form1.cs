using MySqlConnector;
using System.Drawing;

namespace test2
{
    public partial class Form1 : Form
    {

        public string MyConnection2 = "server=localhost;database=tour;uid=vokdon;password=parol123;";
        public string Lg;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string boxStrigLogin = login.Text.ToString();
            string boxStrigPassword = password.Text.ToString();
            try
            {
                string Query = "SELECT id, password FROM tourists WHERE login = '" + boxStrigLogin + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();    
               
                while (MyReader2.Read())
                {
                    if (MyReader2[1].ToString() == password.Text.ToString())
                    {
                      this.Hide();
                      MainForm mainForm = new MainForm(); 
                      mainForm.Text = boxStrigLogin;
                      mainForm.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("not good");
                    }
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string boxStrigLogin = login.Text.ToString();
            string boxStrigPassword = password.Text.ToString();
            Lg = login.Text.ToString();
            try
            {
                string Query = "insert into tourists(login, password, full_name, passport_data, gender, age, children) values('" + boxStrigLogin + "','" + boxStrigPassword + "','" + null + "','" + null + "','" + null + "','" + 0 + "','" + 0 + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();  
                while (MyReader2.Read())
                {
                }
                this.Hide();
                RegForm regForm = new RegForm();
                regForm.ShowDialog();

                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class Connect
    {
        MySqlConnection con;

        public static string cs = "server=localhost;database=SPMS1;uid=root;password=root;";

        public MySqlConnection connect()
        {
            try
            {
                con = new MySqlConnection(cs);
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void closeConnection()
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
}
