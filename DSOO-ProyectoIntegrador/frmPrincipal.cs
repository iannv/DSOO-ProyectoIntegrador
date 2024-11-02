using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_ProyectoIntegrador
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        internal string rol;
        internal string usuario;
        private void frmPrincipal_Load_1(object sender, EventArgs e)
        {
            lblIngresar.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Form registro = new frmRegistro();
            registro.Show();
            this.Hide();

        }

        private void btnVerCarnet_Click(object sender, EventArgs e)
        {
            Form carnet = new Carnet();
            carnet.Show();
            this.Hide();
        }
    }
}
