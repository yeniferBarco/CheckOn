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
    public partial class FrmInicial : Form
    {
        private MySqlConnection conexion = new MySqlConnection();

        public int progress;

        public FrmInicial()
        {
            InitializeComponent();
            progress = 0;
        }

        private void FrmInicial_Load(object sender, EventArgs e)
        {
            

            for (progress = 0; progress < 100; progress++)
            {
                this.Show();
                prbCargaInicial.Value = progress;
                Show();
            }

            conexion.ConnectionString = "server=localhost; database=check - on; Uid=root; Pwd = ; SslMode=none;";
            conexion.Open();

            if (progress == 100)
            {
                this.Hide();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                this.Close();
            }
            
        }

    }
}
