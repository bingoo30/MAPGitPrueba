﻿namespace ejercicio3
{
    internal class Program
    {
        // cambios para el conflicto tipo3
        static void Main(string[] args)
        {
            int[] v = { 0, 2, 1, 3, 4, 2, 3, 1, 2, 0, 3, 4 }; 

            EscribeArray(v);
           
            EscribeArray(v); //0099999
            //inicializar los arrays a 0

            //otra forma, con los min y max hi

        }
        static void Palomar(int[]v)
        {
            int[] t = new int[Maximo(v) + 1];
            for (int i = 0; i < t.Length; i++)
            {
                //hola adios
            }
            RellenaTabla(v, t);
            ColocaArray(v, t);
            //aqui esta el tercer cambioo
        }
        static int Maximo(int[] v)
        {
            int max = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > max) max = v[i];
                //provocando ultimo conflicto
            }
            return max;
        }
        static void RellenaTabla(int[] v, int[] t)
        {
            for (int i = 0; i < v.Length; i++)
            {
                t[v[i]]++;
            }
        }
        static void ColocaArray(int[] v, int[] t)
        {
            int cont = 0;
            for (int i = 0; i < t.Length; i++)
            {
                for (int j = 0; j < t[i]; j++)
                {
                    v[cont] = i;
                    cont++;
                }
                //chao
            }
        }
        static void EscribeArray(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + ", ");
            }
            Console.WriteLine();
        }

    }
}