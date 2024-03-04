namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capital, interes, plazo;
            Console.Write("capital: ");
            capital = double.Parse(Console.ReadLine());
            Console.Write("interes anual: ");
            interes = double.Parse(Console.ReadLine());
            Console.Write("plazo: ");
            plazo = double.Parse(Console.ReadLine());

            double cuota, total, intereses;
            interes = interes / 12;
            plazo = plazo * 12;
            cuota = (capital * interes) / (100 * (1 - Math.Pow(((1 + interes / 100)), (-plazo))));
            total = cuota *  plazo;
            intereses = total - capital;

            

            Console.WriteLine("Resultado:" );
            Console.WriteLine("cuota: " + cuota);
            Console.WriteLine("total: " + total);
            Console.WriteLine("intereses: "+ intereses);  



        }
    }
}