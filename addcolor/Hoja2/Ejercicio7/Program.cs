namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Año0;
            Console.Write("Año: ");
            Año0 = int.Parse(Console.ReadLine());

            bool bisiesto = Año0 % 400 == 0 && Año0 % 100 == 0 || Año0 % 100 != 0 && Año0 % 4 == 0;

            Console.WriteLine("El año es bisiesto? " + bisiesto);
            
                }
    }
}