using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Entidad_Usuario_Sistema
    {
        public String NOMBRE_USUARIO { get; set; }
        public String PASS { get; set; }
        public String CORREO { get; set; }
        public DateTime FECHA_ALTA { get; set; }
        public DateTime FECHA_BAJA { get; set; }
        public Boolean ESTADO { get; set; }
    }
}
