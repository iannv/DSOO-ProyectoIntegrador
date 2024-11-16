using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_ProyectoIntegrador
{
    public partial class ListadoVencimientos : Form
    {
        MySqlConnection sqlCon;
        MySqlDataAdapter adapter;
        DataTable dt;

        public ListadoVencimientos()
        {
            InitializeComponent();
        }

        private void ListadoVencimientos_Load(object sender, EventArgs e)
        {
            mostrarListado();
        }

        public void mostrarListado()
        {
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                adapter = new MySqlDataAdapter(@"
                SELECT 
                    cliente.numCarnet AS 'N° CARNET',
                    cliente.nombre AS 'NOMBRE',
                    cliente.apellido AS 'APELLIDO',
                    cliente.telefono AS 'TELEFONO',
                    cliente.email AS 'EMAIL',
                    cuota.fechaVencimiento AS 'VENCIMIENTO'
                FROM cliente
                INNER JOIN cuota 
                    ON cliente.idCliente = cuota.idCliente
                WHERE cliente.socio = 1 AND cuota.fechaVencimiento = CURDATE();", 
                    sqlCon);

                // Llena la tabla
                dt = new DataTable();
                adapter.Fill(dt);

                // Asigna al DataGridView y solo puede ser leido
                dgvListado.ReadOnly = true;
                dgvListado.DataSource = dt;

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}

