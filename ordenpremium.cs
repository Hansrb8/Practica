using System;
namespace Practica;
public class ordenpremium: decorator
{
    public ordenpremium(ordenbase orden):base (orden)
    {

    }

    public override double CalculoTotal()
    {
        Console.WriteLine("Calculo Total Precio Orden Premium");
        var precioordenprecio =base.CalculoTotal();
        return precioordenprecio*0.9;
    }
}