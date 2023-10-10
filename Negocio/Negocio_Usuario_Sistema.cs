using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;

namespace Negocio
{
    public class Negocio_Usuario_Sistema
    {
        Datos.Datos_Usuario_Sistema objd = new Datos.Datos_Usuario_Sistema();

        public bool N_Login(Entidad.Entidad_Usuario_Sistema obje, out string mensajeError)
        {
            return objd.D_Login(obje, out mensajeError);
        }
    }
}
