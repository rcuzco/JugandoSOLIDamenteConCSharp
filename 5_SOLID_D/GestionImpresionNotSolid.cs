// See https://aka.ms/new-console-template for more information

namespace SOLID.NotSolid;

internal class PrestamoPersonal
{
    public int Monto { get; set; }
    public int PorcentajeInteres { get; set; }
}

internal class PrestamoHipotecario : PrestamoPersonal
{
    public int AnhosPrestamo { get; set; }
    public int CapitalInicial { get; set; }
}

internal class GestionImpresionNotSolid
{
    internal void ObtenerInformacion(PrestamoPersonal prestamoPersonal)
    {
        Console.WriteLine($"Código maravilloso para mostrar la información de este préstamo: Monto solicitado: {prestamoPersonal.Monto} a un interés del {prestamoPersonal.PorcentajeInteres}%");
    }

    internal void ObtenerInformacion(PrestamoHipotecario prestamoHipotecario)
    {
        Console.WriteLine($"Código maravilloso para mostrar la información de este préstamo: " +
            $"Monto solicitado: {prestamoHipotecario.Monto} a un interés del {prestamoHipotecario.PorcentajeInteres}% " +
            $"durante {prestamoHipotecario.AnhosPrestamo} años. El cliente aporta un capital inicial de {prestamoHipotecario.CapitalInicial}");
    }
}