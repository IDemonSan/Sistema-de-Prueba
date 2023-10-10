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
        public String N_Login(Entidad.Entidad_Usuario_Sistema obje)
        {
            return objd.D_Login(obje);
        }
    }
}
