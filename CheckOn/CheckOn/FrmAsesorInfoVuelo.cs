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
    public partial class FrmAsesorInfoVuelo : Form
    {

        private MySqlDataAdapter insercion = new MySqlDataAdapter();
        private MySqlConnection conexion = new MySqlConnection();
        

        public FrmAsesorInfoVuelo()
        {
            InitializeComponent();
            btnAggPasajero.Hide();
        }
        
        private void btmBuscar_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = "server=localhost; database=check - on; Uid=root; Pwd =; SslMode=none;";
            MySqlCommand comando = new MySqlCommand("SELECT * FROM flight WHERE IdFlight = @IdFlight", conexion);

            comando.Parameters.AddWithValue("@IdFlight", txtIdVuelo.Text);
            conexion.Open();
            
            MySqlDataReader Registro = comando.ExecuteReader();


            
            
            if (Registro.Read())
            {
                
                
                txtHoraSalida.Text = Registro["HourExit"].ToString();
                txtHoraLlegada.Text = Registro["HourArrive"].ToString();
                txtDiaSalida.Text = Registro["DataSalida"].ToString();
                txtDiaLlegada.Text = Registro["DataArrive"].ToString();
                txtTipoVuelo.Text = Registro["TypeFlight"].ToString();
                txtDestino.Text = Registro["Destination"].ToString();
                txtOrigen.Text = Registro["salida"].ToString();

            }

            btnAggPasajero.Show();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaSalida_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAggPasajero_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAsesorAsignarCodigo frmAsigCod = new FrmAsesorAsignarCodigo();
            frmAsigCod.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAsesorPrincipal frmAsesorPrincipal = new FrmAsesorPrincipal();
            frmAsesorPrincipal.ShowDialog();
            
        }
    }
}
