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
    internal class Cuotas
    {
        public string Cuota(E_Cuota cuota)
        {
            string respuesta;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("Cuota", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros para los campos de la tabla Cuota
                comando.Parameters.Add("IdCliente", MySqlDbType.Int32).Value = cuota.IdCliente;
                comando.Parameters.Add("Monto", MySqlDbType.Float).Value = cuota.Monto;
                comando.Parameters.Add("FechaPago", MySqlDbType.Date).Value = cuota.FechaPago;
                comando.Parameters.Add("FechaVencimiento", MySqlDbType.Date).Value = cuota.FechaVencimiento;

                // Parámetros de salida para capturar la respuesta del procedimiento
                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta"; 
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);

                sqlCon.Open();
                comando.ExecuteNonQuery();
                respuesta = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return respuesta;
        }
    }
}
