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
    public partial class biletForm : Form
    {
        public string MyConnection2 = "server=localhost;database=tour;uid=vokdon;password=parol123;";
        public string idTouriat;
        public string idGroup;

        public biletForm()
        {

            InitializeComponent();
            try
            {
                getIdTourist();
                string Query = "SELECT login, full_name, passport_data FROM tourists WHERE id = '" + idTouriat + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                    label2.Text = "Ваша группа - " + idGroup;
                    label4.Text = "ФИО - " + MyReader2[1].ToString();
                    label5.Text = "Паспортные данные - " + MyReader2[2].ToString();
                }
                

                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getIdTourist()
        {
            try
            {
                string Query = "SELECT tourist_id, group_id FROM group_membership;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                    idTouriat = MyReader2[0].ToString();
                    idGroup = MyReader2[1].ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void biletForm_Load(object sender, EventArgs e)
        {

        }
    }
}
