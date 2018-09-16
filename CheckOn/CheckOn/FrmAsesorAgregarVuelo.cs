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


    public partial class FrmAsesorAgregarVuelo : Form
    {
        private MySqlDataAdapter insercion = new MySqlDataAdapter();
        private MySqlConnection conexion = new MySqlConnection();
        public FrmAsesorAgregarVuelo()
        {
            InitializeComponent();
        }

        private void lblTipoUsuario_Click(object sender, EventArgs e)
        {

        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = "server=localhost; database=check - on; Uid=root; Pwd = ; SslMode=none;";
            MySqlCommand comando = new MySqlCommand();
            try
            {
                MessageBox.Show("conexion iniciada");
                comando.CommandType = CommandType.Text;
                comando.CommandText = "insert into flight(IdFlight, HourExit, HourArrive, salida, Destination, TypeFlight) values(" + txtIdVuelo.Text + ", " + txtHoraSalida.Text + ", '" + txtHoraLlegada.Text + "', '" + txtLugarSalida.Text + "' , '" + txtLugarDestino.Text + "' , '" + cmbTipoVuelo.Text + "')";
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
        
    }
}
