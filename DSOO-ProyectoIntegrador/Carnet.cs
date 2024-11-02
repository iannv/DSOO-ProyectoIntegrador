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
    public partial class Carnet : Form
    {
        public Carnet()
        {
            InitializeComponent();
        }

        public string nombre;
        public string apellido;
        public string dni;
        public DateTime fechaAlta;
        public int numCarnet;

        private void Carnet_Load(object sender, EventArgs e)
        {
          
        }
    }
}
