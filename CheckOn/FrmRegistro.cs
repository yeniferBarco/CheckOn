using System;
using MySql.Data.MySqlClient;
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
    public partial class FrmRegistro : Form
    {
        private MySqlDataAdapter insercion = new MySqlDataAdapter();
        private MySqlConnection conexion = new MySqlConnection();

        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grbRegistro_Enter(object sender, EventArgs e)
        {

        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = "server-localhost; database-check - on; uid-root; pwd = ; SslMode=none;";
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {

            conexion.ConnectionString = "server=localhost; database=check - on; Uid=root; Pwd = ; SslMode=none;";
            MySqlCommand comando = new MySqlCommand();
            try
            {   

                comando.CommandType = CommandType.Text;
                comando.CommandText = "insert into user(IdUser, CC_User, Password, NameUser, LastNameUser, TypeUser) values(" + txtId_User.Text + ", " + txtCedula.Text+", '" + txtContrasena.Text + "', '" + txtNombre.Text +"' , '" + txtApellido.Text + "' ,'" + cmbTipoUsuario.Text + "')";
                comando.Connection = conexion;

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }
    }
}
