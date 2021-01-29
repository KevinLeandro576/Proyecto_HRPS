using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_HRPS
{
    class SolicitudDeHorasExtra
    {
        public int Identificador { get; set; }
        public DateTime Dia { get; set; }
        public decimal CantidadDeHoras { get; set; }
        public string CedulaDeEmpleado { get; set; }
    }
}
