﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using DataBaseNet;

namespace DataBasesTest
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

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

        DBOracle oracleDB;
        private void btTestConnection_Click(object sender, EventArgs e)
        {
            oracleDB = new DBOracle(tbUser.Text, tbPassword.Text, tbWorkspace.Text, tbServer.Text, int.Parse(tbPort.Text));

            oracleDB.ConnectionMessage += oracleDB_ConnectionMessage;
        }

        void oracleDB_ConnectionMessage(string message)
        {
            tbMessages.AppendText(message + Environment.NewLine);
        }

        private void btOracleRun_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbSQLOracle.Text))
            {
                try
                {
                    gvOracle.DataSource = oracleDB.RunQueryDataSet(tbSQLOracle.Text).Tables[0].DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbMessages.Clear();
        }

        private void btConnection_Click(object sender, EventArgs e)
        {
            tbMessages.AppendText(oracleDB.ConnectionString() + Environment.NewLine);
        }

        DBSQLServer sqlServer;
        private void btSQLConnect_Click(object sender, EventArgs e)
        {
            sqlServer = new DBSQLServer(tbSQLUser.Text, tbSQLPassword.Text, tbSQLCatalog.Text, tbSQLServer.Text, tbSQLInstance.Text, cxIsExpress.Checked);

            sqlServer.ConnectionMessage += sqlServer_ConnectionMessage;
        }

        void sqlServer_ConnectionMessage(string message)
        {
            tbSQLMessages.AppendText(message + Environment.NewLine);
        }

        private void btSQLRun_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbSQLCommand.Text))
            {
                try
                {
                    gvSQLData.DataSource = sqlServer.RunQueryDataSet(tbSQLCommand.Text).Tables[0].DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btSQLConnection_Click(object sender, EventArgs e)
        {
            tbSQLMessages.AppendText(sqlServer.ConnectionString() + Environment.NewLine);
        }

        DBMySQL mySQL;
        private void btMySQLConnect_Click(object sender, EventArgs e)
        {
            mySQL = new DBMySQL(tbMySQLUser.Text, tbMySQLPassword.Text, tbMySQLDataBase.Text, tbMySQLServer.Text, int.Parse(tbMySQLPort.Text));

            mySQL.ConnectionMessage += mySQL_ConnectionMessage;
        }

        void mySQL_ConnectionMessage(string message)
        {
            tbMySQLMessages.AppendText(message + Environment.NewLine);
        }

        private void btMySQLRun_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbMySQLCommand.Text))
            {
                try
                {
                    gvMySQLData.DataSource = mySQL.RunQueryDataSet(tbMySQLCommand.Text).Tables[0].DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btMySQLConnection_Click(object sender, EventArgs e)
        {
            tbMySQLMessages.AppendText(mySQL.ConnectionString() + Environment.NewLine);
        }

        DBPostgreSQL postgreSQL;
        private void btPostConnect_Click(object sender, EventArgs e)
        {
            postgreSQL = new DBPostgreSQL(tbPostUser.Text, tbPostPassword.Text, tbPostDataBase.Text, tbPostServer.Text, int.Parse(tbPostPort.Text));

            postgreSQL.ConnectionMessage += postgreSQL_ConnectionMessage;
        }

        void postgreSQL_ConnectionMessage(string message)
        {
            tbPostMessages.AppendText(message + Environment.NewLine);
        }

        private void btPostRun_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbPostCommand.Text))
            {
                try
                {
                    gvPostData.DataSource = postgreSQL.RunQueryDataSet(tbPostCommand.Text).Tables[0].DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btPostConnection_Click(object sender, EventArgs e)
        {
            tbPostMessages.AppendText(postgreSQL.ConnectionString() + Environment.NewLine);
        }
    }
}
