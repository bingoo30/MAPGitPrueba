namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hora, minuto, segundo;
            Console.Write("Horas: ");
            hora = int.Parse(Console.ReadLine());
            Console.Write("Minutos: ");
            minuto = int.Parse(Console.ReadLine());
            Console.Write("Segundos: ");
            segundo = int.Parse(Console.ReadLine());

            int segundosF = hora * 3600 + minuto * 60 + segundo;
            Console.WriteLine("Segundos convertidos: " + segundosF);
        }
    }
}