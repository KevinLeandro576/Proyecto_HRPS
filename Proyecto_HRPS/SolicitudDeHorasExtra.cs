using System;

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
