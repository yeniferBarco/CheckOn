﻿using System;
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
    public partial class FrmCallCenterMaleta : Form
    {
        private MySqlDataAdapter insercion = new MySqlDataAdapter();
        private MySqlConnection conexion = new MySqlConnection();

        public FrmCallCenterMaleta()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCallCenterPrincipal frmCallCenterPrincipal = new FrmCallCenterPrincipal();
            frmCallCenterPrincipal.ShowDialog();
        }

        private void btnBuscarVuelo_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarVuelo_Click_1(object sender, EventArgs e)
        {
            conexion.ConnectionString = "server=localhost; database=check - on; Uid=root; Pwd =; SslMode=none;";
            //MySqlCommand comando = new MySqlCommand("SELECT * FROM flight WHERE IdFlight = @IdFlight", conexion);
            if (cmbOpciones.Text == "Cedula del pasajero")
            {
                MySqlCommand comando = new MySqlCommand("select * from passenger p JOIN divaice d where p.IdDivaice = d.IdDivaice and CC_Passenger = @CC_Passenger ", conexion);
                //MySqlCommand Num = new MySqlCommand("select COUNT(*) from InfoVuelo", conexion);
                comando.Parameters.AddWithValue("@CC_Passenger", txtDocumentoUsuario.Text);
                conexion.Open();

                MySqlDataReader Registro = comando.ExecuteReader();
                //MySqlDataReader Numero = Num.ExecuteReader();


                if (Registro.Read())
                {

                    lbInfoPasajero.Items.Add("Nombres \t " + Registro["NamePassenger"].ToString());
                    lbInfoPasajero.Items.Add("Apellidos \t" + Registro["LastNamePassenger"].ToString());
                    /*lbInfoPasajero.Items.Add("Tipo de vuelo \t" + Registro["TypeFlight"].ToString());
                    lbInfoPasajero.Items.Add("Origen \t" + Registro["salida"].ToString());
                    lbInfoPasajero.Items.Add("Destino \t" + Registro["Destination"].ToString());)*/


                    lbInfoMaleta.Items.Add("ID maleta \t" + Registro["IdDivaice"].ToString());
                    lbInfoMaleta.Items.Add("Latitud \t" + Registro["Latitud"].ToString());
                }

                
            }
            
            else
            {
                MySqlCommand comando = new MySqlCommand("select * from passenger p JOIN divaice d where d.IdDivaice = p.IdDivaice and p.idDivaice = @IdDivaice ", conexion);
                //MySqlCommand Num = new MySqlCommand("select COUNT(*) from InfoVuelo", conexion);
                comando.Parameters.AddWithValue("@IdDivaice", txtDocumentoUsuario.Text);
                conexion.Open();

                MySqlDataReader Registro = comando.ExecuteReader();
                //MySqlDataReader Numero = Num.ExecuteReader();


                if (Registro.Read())
                {

                    lbInfoPasajero.Items.Add("Nombres \t " + Registro["NamePassenger"].ToString());
                    lbInfoPasajero.Items.Add("Apellidos \t" + Registro["LastNamePassenger"].ToString());
                    /*lbInfoPasajero.Items.Add("Tipo de vuelo \t" + Registro["TypeFlight"].ToString());
                    lbInfoPasajero.Items.Add("Origen \t" + Registro["salida"].ToString());
                    lbInfoPasajero.Items.Add("Destino \t" + Registro["Destination"].ToString());)*/


                    lbInfoMaleta.Items.Add("ID maleta \t" + Registro["IdDivaice"].ToString());
                    lbInfoMaleta.Items.Add("Latitud \t" + Registro["Latitud"].ToString());
                }
            }
            conexion.Close();
        }


        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGenerarMapa_Click(object sender, EventArgs e)
        {
            
            FrmGenerarMapa frmGenerarMapa = new FrmGenerarMapa();
            this.Hide();
            frmGenerarMapa.ShowDialog();
            
        }

        private void txtDocumentoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCallCenterMaleta_Load(object sender, EventArgs e)

        {

        }
    }
}
