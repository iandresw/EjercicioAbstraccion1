using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class Calculadora : Operaciones
    {
        public double num1{ get; set; }
        public double num2 { get; set; }

        public override double Divicion()
        {
            return num1 / num2; 
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Suma: {Suma()}");
            Console.WriteLine($"La Resta: {Resta()}");
            Console.WriteLine($"La Multiplicacion: {Multiplicacion()}");
            Console.WriteLine($"La Divicion: {Divicion()}");
        }

        public override double Multiplicacion()
        {
            return num1 * num2;
        }

        public override double Resta()
        {
            return (num1 - num2);
        }

        public override double Suma()
        {
           return  num1 + num2;
        }
    }
}
