using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using DataBase;

namespace DataBasesTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBMySQL mySQL = new DBMySQL("molina", "password", "testdb", "192.168.0.18");

            dataGridView1.DataSource = mySQL.RunQueryDataSet("select * from personas;").Tables[0].DefaultView;

            /*MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "192.168.0.18";
            conn_string.Port = 3306;
            conn_string.UserID = "molina";
            conn_string.Password = "password";
            conn_string.Database = "testdb";



            MySqlConnection MyCon = new MySqlConnection(conn_string.ToString());

            Console.WriteLine(conn_string.ToString());


            try
            {
                MyCon.Open();
                MessageBox.Show("Open");
                MyCon.Close();
                MessageBox.Show("Close");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
    }
}
