using System;
namespace Practica;
public class ordenregular:ordenbase
{
    public override double CalculoTotal()
    {
        Console.WriteLine("Calculo del precio total de un pedido normal");
        return productos.Sum(x => x.precio );
    }
}