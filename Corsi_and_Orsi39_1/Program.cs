using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Corsi_and_Orsi39_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare
            int dim;
            
            string s;
            //grandezza array
            Console.WriteLine("Inserire grandezza array");
            dim=int.Parse(Console.ReadLine());
            string[] a = new string[dim];
            //inserimento animali
            for (int i=0; i<dim; i++)
            {
                Console.Clear();
                Console.WriteLine("Inserisci un nome di animale");
                a[i] = Console.ReadLine();
                //interruzione prima del limite massimo
                Console.WriteLine("Desideri continuare?");
                int scelta2=int.Parse(Console.ReadLine());
                switch scelta2
                    {
                    case 1:
                        break;
                }
                //ciclo di interruzione
                if()
                {

                }
                else
                {
                    break;
                }
            }
            //cancellamento console
            Console.Clear();
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
            Console.Clear();
            do
            {
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Inserire nome:");
                        s = Console.ReadLine();
                        if (aggiunta(ref a, s, ref dim))
                        {
                                Console.WriteLine("Nome inserito correttamente");
                        }
                        else
                        {
                            Console.WriteLine("Array pieno");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Inserire nom* da cancellare: ");
                        s= Console.ReadLine();
                        if(canc(ref a, s, ref dim))
                        {
                            Console.WriteLine("Element* eleminat*");
                        }
                        else
                        {
                            Console.WriteLine("Elemento non presente");
                        }
                        break;

                    case 3:
                        bubblesort(dim, ref a);
                        break;
                }
            } while (scelta != 0);

        }
        //funzione di aggiunta
        static bool aggiunta(ref string []a,string s,ref int i)
        {
            //variabile per controllare se il vettore è pieno o meno
            bool inserimento = true;
            //controllo di riempimento
            if(i<a.Length)
            {
                while (a != null)
                {
                    a[i] = s;
                    i++;
                }
               
            }
            else
            {
                inserimento = false;
            }
            //ritorna il valore della variabile booleana
            return inserimento;
        }
        //funzione di cancellamento
        static bool canc(ref string []a,string s, ref int i)
        {
            //esisenza stringa
            bool esiste = false;
            //ciclo controllo
            for(int j=0;j<i;j++)
            {
                if(a[j]== s)
                {
                    i--;
                    //ciclo di spostamento per la cancellazione
                    for(int k=j;k<a.Length;k++)
                    {
                        a[k] = a[k + 1];
                    }
                    esiste = true;
                    break;
                }
            }
            return esiste;
        }
       //funzione bubblesort
       static int bubblesort(int dim, ref string []a)
        {
            string s;
            //ciclo per ordinare
            for(int i=0;i<dim;i++)
            {
                //trasferisco il primo carattere di ogni stringa in una variabile per ordinare
                int o1=(int)a[i].FirstOrDefault();
                int o2 = (int)a[i+1].FirstOrDefault();
                Console.WriteLine(o1);
                Console.WriteLine(o2);
                Thread.Sleep(1000);
                //ciclo di controllo
                if (o1 > o2)
                {
                    //scambio dei valori
                    s = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = s;
                }
            }
            return 0;
        }





    }
}
