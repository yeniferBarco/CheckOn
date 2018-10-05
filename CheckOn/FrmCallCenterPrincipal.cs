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
    public partial class FrmCallCenterPrincipal : Form
    {
        private MySqlDataAdapter insercion = new MySqlDataAdapter();
        private MySqlConnection conexion = new MySqlConnection();

        public FrmCallCenterPrincipal()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btmBuscar_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = "server=localhost; database=check - on; Uid=root; Pwd =; SslMode=none;";
            //MySqlCommand comando = new MySqlCommand("SELECT * FROM flight WHERE IdFlight = @IdFlight", conexion);

            MySqlCommand comando = new MySqlCommand("select * from flight where IdFlight = @IdFlight ", conexion);
            //MySqlCommand Num = new MySqlCommand("select COUNT(*) from InfoVuelo", conexion);
            comando.Parameters.AddWithValue("@IdFlight", txtIdVuelo.Text);
            conexion.Open();

            MySqlDataReader Registro = comando.ExecuteReader();
            //MySqlDataReader Numero = Num.ExecuteReader();


            if (Registro.Read())
            {

                lbInfoVuelo.Items.Add("Hora de Salida \t " + Registro["HourExit"].ToString() + " \t" + "Hora de llegada \t" + Registro["HourArrive"].ToString());
                lbInfoVuelo.Items.Add("Fecha de salida \t" + Registro["DataSalida"].ToString().Split(' ')[0] + " \t" + "Fecha de llegada \t" + Registro["DataArrive"].ToString().Split(' ')[0]);
                lbInfoVuelo.Items.Add("Tipo de vuelo \t" + Registro["TypeFlight"].ToString());
                lbInfoVuelo.Items.Add("Origen \t" + Registro["salida"].ToString());
                lbInfoVuelo.Items.Add("Destino \t" + Registro["Destination"].ToString());


            }

     
        }

        private void btnAggPasajero_Click(object sender, EventArgs e)
        {
            lbInfoVuelo.Items.Clear();
            txtIdVuelo.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCallCenterMaleta frmCallCenterMaleta = new FrmCallCenterMaleta();
            frmCallCenterMaleta.ShowDialog();
        }
    }
}
