using K4os.Compression.LZ4.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_ProyectoIntegrador
{
    public partial class Carnet : Form
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaAlta { get; set; }
        public int NumCarnet { get; set; }
        public Carnet()
        {
            InitializeComponent();
        }
 
        private void Carnet_Load(object sender, EventArgs e)
        {
            lblNombreA.Text = Nombre;
            lblApellidoA.Text = Apellido;
            lblDniA.Text = Dni;
            lblFechaAltaA.Text = FechaAlta.ToString("dd/MM/yyyy");
            lblNumCarnetA.Text = NumCarnet.ToString();
        }
    }
}
