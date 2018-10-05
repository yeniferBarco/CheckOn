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
    public partial class FrmLogin : Form
    {

        private MySqlDataAdapter insercion = new MySqlDataAdapter();
        private MySqlConnection conexion = new MySqlConnection();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnIngresar_Click_1(object sender, EventArgs e)
        {

            conexion.ConnectionString = "server=localhost; database=check - on; Uid=root; Pwd = ; SslMode=none;";
            conexion.Open();

            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexion;

            comando.CommandText = "select *from user where IdUser = '" + txtUsuario.Text + "' and Password = '" + txtContrasena.Text + "'";

            MySqlDataReader leer = comando.ExecuteReader();

            if (leer.Read())
            {
                MessageBox.Show("Bienvenido");
                this.Hide();
                FrmAsesorPrincipal frmAsesorPrincipal = new FrmAsesorPrincipal();
                frmAsesorPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
            conexion.Close();
           
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegistro = new FrmRegistro();
            this.Hide();
            frmRegistro.ShowDialog();
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
