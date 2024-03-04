using System.Reflection;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2, lado3; //solicito 3 enteros positivos
            Console.Write("lado 1: ");
            lado1 = int.Parse(Console.ReadLine());
            Console.Write("lado 2: ");
            lado2 = int.Parse(Console.ReadLine());
            Console.Write("lado 3: ");
            lado3 = int.Parse(Console.ReadLine());

            //declaro las condiciones
            bool triangulo = lado1 + lado2 > lado3;
            Console.WriteLine("Forman un triángulo: " + triangulo);
            bool trianguloEq = lado1 == lado2 && lado2 == lado3;
            Console.WriteLine("Es un triángulo equilátero: " + trianguloEq);
            bool trianguloIso = lado1 == lado2 && lado2 != lado3;
            Console.WriteLine("Es un triangulo isósceles: " + trianguloIso);
            bool trianguloEsc = lado1 != lado2 && lado1 != lado3 && lado2 != lado3;
            Console.WriteLine("Es un triángulo escaleno: " + trianguloEsc);
            bool trianguloRec = lado1 * lado1 + lado2 * lado2 == lado3 * lado3;
            Console.WriteLine("Es un triángulo rectángulo: " + trianguloRec);

        }
    }
}