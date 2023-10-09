using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad

namespace Datos
{
    public class Datos_Usuario_Sistema
    {
        // Conexion a la BD sistema_comercial
        SqlConnection cn_bdprueba = new SqlConnection(
            ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        // Implementar los metodos de la clase Usuario_Sistema
        public String Validar(Usuario_Sistema oUserSistema)
        {

            // Ejecutar el sp_ActualizarCliente -> update -> No devuelve registros
            cn_bdprueba.Open();
            SqlCommand cmd = new SqlCommand("sp_Validar_Usuario_Sistema", cn_bdprueba);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nom", oUserSistema.Nombre);
            cmd.Parameters.AddWithValue("@pwd", oUserSistema.Password);

            SqlParameter mensaje = new SqlParameter("@resultado", SqlDbType.VarChar, 100);
            mensaje.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(mensaje);

            cmd.ExecuteNonQuery();
            cn_bdprueba.Close();
            return cmd.Parameters["@resultado"].Value.ToString();
        }
}
