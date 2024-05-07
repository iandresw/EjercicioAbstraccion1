// See https://aka.ms/new-console-template for more information
using EjercicioAbstraccion;

Console.WriteLine("Hello, World!");
Calculadora calculadora = new Calculadora();
Console.WriteLine("Ingrese el Primer Numero:");
calculadora.num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el Segundo Numero:");
calculadora.num2 = double.Parse(Console.ReadLine());
calculadora.Imprimir();


