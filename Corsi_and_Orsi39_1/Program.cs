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
            int dim = 0;
            string[] a = new string[dim];
            int n=0;
            string s;
            //grandezza array
            Console.WriteLine("Inserire grandezza array");
            dim=int.Parse(Console.ReadLine());
            //inserimento animali
            for (int i=0; i<dim; i++)
            {
                Console.Clear();
                Console.WriteLine("Inserisci un nome di animale");
                a[i] = Console.ReadLine();
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
        // Funzione per riempire il vettore con numeri casuali

        void riempi(ref string []a, ref int n, int max)
        {
            int conta;
            srand(time(0));
            for (conta = 0; conta < n; conta++)
            {
                a[conta] = ();
            }
        }

        // Funzione per ordinare il vettore utilizzando il metodo Shell Sort

        void ShellSort(ref string []a, ref int n)
        {
            for (int gap = n / 2; gap > 0; gap /= 2)    // inizializzazione del gap
            {
                for (int i = gap; i < n; i++)       // confronto e scambio degli elementi all'interno del sottogruppo
                {
                    string temp = a[i];      // salvataggio dell'elemento corrente
                    int j;
                    for (j = i; j >= gap && vet[j - gap] > temp; j -= gap
            
        }
            }
        }





    }
}
