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
        Thread t1, t2, t3;
        static void Main(string[] args)
        {

        }

        void Funzione1()
        {
            int add1=10, add2=30, somma;
            somma = add1 + add2;
            for(int i=0; i < 10; i++)
            {
                Console.WriteLine(somma);
            }
        }

        void Funzione2()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(70 * i);
            }
        }

        
    }
}
