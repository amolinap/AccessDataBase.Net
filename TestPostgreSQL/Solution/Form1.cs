using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPostgreSQL
{
    public partial class Form1 : Form
    {
        DataBaseNet.DBPostgreSQL postgresSQL = new DataBaseNet.DBPostgreSQL("Admin", "admin1234", "TestPostgreSQL", "127.0.0.1", 5432);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofImage = new OpenFileDialog();

            if (ofImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pxImage.Image = Image.FromFile(ofImage.FileName);
            }
        }

        private byte[] Image_Bytes(Image image)
        {
            /*MemoryStream bin = new MemoryStream();

            image.Save(bin, System.Drawing.Imaging.ImageFormat.Jpeg);

            return bin.GetBuffer();*/

            /*using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);

                return ms.ToArray();
            }*/

            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(image, typeof(byte[]));
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select max(id_emp) from empleados";

                int id_emp = int.Parse(postgresSQL.RunQueryParameter(sql)) + 1;

                var img = Image_Bytes(pxImage.Image);
                //sql = "insert into empleados(id_emp, nombre, foto) values(" + id_emp + ", '" + tbName.Text + "', " + img + ");";
                //sql = "insert into empleados(id_emp, nombre) values(" + id_emp + ", '" + tbName.Text + "');";
                sql = "insert into empleados(id_emp, nombre, foto) values(@id_emp, @nombre, @foto);";

                //postgresSQL.RunQueryCommand(sql);
                NpgsqlConnection connection = new NpgsqlConnection("Server =127.0.0.1; Port =5432; User id =Admin; Password =admin1234; Database =TestPostgreSQL;");
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);

                command.Parameters.AddWithValue("@id_emp", NpgsqlTypes.NpgsqlDbType.Integer, id_emp);
                command.Parameters.AddWithValue("@nombre", NpgsqlTypes.NpgsqlDbType.Text, tbName.Text);
                command.Parameters.AddWithValue("@foto", NpgsqlTypes.NpgsqlDbType.Bytea, img);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select id_emp, nombre, foto from empleados;";

            dataGridView1.DataSource = postgresSQL.RunQueryDataSet(sql).Tables[0].DefaultView;
            
        }
    }
}
