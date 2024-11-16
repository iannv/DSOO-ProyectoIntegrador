using DSOO_ProyectoIntegrador.Datos;
using DSOO_ProyectoIntegrador.Entidades;
using MySql.Data.MySqlClient;
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
    public partial class Cobrar : Form
    {
        public Cobrar()
        {
            InitializeComponent();
            // Al inicializar el form deshabilitamos el input del monto, el botón de cobrar y el label
            txtMonto.Enabled = false;
            txtMonto.BackColor = Color.DarkGray;

            btnCobrar.Enabled = false;
            btnCobrar.BackColor = Color.DarkGray;

            lblSocioNoSocio.Visible = false;
        }

        // Función para buscar al cliente
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe ingresar el DNI",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                E_Cuota cuota = new E_Cuota();

                cuota.Cliente = new E_Cliente();
                cuota.Cliente.Doc = Convert.ToInt32(txtDni.Text);

                MessageBox.Show("DNI ingresado " + cuota.Cliente.Doc);

                Clientes clientes = new Clientes();
                respuesta = clientes.BuscarClientePorDni(cuota.Cliente.Doc);

                if (respuesta == "0")
                {
                    MessageBox.Show("Cliente inexistente",
                    "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Cliente encontrado: {respuesta}",
                    "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    // Si el cliente existe, habilitamos el input del monto, el botón para cobrar y el label
                    lblSocioNoSocio.Visible = true;

                    btnCobrar.Enabled = true;
                    btnCobrar.BackColor = Color.White;

                    txtMonto.Enabled = true;
                    txtMonto.BackColor = Color.White;
                    txtMonto.Focus();
                }
            }
        }

        // Función para cobrar la cuota y mostrar los datos del cliente en el comprobante
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text == "")
            {
                MessageBox.Show("Debe ingresar un monto",
               "AVISO DEL SISTEMA", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                E_Cuota cuota = new E_Cuota();
                cuota.Monto = Convert.ToInt32(txtMonto.Text);

                cuota.Cliente = new E_Cliente();
                MessageBox.Show("Monto ingresado " + cuota.Monto);

                Form comprobante = new ComprobanteCobro();
                comprobante.Show();
                this.Close();
            }
        }
    }
}
