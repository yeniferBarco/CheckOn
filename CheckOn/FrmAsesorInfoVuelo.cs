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
            

            MySqlCommand comando = new MySqlCommand("select * from flight where IdFlight = @IdFlight ", conexion);
            
            comando.Parameters.AddWithValue("@IdFlight", txtIdVuelo.Text);
            conexion.Open();
            
            MySqlDataReader Registro = comando.ExecuteReader();
           
            
            if (Registro.Read())
            {

                lbInfoVuelo.Items.Add("Hora de Salida \t " + Registro["HourExit"].ToString() + " \t" + "Hora de llegada \t" + Registro["HourArrive"].ToString());
                lbInfoVuelo.Items.Add("Fecha de salida \t" + Registro["DataSalida"].ToString().Split(' ')[0]+ " \t" + "Fecha de llegada \t" + Registro["DataArrive"].ToString().Split(' ')[0]);
                lbInfoVuelo.Items.Add("Tipo de vuelo \t" + Registro["TypeFlight"].ToString());
                lbInfoVuelo.Items.Add("Origen \t" + Registro["salida"].ToString());
                lbInfoVuelo.Items.Add("Destino \t" + Registro["Destination"].ToString());
                

            }
            conexion.Close();
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
