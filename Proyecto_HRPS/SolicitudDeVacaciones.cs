using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_HRPS
{
    class SolicitudDeVacaciones
    {
        public int Identificador { get; set; }
        public DateTime DiaDeInicio { get; set; }
        public DateTime DiaDeFin { get; set; }
        public int CantidadDeDias { get; set; }
        public string CedulaDeEmpleado { get; set; }
    }
}
