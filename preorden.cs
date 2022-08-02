using System;
namespace Practica;
public class preorden:ordenbase
{
    public override double CalculoTotal()
    {
         Console.WriteLine("Calculo del precio total en una preorden");
        return productos.Sum(x => x.precio)* 0.09; 
    }
}