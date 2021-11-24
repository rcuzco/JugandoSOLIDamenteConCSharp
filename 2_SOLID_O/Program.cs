// See https://aka.ms/new-console-template for more information
using _2_SOLID_O;
using SOLID;

Console.WriteLine("Hello, World!");

PrestamoBancarioNotSolid prestamoPersonalCocheNotSolid = new() { Tipo = TipoPrestamo.Coche, Monto = 1000 };
Console.WriteLine(prestamoPersonalCocheNotSolid.Descripcion());

PrestamoBancarioNotSolid prestamoPersonalReformaNotSolid = new() { Tipo = TipoPrestamo.Reforma, Monto = 1000 };
Console.WriteLine(prestamoPersonalReformaNotSolid.Descripcion());

//si necesitamos introducir otro tipo de préstamo bancario, tendríamos que abrir la clase PréstamoBancario y modificarla y eso VIOLA el principio.
//PrestamoBancarioNotSolid prestamoHipotecario = new() { Tipo = TipoPrestamo.Hipoteca, Monto = 100000 };
//Console.WriteLine(prestamoHipotecario.Descripcion());

//lo suyo sería... que PrestamoBancario sea abstracto e ir implementando los tipos en base a dicha clase

Console.WriteLine("Ahora vamos a hacerlo bien");

PrestamoBancario prestamoPersonalCoche = new PrestamoPersonalCoche(1000);
Console.WriteLine(prestamoPersonalCoche.Descripcion());

PrestamoBancario prestamoPersonalReforma = new PrestamoPersonalReforma(1000);
Console.WriteLine(prestamoPersonalReforma.Descripcion());

PrestamoBancario prestamoHipotecario = new PrestamoHipotecario(100000);
Console.WriteLine(prestamoHipotecario.Descripcion());