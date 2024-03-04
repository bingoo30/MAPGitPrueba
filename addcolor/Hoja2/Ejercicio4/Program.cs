namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroinicial, numero;
            Console.Write("Número de 4 cifras:");
            numeroinicial = int.Parse(Console.ReadLine()); //solicito numero

            numero = numeroinicial;
            int digito1, digito2, digito3, digito4;
            digito1 = numero / 1000;
            numero = numero % 1000;
            digito2 = numero / 100;
            numero = numero % 100;
            digito3 = numero / 10;
            digito4 = numero % 10;

            //enunciado1 si alguna cifra es 3
            bool check0 = digito1 == 3 || digito2 == 3 || digito3 == 3 || digito4 == 3;
            Console.WriteLine("Alguna de ella es 3: " + check0);

            //enunciado2 si al menos 2 de sus cifras son 3
            bool check1 =
                digito1 == 3 && digito2 == 3
                || digito1 == 3 && digito3 == 3
                || digito1 == 3 && digito4 == 3
                || digito2 == 3 && digito3 == 3
                || digito2 == 3 && digito4 == 3
                || digito3 == 3 && digito4 == 3
                ;
            Console.WriteLine("Al menos dos de sus cifras son 3: " + check1);


            //enunciado3 si tiene exactamente 2 consecutivas que son 3
            bool check2 =
                digito1 == 3 && digito2 == 3 && digito3 != 3
                || digito2 == 3 && digito3 == 3 && digito4 != 3 && digito1 != 3
                || digito3 == 3 && digito4 == 3 && digito2 != 3;
            Console.WriteLine("Tiene exactamente dos consecutivas que son 3: " + check2);
        }
    }
}