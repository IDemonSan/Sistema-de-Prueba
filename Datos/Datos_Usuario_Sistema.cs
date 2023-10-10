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

        public bool D_Login(Entidad.Entidad_Usuario_Sistema obje, out string mensajeError)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("dbo.ValidarCredencialesUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NombreUsuario", obje.NOMBRE_USUARIO);
            cmd.Parameters.AddWithValue("@Password", obje.PASS);

            SqlParameter usuarioValidoParam = new SqlParameter("@UsuarioValido", SqlDbType.Bit);
            usuarioValidoParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(usuarioValidoParam);

            SqlParameter mensajeErrorParam = new SqlParameter("@MensajeError", SqlDbType.NVarChar, 255);
            mensajeErrorParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(mensajeErrorParam);

            cmd.ExecuteNonQuery();
            cn.Close();

            mensajeError = cmd.Parameters["@MensajeError"].Value.ToString();
            return (bool)cmd.Parameters["@UsuarioValido"].Value;
        }

    }
}
