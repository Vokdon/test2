using Microsoft.VisualBasic.Logging;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class RegForm : Form
    {
        public string MyConnection2 = "server=localhost;database=tour;uid=vokdon;password=parol123;";
        public string radioString;
        public string lastLogin;
        public string lastPassword;

        public RegForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void men_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_CheckedChanged(sender, e);
        }

        private void woman_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_CheckedChanged(sender, e);
        }

        private void get_LastLoginAndPassword()
        {
            try
            {
                string Query = "SELECT login, password FROM tourists;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                    lastLogin = MyReader2[0].ToString();
                    lastPassword = MyReader2[1].ToString();
                }

                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameFull = textBox1.Text.ToString();
            string pasportData = textBox2.Text.ToString();
            string ageData = textBox4.Text.ToString();
            string childrenData = textBox3.Text.ToString();

            try
            {
                get_LastLoginAndPassword();
                string Query = "update tourists set full_name='" + nameFull + "', passport_data='" + pasportData + "', gender='" + radioString + "', age='" + ageData + "', children='" + childrenData + "' WHERE login='" + lastLogin +"';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                this.Close();
                MainForm mainForm = new MainForm(); 
                mainForm.Show();

                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
               radioString = radioButton.Text;   
            }
        }
    }
}
