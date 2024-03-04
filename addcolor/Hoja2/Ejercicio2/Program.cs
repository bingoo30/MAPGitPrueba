namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double edadA, edadB, edadC; //soliccito la edad de los tres alumnos
            Console.Write("Edad del primer alumno: ");
            edadA = int.Parse(Console.ReadLine());
            Console.Write("Edad del segundo alumno: ");
            edadB = int.Parse(Console.ReadLine());
            Console.Write("Edad del tercer alumno: ");
            edadC = int.Parse(Console.ReadLine());

            double edadMedia; //calculo la edad media
            edadMedia = (edadA + edadB + edadC) / 3;
            
            Console.WriteLine("La edad media de los tres es: " + edadMedia);
        }
    }
}