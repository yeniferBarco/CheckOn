using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckOn
{
    public partial class FrmAsesorPrincipal : Form
    {
        public FrmAsesorPrincipal()
        {
            InitializeComponent();
        }

        private void tblRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCrearVuelo_Click(object sender, EventArgs e)
        {
            FrmAsesorAgregarVuelo frmAgregarVuelo = new FrmAsesorAgregarVuelo();
            this.Hide();
            frmAgregarVuelo.ShowDialog();
            
        }

        private void btnBuscarVuelo_Click(object sender, EventArgs e)
        {
            FrmAsesorInfoVuelo frmInfoVuelo = new FrmAsesorInfoVuelo();
            this.Hide();
            frmInfoVuelo.ShowDialog();
            
        }
    }
}
