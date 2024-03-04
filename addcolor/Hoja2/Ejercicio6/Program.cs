namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //solicito la cantidad de dinero inicial en double
            Console.Write("¿Cuánto dinero quieres?: ");

            //convierto a centimos;
            int centimos = Convert.ToInt32(100 * (double.Parse(Console.ReadLine())));

            //calulos
            int billete500, billete200, billete100, billete50, billete20, billete10, billete5,
                moneda2, moneda1, moneda50c, moneda20c, moneda10c, moneda5c, moneda2c, moneda1c;
            billete500 = centimos / 50000;
            int resto;
            resto = centimos % 50000;
            billete200 = resto / 20000;
            resto = resto % 20000;
            billete100 = resto / 10000;
            resto = resto % 10000;
            billete50 = resto / 5000;
            resto = resto % 5000;
            billete20 = resto / 2000;
            resto = resto % 2000;
            billete10 = resto / 1000;
            resto = resto % 1000;
            billete5 = resto / 500;
            resto = resto % 500;
            moneda2 = resto / 200;
            resto = resto % 200;
            moneda1 = resto / 100;
            resto = resto % 100;
            moneda50c = resto / 50;
            resto = resto % 50;
            moneda20c = resto / 20;
            resto = resto % 20;
            moneda10c = resto / 10;
            resto = resto % 10;
            moneda5c = resto / 5;
            resto = resto % 5;
            moneda2c = resto / 2;
            moneda1c = resto % 2;

            //mostrar en la pallada la cantidad convertida
            Console.WriteLine("Tu cambio:");
            Console.WriteLine("Billetes de 500: " + billete500);
            Console.WriteLine("Billetes de 200: " + billete200);
            Console.WriteLine("Billetes de 100: " + billete100);
            Console.WriteLine("Billetes de 50: " + billete50);
            Console.WriteLine("Billetes de 20: " + billete20);
            Console.WriteLine("Billetes de 10: " + billete10);
            Console.WriteLine("Billetes de 5: " + billete5);
            Console.WriteLine("Monedas de 2: " + moneda2);
            Console.WriteLine("Monedas de 1: " + moneda1);
            Console.WriteLine("Monedas de 50c: " + moneda50c);
            Console.WriteLine("Monedas de 20c: " + moneda20c);
            Console.WriteLine("Monedas de 10c: " + moneda10c);
            Console.WriteLine("Monedas de 5c: " + moneda5c);
            Console.WriteLine("Monedas de 2c: " + moneda2c);
            Console.WriteLine("Monedas de 1c: " + moneda1c);
        }
    }
}