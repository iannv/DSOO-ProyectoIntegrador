using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

using MySql.Data.MySqlClient;

namespace DSOO_ProyectoIntegrador
{
    public class Conexion
    {       
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion con = null;
        private Conexion()
        {
            this.baseDatos = "Proyecto";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "";

            //bool correcto = false;
            //int mensaje;

            //string T_servidor = "Servidor"; 
            //string T_puerto = "Puerto";
            //string T_usuario = "Usuario";
            //string T_clave = "Clave";

            //while (correcto != true)
            //{
            //    T_servidor = Microsoft.VisualBasic.Interaction.InputBox("Ingresar servidor", "DATOS DE INSTALACIÓN MySQL");
            //    T_puerto = Microsoft.VisualBasic.Interaction.InputBox("Ingresar puerto", "DATOS DE INSTALACIÓN MySQL");
            //    T_usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingresar usuario", "DATOS DE INSTALACIÓN MySQL");
            //    T_clave = Microsoft.VisualBasic.Interaction.InputBox("Ingresar clave", "DATOS DE INSTALACIÓN MySQL");

            //    mensaje = (int)MessageBox.Show(
            //        "Su ingreso: " +
            //        "SERVIDOR = " + T_servidor +
            //        "PUERO = " + T_puerto + 
            //        "USUARIO = " + T_usuario +
            //        "CLAVE = " + T_clave, 
            //        "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            //       );

            //    if (mensaje != 6)
            //    {
            //        MessageBox.Show("INGRESE NEUVAMENTE LOS DATOS");
            //        correcto = false;
            //    }
            //    else
            //    {
            //        correcto = true;
            //    }
            //}

            //this.baseDatos = "Proyecto";
            //this.servidor = T_servidor;
            //this.puerto = T_puerto;
            //this.usuario = T_usuario;
            //this.clave = T_clave;
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
