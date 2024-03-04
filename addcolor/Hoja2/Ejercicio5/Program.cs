namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroB;
            Console.Write("Numero binario en 4 cifras: ");
            numeroB = int.Parse(Console.ReadLine());

            int cifra1, cifra2, cifra3, cifra4, resto;
            cifra1 = numeroB / 1000;
            resto = numeroB % 1000;
            cifra2 = resto / 100;
            resto = resto % 100;
            cifra3 = resto / 10;
            cifra4 = resto % 10;

            int numeroD;
            numeroD = cifra1 * 8 + cifra2 * 4 + cifra3 * 2 + cifra4;
            Console.WriteLine("Numero decimal: " + numeroD);




        }
    }
}