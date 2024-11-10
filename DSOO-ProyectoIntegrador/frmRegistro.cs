using DSOO_ProyectoIntegrador.Entidades;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_ProyectoIntegrador
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDocumento.Text == "" || cboTipo.Text == "" || txtDomicilio.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                E_Cliente cliente = new E_Cliente();
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Doc = Convert.ToInt32(txtDocumento.Text);
                cliente.TDoc = cboTipo.Text;
                cliente.Domicilio = txtDomicilio.Text;
                cliente.Email = txtEmail.Text;
                cliente.Telefono = Convert.ToInt32(txtTelefono.Text);
                cliente.AptoFisico = chkApto.Checked;
                cliente.Socio = chkSocio.Checked;

                Datos.Clientes clientes = new Datos.Clientes();
                respuesta = clientes.Nuevo_Cliente(cliente);
                MessageBox.Show("Respuesta de Nuevo_Cliente: " + respuesta, "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);


                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("POSTULANTE YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        Carnet carnet = new Carnet();
                        carnet.Nombre = txtNombre.Text;
                        carnet.Apellido = txtApellido.Text;
                        carnet.Dni = txtDocumento.Text;
                        carnet.FechaAlta = DateTime.Now;
                        carnet.NumCarnet = Convert.ToInt32(respuesta);


                        //Se puede probar hace la logica para que diga el carnet si socio es true o false

                        carnet.Show();
                        this.Hide();

                        //MessageBox.Show("Se registró con éxito con el Nro de Carnet " + respuesta, "AVISO DEL SISTEMA",
                        //MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Error en el registro, intente nuevamente.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            cboTipo.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtDomicilio.Text = "";
            chkApto.Checked = false;
            chkSocio.Checked = false;
            txtNombre.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
