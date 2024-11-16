using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_ProyectoIntegrador
{
    public partial class ComprobanteCobro : Form
    {
        public int IdCuota { get; set; }
        public int IdCliente { get; set; }
        public float Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public ComprobanteCobro()
        {
            InitializeComponent();
        }

        private void ComprobanteCobro_Load(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();

                    string query = @"
                SELECT 
                    cliente.nombre AS nombreCliente, 
                    cuota.monto AS montoCuota 
                FROM cliente
                JOIN cuota ON cliente.idCliente = cuota.idCliente
                WHERE cliente.idCliente = 452";

                    MySqlCommand cmd = new MySqlCommand(query, sqlCon);

                    // Leer los resultados
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            // Asignamos el resultado a las labels correspondientes
                            lblNombreC.Text = reader["nombreCliente"].ToString(); 
                            lblMontoC.Text = reader["montoCuota"].ToString();     
                        }
                        else
                        {
                            lblNombreC.Text = "No encontrado";
                            lblMontoC.Text = "No encontrado";
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblNombreC.Text = "Error: " + ex.Message;
                }
            }
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirComprobante);
            pd.Print();

            MessageBox.Show("Operación exitosa");
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();
        }

        private void ImprimirComprobante(object o, PrintPageEventArgs e)
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
    }
}
