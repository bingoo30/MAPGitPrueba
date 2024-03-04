namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());

            int n1, n2, n3;
            n1 = (n / 2) * 2; //el numero par no superior a n
            n2 = n + ((n + 1) % 2); // el primer impar mayor o igual que n
            n3 = ((n + 1) / 2) * 2; //el primer numero par mayor o igual que n
            Console.WriteLine("n1= " + n1 + "n2: " + n2 + "n3: " + n3);
            
        }
    }
}