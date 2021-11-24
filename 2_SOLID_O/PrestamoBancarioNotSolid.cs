// See https://aka.ms/new-console-template for more information
using _2_SOLID_O;

namespace SOLID;
internal class PrestamoBancarioNotSolid
{
    public TipoPrestamo Tipo { get; set; }
    public double Monto { get; set; }

    internal string Descripcion() => this.Tipo switch
    {
        TipoPrestamo.Reforma => $"Préstamo para reforma. Monto solicitado: {Monto}. Monto a Devolver {Monto+((5*Monto)/100)}. Interés: 5%" ,
        TipoPrestamo.Coche => $"Préstamo para coche. Monto solicitado: {Monto}. Monto a Devolver {Monto + ((7 * Monto) / 100)}. Interés: 7%",        
        _ => "Préstamo no reconocido. No hay descripción ni cálculo de monto a devolver"
    };
}