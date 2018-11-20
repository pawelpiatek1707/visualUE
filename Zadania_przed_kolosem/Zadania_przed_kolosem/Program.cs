using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_przed_kolosem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Pętla do while");
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(++i);
            //} while (i <= 10);
            //Console.WriteLine("Pętla for");
            //for (int j=1; j <= 11; ++j){
            //    Console.WriteLine(j);
            //}
            //7.2
            //int[] a = new int[5];
            //a = new int[10];
            //Console.ReadKey();
            //4.1 z podręcznika

            //Console.Write("Podaj ilosc elementow tablicy: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];
            //int a;
            //for(int i = 0; i < n; i++)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Podaj wartosc elementu w tablicy: ");
            //    a = int.Parse(Console.ReadLine());
            //    arr1[i] = a;

            //}
            //Console.WriteLine("Elementy tablicy");
            //foreach(var x in arr1)
            //{
            //    Console.Write(x+", ");
            //}
            //4.2 z podręcznika
            //Console.Write("Podaj wielkosc tablicy: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];
            //Random rand1 = new Random();
            //for(int i = 0; i < n; i++)
            //{
            //    arr1[i] = rand1.Next(-10, 10);
            //}
            //Console.WriteLine("Tablica");
            //foreach(var x in arr1)
            //{
            //    Console.Write(x+", ");
            //}
            //Console.WriteLine();
            //int[] arr2 = new int[n];
            //for(int i = 0; i < n; i++)
            //{
            //    if (arr1[i] > 0)
            //    {
            //        arr2[i] = arr1[i];
            //        Console.Write(arr2[i]+", ");
            //    }

            //}
            //Zadanie 7.4 
            //Console.WriteLine("Podaj rozmair tablicy");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];
            //int a;
            //for(int i = 0; i < n; i++)
            //{
            //    Console.Clear();
            //    Console.Write("Podaj wartość elementu w tablicy: ");
            //    a = int.Parse(Console.ReadLine());
            //    arr1[i] = a;
            //}
            //Console.WriteLine("Tablica: ");
            //foreach(var x in arr1)
            //{
            //    Console.Write(x+", ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Element najmniejszy: "+arr1.Min());
            //Console.WriteLine("Element największy: "+arr1.Max());
            //8.1
            //string[] authors = new string[] {"Leśmian","Tuwim","Miłosz","Asnyk","Mickiewicz","Kochanowski","Rej"};
            //Console.WriteLine("Tabloca autorów");
            //foreach(var x in authors)
            //{
            //    Console.Write(x + ", ");

            //}
            //Console.WriteLine();
            //Console.Write("Długość tablicy: "+authors.Length);
            //Console.WriteLine();
            //int rejIndex = Array.IndexOf(authors, "Rej");
            //if(rejIndex>0)
            //    Console.WriteLine("Indeks Rej: "+rejIndex);

            //int KonopnickaIndex = Array.IndexOf(authors, "Konopnicka");
            //if (KonopnickaIndex > 0)
            //    Console.WriteLine("Konopnicka index: "+KonopnickaIndex);
            //else if(KonopnickaIndex<0)
            //    Console.WriteLine("Elementu Konopnicka nie ma w tablicy ");

            //int MickiewiczIndex = Array.IndexOf(authors, "Mickiewicz");
            //if(MickiewiczIndex>0)
            //    Console.WriteLine("Indeks Mickiewicz: " + MickiewiczIndex);
            //Console.WriteLine();
            //Console.WriteLine("Tablica w odwrotnej kolejności");
            //Console.WriteLine();
            //Array.Reverse(authors);
            //foreach(var x in authors)
            //{
            //    Console.Write(x+", ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Sortowanie tablicy: ");
            //Console.WriteLine();
            //Array.Sort(authors);
            //foreach(var x in authors)
            //{
            //    Console.Write(x+",");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Kopiowanie wartości: ");
            //string[] arr1 = new string[3];
            //for(int i = 0; i < 3; i++)
            //{
            //    arr1[i] = authors[i];
            //}

            //Console.WriteLine();
            //foreach(var x in arr1)
            //{
            //    Console.Write(x+", ");
            //}
            //Zadanie 9.1
            //string string1 = "ala ma kota";
            //string string2 = "ALA MA KOTA";
            //Console.WriteLine("Napis pierwszy: "+string1);
            //Console.WriteLine("Napis drugi: "+string2);
            //string string3 = String.Concat(string1, string2);
            //Console.WriteLine("Złączenie dwóch napisów: "+ string3);
            //Console.WriteLine("Długość pierwszego napisu: "+string1.Length);
            //string fragment = string2.Substring(3, 1);
            //Console.Write("Znak znajdujący sie na 3 miejscu w 2 napisie: "+fragment);
            //Console.WriteLine();
            //Console.Write("Pierwsze wystąpienie słowa 'ma': ");
            //Console.WriteLine(string1.IndexOf("ma"));
            //string string4 = string1.Insert(5, "pasa i");
            //Console.WriteLine(string4);
            //Zadanie 9.2
            //Console.Write("Podaj tekst do odwrócenia: ");
            //string string1 = Console.ReadLine();
            
            //Console.Write("Odwróconny napis: ");
            
            //for(int i=string1.Length-1;i>=0;i--)
            //{
            //    Console.Write(string1[i]);
            //}

          
            
            Console.ReadKey();
        }
    }
}
