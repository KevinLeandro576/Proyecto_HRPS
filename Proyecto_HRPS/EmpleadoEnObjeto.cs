using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_HRPS
{
    class EmpleadoEnObjeto
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Horario { get; set; }
        public string Tiempo { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int Salario { get; set; }
        public string Puesto { get; set; }
        public int CantidadDeDiasDisponibles { get; set; }
    }
}
