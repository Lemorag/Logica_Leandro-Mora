using System;
namespace CalculadoraCuadratica
{
    internal class CalculadoraCuadratica
    {
        static void Main(string[] args)
        {
            int valueA, valueB, valueC, num1;
            double x1, x2;

            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Escriba valor ax");
                valueA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escriba valor bx");
                valueB =  Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escriba valor c");
                valueC = Convert.ToInt32(Console.ReadLine());

                num1= 4;
                x1= (-valueB+  Math.Sqrt(valueB*valueB +(num1*valueA*valueC)))/(2*valueA);

                Console.Write("Elvalor de x1 es = " + x1"");

                x2= (-valueB- Math.Sqrt(valueB*valueB +(num1*valueA*valueC)))/(2*valueA);

                Console.Write("Elvalor de x2 es = " + x2);
            }
        }
    }
}
