using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CheckOn
{
    public partial class FrmPruebas : Form
    {
        private MySqlConnection conexion = new MySqlConnection();

        public FrmPruebas()
        {
            InitializeComponent();
        }

        private void FrmPruebas_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = "server =" + txtHost.Text + "; database = " + txtBD.Text + "; uid = " + txtUser.Text + "; pwd = " + txtPass.Text + "; SslMode=none"+";";
            try
            {
                conexion.Open();
                MessageBox.Show("Conexión establecida");

                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectarnos = new MySqlConnection();
                codigo.Connection = conexion;

                codigo.CommandText = (String.Format("select *from roles"));

                MessageBox.Show(codigo.ToString());
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
