using Trabajo_Práctico_Integrador.Constantes;
using Trabajo_Práctico_Integrador.Enums;
using Trabajo_Práctico_Integrador.Utilidades;

namespace Trabajo_Práctico_Integrador.Clases
{
    public class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateOnly Fecha_Nacimiento { private get; set; }
        public DateOnly Fecha_Ingreso { private get; set; }
        public readonly int Edad;
        public bool Activo { get; set; } = true;
        public int Cant_Materias_Aprobadas { private get; set; } = 0;

        public Alumno()
        {
        }

        public Alumno(int legajo, string nombre, string apellido, DateOnly fechaNacimiento, DateOnly fechaIngreso)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            Fecha_Nacimiento = fechaNacimiento;
            Fecha_Ingreso = fechaIngreso;
            Edad = UtilidadDeFecha.ObtenerDiferenciaDeFechasEnAnos(DateOnly.FromDateTime(DateTime.Now), Fecha_Nacimiento);
        }

        ~Alumno()
        {
            MessageBox.Show($"Alumno {Legajo} - {Nombre} - {Apellido} eliminado!");
        }

        public int Antiguedad(UnidadAntiguedad unidadAntiguedad)
        {
            DateOnly fechaActual = DateOnly.FromDateTime(DateTime.Now);
            int antiguedad = 0;
            switch (unidadAntiguedad)
            {
                case UnidadAntiguedad.ANOS:
                    antiguedad = fechaActual.Year - Fecha_Ingreso.Year;
                    break;
                case UnidadAntiguedad.MESES:
                    antiguedad = (fechaActual.Year - Fecha_Ingreso.Year) * 12 + fechaActual.Month - Fecha_Ingreso.Month;
                    break;
                case UnidadAntiguedad.DIAS:
                    antiguedad = (int)(fechaActual.ToDateTime(TimeOnly.MinValue) - Fecha_Ingreso.ToDateTime(TimeOnly.MinValue)).TotalDays;
                    break;
            }
            return antiguedad;
        }

        public int Materias_No_Aprobadas() => ConstanteDeMateria.CANTIDAD_DE_MATERIAS_TOTALES - Cant_Materias_Aprobadas;

        public int Edad_De_Ingreso() => UtilidadDeFecha.ObtenerDiferenciaDeFechasEnAnos(Fecha_Ingreso, Fecha_Nacimiento);
    }
}
