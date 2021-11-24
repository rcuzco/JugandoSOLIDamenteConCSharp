// See https://aka.ms/new-console-template for more information
using SOLID.NotSolid;

Console.WriteLine("Hello, World!");

PrestamoPersonal prestamoPersonalNotSolid = new PrestamoPersonal() { Monto = 1000, PorcentajeInteres = 5 };
PrestamoHipotecario prestamoHipotecarioNotSolid = new PrestamoHipotecario() { Monto = 80000, PorcentajeInteres = 10, AnhosPrestamo = 10, CapitalInicial = 20000 };

GestionImpresionNotSolid gestionImpresionNotSolid = new GestionImpresionNotSolid();
gestionImpresionNotSolid.ObtenerInformacion(prestamoPersonalNotSolid);
gestionImpresionNotSolid.ObtenerInformacion(prestamoHipotecarioNotSolid);

Console.WriteLine("Ahora vamos a hacerlo bien");

SOLID.Good.PrestamoPersonal prestamoPersonal = new SOLID.Good.PrestamoPersonal() { Monto = 1000, PorcentajeInteres = 5 }; ;
SOLID.Good.PrestamoHipotecario prestamoHipotecario = new SOLID.Good.PrestamoHipotecario() { Monto = 80000, PorcentajeInteres = 10, AnhosPrestamo = 10, CapitalInicial = 20000 }; ;

SOLID.Good.GestionImpresion gestionImpresion = new SOLID.Good.GestionImpresion();
gestionImpresion.ObtenerInformacion(prestamoPersonal);
gestionImpresion.ObtenerInformacion(prestamoHipotecario);