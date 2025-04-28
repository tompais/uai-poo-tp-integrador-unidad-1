using Trabajo_Práctico_Integrador.Constantes;

namespace Trabajo_Práctico_Integrador.Utilidades
{
    public static class UtilidadDeFecha
    {
        public static int ObtenerDiferenciaDeFechasEnAnos(DateOnly f1, DateOnly f2) => (ConstanteDeFecha.TIEMPO_CERO + (f1.ToDateTime(TimeOnly.MinValue) - f2.ToDateTime(TimeOnly.MinValue))).Year - 1;
    }
}
