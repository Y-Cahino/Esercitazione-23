using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corsi_and_Orsi39_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare
            string[] a = new string[10];
            //menù
            Console.WriteLine("1 - Aggiunta nomi animali");
            Console.WriteLine("2 - Cancella nomi animali");
            Console.WriteLine("3 - Elenca in ordine alfabetico");
            Console.WriteLine("4 - Ricerca sequenziale animale");
            Console.WriteLine("5 - Visualizza animali ripetuti");
            Console.WriteLine("6 - Modifica nome");
            Console.WriteLine("7 - Visualizza animali");
            Console.WriteLine("8 - Visualizza nome più lungo e più corto");
            Console.WriteLine("9 - Cancella tutti i nomi uguali");
            int scelta = int.Parse(Console.ReadLine());
            do
            {
                switch (scelta)
                {
                    case 1:
                        if (a.Length<10)
                        {
                            aggiunta(a);
                            Console.WriteLine("Nome inserito correttamente");
                        }
                        else
                        {
                            Console.WriteLine("Array pieno");
                        }
                        break;
                }
            } while (scelta != 0);

        }
        //funzione di aggiunta
        static void aggiunta(string []a, int n)
        {
            for (int i = 0; i < a.Length; i++)
            {

            }
        }
    }
}
