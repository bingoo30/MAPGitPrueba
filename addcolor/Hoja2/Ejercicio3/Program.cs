namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double notaExamen, notaPractica, notaTrabajo; //declaro variables con decimales y solicito datos
            Console.Write("Nota examen: ");
            notaExamen = double.Parse(Console.ReadLine());
            Console.Write("Nota prácticas: ");
            notaPractica = double.Parse(Console.ReadLine());
            Console.Write("Nota trabajo extra: ");
            notaTrabajo = double.Parse(Console.ReadLine());

            double notaMedia;//calculo la media 
            notaMedia = notaExamen * 0.7 + notaPractica * 0.2 + notaTrabajo * 0.1;
            Console.WriteLine("Nota media: " + notaMedia);


        }
    }
}