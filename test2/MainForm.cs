using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static test2.Form1;

namespace test2
{
    public partial class MainForm : Form
    {
        public string MyConnection2 = "server=localhost;database=tour;uid=vokdon;password=parol123;";
        public string dataLeavePublic;
        public int idGroup;
        public string totalCost;
        public string selectedNameGroup;
        public string idTouriat;

        public MainForm()
        {
            InitializeComponent();
            try
            {
                string Query = "SELECT name FROM tours;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                    listBox1.Items.Add(MyReader2[0].ToString());
                }
                listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void getGroup(int idGroup)
        {
            try
            {
                string Query = "SELECT * FROM tourist_groups WHERE tour_id='" + idGroup + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                listBox2.Items.Clear();

                while (MyReader2.Read())
                {
                    listBox2.Items.Add(MyReader2[1].ToString());
                }
                listBox2.SelectedIndexChanged += listBox1_SelectedIndexChanged;
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = listBox1.SelectedItem.ToString();

            try
            {
                string Query = "SELECT * FROM tours WHERE name='" + selectedName + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                    country.Text = "Страна - " + MyReader2[2].ToString();
                    city.Text = "Город - " + MyReader2[3].ToString();
                    transport.Text = "Транспорт - " + MyReader2[4].ToString();
                    mealType.Text = "Еда - " + MyReader2[5].ToString();
                    price.Text = "Цена - " + MyReader2[6].ToString();
                    house.Text = "Жилье - " + MyReader2[7].ToString();
                    getGroup((int)MyReader2[0]);
                    totalCost = MyReader2[0].ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void country_Click(object sender, EventArgs e)
        {

        }

        private void city_Click(object sender, EventArgs e)
        {

        }

        private void transport_Click(object sender, EventArgs e)
        {

        }

        private void mealType_Click(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void house_Click(object sender, EventArgs e)
        {

        }

        private void dateLeave_Click(object sender, EventArgs e)
        {

        }

        private void dateReturn_Click(object sender, EventArgs e)
        {

        }

        private void countTurists_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedNameGroup = listBox2.SelectedItem.ToString();
            try
            {
                string Query = "SELECT * FROM tourist_groups WHERE name='" + selectedNameGroup + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                    dataLeavePublic = MyReader2[2].ToString();
                    dateLeave.Text = "Дата отбытия - " + MyReader2[2].ToString();
                    dateReturn.Text = "Дата прибытия - " + MyReader2[3].ToString();
                    countTurists.Text = "Количество человек - " + MyReader2[5].ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getGroupById(string selectedName)
        {
            try
            {
                string Query = "SELECT * FROM tourist_groups WHERE name='" + selectedName + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                    idGroup = (int)MyReader2[0];
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getIdTourist(string boxStrigLogin)
        {
            try
            {
                string Query = "SELECT id FROM tourists WHERE login = '" + boxStrigLogin + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                    idTouriat = MyReader2[0].ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Click(object sender, EventArgs e)
        { 
            try
            {
                MessageBox.Show(selectedNameGroup);
                getGroupById(selectedNameGroup);
                string Query = "insert into sales_ledger(date, group_id, hotel_id, total_cost) values('" + dataLeavePublic.ToString() + "','" + idGroup.ToString() + "','" + 0 + "','" + totalCost.ToString() + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();

                string log = this.Text;
                
                getIdTourist(log); 

                string Query1 = "insert into group_membership(tourist_id, group_id) values('" + idTouriat + "','" + idGroup + "');";
                MySqlConnection MyConn1 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand1 = new MySqlCommand(Query1, MyConn1);
                MySqlDataReader MyReader1;
                MyConn1.Open();
                MyReader1 = MyCommand1.ExecuteReader();
                while (MyReader1.Read())
                {
                }
                MyConn1.Close();

                this.Hide();
                PayForm payForm = new PayForm();
                payForm.Text = this.Text;
                payForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
