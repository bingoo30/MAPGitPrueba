//HAOSHUANG HOU
//BINGCHENG WANG
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        const int N = 10; // tamaño de los arrays de monomios
        struct Monomio
        { // coeficiente y exponente
            public double coef;
            public int exp;
        }
        struct Polinomio
        {
            public Monomio[] mon; // array de monomios
            public int nMons; // num de monomios = primera pos libre en el array mon
        }
        static void Main(string[] args)
        {
            Polinomio p1;
            p1.mon = new Monomio[N];
            p1.nMons = 0;
            Monomio m1 = new Monomio();

            LeePolinomio(out p1);
            escribePolinomio(p1);
            Console.WriteLine();

            LeeMonomio(out m1);

            Inserta(m1, ref p1);
            escribePolinomio(p1);
            Console.ReadLine();
        }
        static void LeeMonomio(out Monomio m)
        {
            m = new Monomio();
            Console.WriteLine("Monomio: ");
            m.coef = double.Parse(Console.ReadLine());
            if (m.coef != 0) m.exp = int.Parse(Console.ReadLine());
        }
        static void LeePolinomio(out Polinomio p)
        {
            p.nMons = 0;
            p.mon = new Monomio[N];
            Monomio m;
            LeeMonomio(out m);
            while (!(Math.Abs(m.coef) < 0.000001))
            {
                Inserta(m, ref p);
                LeeMonomio(out m);
            }
        }
        static void escribePolinomio(Polinomio p1)
        {
            for (int i = 0; i < p1.nMons; i++)
            {
                Console.Write(" + " + p1.mon[i].coef + "x^ " + p1.mon[i].exp);
            }
        }

        static bool EqDouble(double c1, double c2)
        {
            return Math.Abs(c1 - c2) < 1e-15;
        }
        static void Inserta(Monomio m, ref Polinomio p)
        {
            if (!EqDouble(m.coef, 0))
            {  // solo insertamos si coef!=0
                int i = 0;
                // busqueda de mon del mismo grado
                while (i < p.nMons && m.exp != p.mon[i].exp) i++;
                if (i < p.nMons)
                { // monomio encontrado
                  // sumo coefs
                    double c = p.mon[i].coef + m.coef;
                    // si la suma se anula eliminamos monomio: copiamos el último a esta pos y decrementamos
                    // nMons. Nota. si el pol tiene 1 solo mon y se anula, copia componente sobre sí misma
                    // y la descarta con nMons-- (podría distinguirse ese caso especial)
                    if (EqDouble(c, 0))
                    {
                        DesplazaIzq(p, i);
                        p.nMons--;
                    }
                    else p.mon[i].coef = c; // si no se anula reemplazamos coef
                }
                else
                {
                    // añadimos m al final, si cabe
                    if (p.nMons == N) Console.WriteLine("error: polinomio lleno");
                    else
                    {
                        int k = 0;
                        while (k < p.nMons && m.exp > p.mon[k].exp) k++;
                        if (k < p.nMons)
                        {
                            DesplazaDer(p, k);
                            p.mon[k] = m;
                        }
                        else p.mon[p.nMons] = m;
                        p.nMons++;
                    }
                }
            }
        }
        static void DesplazaDer(Polinomio p, int pos)
        {
            for (int i = p.nMons; i > pos; i--)
            {
                p.mon[i] = p.mon[i - 1];
            }
        }
        static void DesplazaIzq(Polinomio p, int pos)
        {
            for (int i = pos; i < p.nMons; i++)
            {
                p.mon[i] = p.mon[i + 1];
            }
        }
    }
}