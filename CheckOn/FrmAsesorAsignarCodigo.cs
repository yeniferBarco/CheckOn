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
    

    public partial class FrmAsesorAsignarCodigo : Form
    {
        private MySqlDataAdapter insercion = new MySqlDataAdapter();
        private MySqlConnection conexion = new MySqlConnection();

        public FrmAsesorAsignarCodigo()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = "server=localhost; database=check - on; Uid=root; Pwd = ; SslMode=none;";
            MySqlCommand comando = new MySqlCommand();
            try
            {

                comando.CommandType = CommandType.Text;
                comando.CommandText = "insert into passenger(NamePassenger, LastNamePassenger, CC_Passenger, IdDivaice) values('" + txtNombres.Text + "', '" + txtApellidos.Text + "', '" + txtCedula.Text + "', '" + txtCodMaleta.Text +  "')";
                comando.Connection = conexion;
                

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAsesorInfoVuelo frmAsesorInfoVuelo = new FrmAsesorInfoVuelo();
            frmAsesorInfoVuelo.ShowDialog();
        }
    }
}
