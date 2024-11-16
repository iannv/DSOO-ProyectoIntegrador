using K4os.Compression.LZ4.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        public string SocioNoSocio { get; set; }
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
            lblSocioNoSocio.Text = SocioNoSocio;
        }

        private void imprimirCarnet(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(imprimirCarnet);
            pd.Print();

            MessageBox.Show("Operación exitosa");
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}
