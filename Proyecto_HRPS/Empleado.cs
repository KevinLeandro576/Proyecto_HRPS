using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_HRPS
{
    public static class Empleado
    {
        public static string Cedula { get; set; }
        public static string Nombre { get; set; }
        public static string Horario { get; set; }
        public static string Tiempo { get; set; }
        public static DateTime FechaDeNacimiento { get; set; }
        public static decimal Salario { get; set; }
        public static string Puesto { get; set; }
        public static int CantidadDeDiasDisponibles { get; set; }
        public static int CantidadDeDiasUsados { get; set; }
        public static double CantidadDeHorasExtra { get; set; }
        public static DateTime FechaDeInicio { get; set; }
        public static string Correo { get; set; }
        public static string Contrasena { get; set; }
    }
}
