// See https://aka.ms/new-console-template for more information
using _2_SOLID_O;

namespace SOLID;
internal abstract class PrestamoBancario
{
    protected double Monto { get; set; }

    protected abstract double Interes {get;}

    protected PrestamoBancario(double monto)
    {
        Monto = monto;        
    }
    internal abstract string Descripcion();
}

internal class PrestamoPersonalCoche : PrestamoBancario
{
    public PrestamoPersonalCoche(double monto) : base(monto)
    {
    }

    protected override double Interes => 7;

    internal override string Descripcion()
    {
        return $"Préstamo para coche. Monto solicitado: {Monto}. Monto a Devolver {Monto + ((Interes * Monto) / 100)}. Interés: {Interes}%";
    }
}

internal class PrestamoPersonalReforma : PrestamoBancario
{
    public PrestamoPersonalReforma(double monto) : base(monto)
    {
    }

    protected override double Interes => 5;

    internal override string Descripcion()
    {
        return $"Préstamo para reforma. Monto solicitado: {Monto}. Monto a Devolver {Monto + ((Interes * Monto) / 100)}. Interés: {Interes}%";
    }
}

internal class PrestamoHipotecario : PrestamoBancario
{
    public PrestamoHipotecario(double monto) : base(monto)
    {
    }

    protected override double Interes => 10;

    internal override string Descripcion()
    {
        return $"Préstamo para hipoteca. Monto solicitado: {Monto}. Monto a Devolver {Monto + ((Interes * Monto) / 100)}. Interés: {Interes}%";
    }
}