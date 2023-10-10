using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;

using Entidad;

namespace Datos
{
    public class Datos_Usuario_Sistema
    {
    SqlConnection cn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public String D_Login(Entidad.Entidad_Usuario_Sistema obje)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_Validar_Usuario_Sistema", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nom", obje.NOMBRE_USUARIO);
            cmd.Parameters.AddWithValue("@pwd", obje.PASS);

            SqlParameter mensaje = new SqlParameter("@resultado", SqlDbType.VarChar, 100);
            mensaje.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(mensaje);

            cmd.ExecuteNonQuery();
            cn.Close();
            return cmd.Parameters["@resultado"].Value.ToString();
        }
    }
}
