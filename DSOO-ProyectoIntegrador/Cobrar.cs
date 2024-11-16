using DSOO_ProyectoIntegrador.Datos;
using DSOO_ProyectoIntegrador.Entidades;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
        private int clienteId;
        public Cobrar()
        {
            InitializeComponent();
            // Al inicializar el form deshabilitamos el input del monto, el botón de cobrar y el label
            txtMonto.Enabled = false;
            txtMonto.BackColor = Color.DarkGray;

            btnCobrar.Enabled = false;
            btnCobrar.BackColor = Color.DarkGray;

            lblSocioNoSocio.Visible = false;

            // Inicializamos el ID del cliente con un valor inválido
            clienteId = -1;
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
                //string respuesta;
                //E_Cuota cuota = new E_Cuota();

                //cuota.Cliente = new E_Cliente();
                //cuota.Cliente.Doc = Convert.ToInt32(txtDni.Text);

                //MessageBox.Show("DNI ingresado " + cuota.Cliente.Doc);

                //Clientes clientes = new Clientes();
                //respuesta = clientes.BuscarClientePorDni(cuota.Cliente.Doc);

                Clientes clientes = new Clientes();
                string resultado = clientes.BuscarClientePorDni(Convert.ToInt32(txtDni.Text));

                if (int.TryParse(resultado, out int id))
                {
                    if (id == 0)
                    {
                        MessageBox.Show("Cliente inexistente",
                        "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        clienteId = id;

                        MessageBox.Show($"Cliente encontrado: {resultado}",
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
                else
                {
                    MessageBox.Show($"Error al buscar el cliente: {resultado}",
                    "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                cuota.IdCliente = clienteId;

                MessageBox.Show("Monto ingresado " + cuota.Monto);

                Datos.Cuotas cuotas = new Datos.Cuotas();
                respuesta = cuotas.Cuota(cuota);

                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                        int cuotaId = Convert.ToInt32(respuesta);
                        Form comprobante = new ComprobanteCobro(clienteId, cuotaId);
                        comprobante.Show();
                        this.Close();
                    
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}
