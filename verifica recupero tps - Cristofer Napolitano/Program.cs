using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace verifica_recupero_tps___Cristofer_Napolitano
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Funzione1));
            Thread t2 = new Thread(new ThreadStart(Funzione2));
            Thread t3 = new Thread(new ThreadStart(Funzione3));

            t1.Start();
            t2.Start();
            t3.Start();

            
            Console.ReadKey();
        }

        static void Funzione1()
        {
            Thread.Sleep(777);
            int add1=10, add2=30, somma;
            somma = add1 + add2;
            for(int i=0; i < 10; i++)
            {
                Console.WriteLine(somma);
            }
        }

        static void Funzione2()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(70 * i);
            }
        }

        static void Funzione3()
        {
            Thread.Sleep(777);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Siamo nell'anno 202{i}");
            }
        }
    }
}
