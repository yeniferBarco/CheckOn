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
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFechaSalida_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearVuelo_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = "server=localhost; database=check - on; Uid=root; Pwd = ; SslMode=none;";
            conexion.Open();
            MySqlCommand comando = new MySqlCommand();
            try
            {
                
                comando.CommandType = CommandType.Text;
                string horaLlegada = txtHoraLlegadaH.Text + txtHoraLlegadaM.Text + txtHoraLlegadaS.Text;
                string horaSalida = txtHoraSalidaH.Text + txtHoraSalidaM.Text + txtHoraSlidaS.Text;
                string FechaLlegada = txtFechaLY.Text + txtFechaLM.Text+ txtFechaLD.Text;
                string FechaSalida = txtFechaSY.Text + txtFechaSM.Text + txtFechaSD.Text;
                string salida = txtLugarSalida.Text;


                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(this, "seguro que quiere guardar?", salida, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);

                if (result == DialogResult.Yes)
                {

                    comando.CommandText = "insert into flight(IdFlight, HourExit, HourArrive, DataSalida, DataArrive, salida, Destination, TypeFlight) values(" + txtIdVuelo.Text + ", " + horaSalida.ToString() + ", '" + horaLlegada + "', '" + FechaSalida + "', '" + FechaLlegada + "', '" + txtLugarSalida.Text + "' , '" + txtLugarDestino.Text + "' , '" + cmbTipoVuelo.Text + "')";


                    comando.Connection = conexion;
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Se guardara la siguiente informacion" + horaLlegada.ToString());


                    this.Close();

                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ups!! houston tenemos un problema!! por favor revisa la informacion del vuelo y vuelvelo a intentar");
            }
            conexion.Close();


        }

        private void btnBuscarVuelo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAsesorPrincipal frmAsesorPrincipal = new FrmAsesorPrincipal();
            frmAsesorPrincipal.ShowDialog();
        }
    }
}
