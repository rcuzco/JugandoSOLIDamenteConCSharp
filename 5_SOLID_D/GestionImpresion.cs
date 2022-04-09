// See https://aka.ms/new-console-template for more information

namespace SOLID.Good;

internal interface IInformacionObtenible
{
    void ObtenerInformacion();
}

internal abstract class Prestamo
{
    public abstract int Monto { get; set; }
    public abstract int PorcentajeInteres { get; set; }
}

internal class PrestamoPersonal : Prestamo, IInformacionObtenible
{
    public override int Monto { get; set; }
    public override int PorcentajeInteres { get; set; }

    public void ObtenerInformacion()
    {
        Console.WriteLine($"Código maravilloso para mostrar la información de este préstamo: Monto solicitado: {Monto} a un interés del {PorcentajeInteres}%");
    }
}

internal class PrestamoHipotecario : Prestamo, IInformacionObtenible
{
    public int AnhosPrestamo { get; set; }
    public int CapitalInicial { get; set; }
    public override int Monto { get; set; }
    public override int PorcentajeInteres { get; set; }

    public void ObtenerInformacion()
    {
        Console.WriteLine($"Código maravilloso para mostrar la información de este préstamo: " +
            $"Monto solicitado: {Monto} a un interés del {PorcentajeInteres}% " +
            $"durante {AnhosPrestamo} años. El cliente aporta un capital inicial de {CapitalInicial}");
    }
}

internal class GestionImpresion
{
    internal void ObtenerInformacion(IInformacionObtenible datosPrestamo)
    {
        datosPrestamo.ObtenerInformacion();
    }
}