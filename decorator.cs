using System;
namespace Practica;
    public class decorator: ordenbase
    {
        protected ordenbase orden;
        public decorator (ordenbase orden)
        {
            this.orden=orden;
        }
        public override double CalculoTotal()
        {
            Console.WriteLine("Calculo del precio total desde la clase decoradora");
            return orden.CalculoTotal();
        }
    }
