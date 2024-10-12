using DSOO_ProyectoIntegrador.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_ProyectoIntegrador.Datos
{
    internal class Clientes
    {
        public string Nuevo_Cliente(E_Cliente cliente)
        {
            string salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoCliente",
                sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = cliente.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = cliente.Apellido;
                comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value = cliente.TDoc;
                comando.Parameters.Add("Dni", MySqlDbType.Int32).Value = cliente.Doc;
                comando.Parameters.Add("Domicilio", MySqlDbType.VarChar).Value = cliente.Domicilio;
                comando.Parameters.Add("Telefono", MySqlDbType.VarChar).Value = cliente.Telefono;
                comando.Parameters.Add("Email", MySqlDbType.VarChar).Value = cliente.Email;
                //comando.Parameters.Add("NumCarn", MySqlDbType.Int32).Value = cliente.NumCarnet;
                comando.Parameters.Add("Socio", MySqlDbType.Binary).Value = cliente.Socio ? 1 : 0; 
                comando.Parameters.Add("AptoFisico", MySqlDbType.Binary).Value = cliente.AptoFisico ? 1 : 0; 
                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return salida;

        }
    }
}