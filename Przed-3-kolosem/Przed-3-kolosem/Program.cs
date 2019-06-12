using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

/*
 * Usingi potrzebne do serializacji i deserializacji
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
*/

//Zeby zrobić seriaizacje i deserializacje binarną trzeba zrobić własną klase do tego 
//Przed nazwą klasy do serializacji trzeba dać [Serializabele]
//Później w main używa sie metod do serializacji i deserializacji z tej klasy 
//Serializacja XML : XmlSerializer xs = new XmlSerializer(typeof(Obiekt));
//  - Tworzenie nowego strumienia: Stream path = File.Create("kon1.xml");
//  - xs.Serialize(path,k1);
//Deserializacja: korzystamy z tego samego obiektu klasy XmlSerializer
//  - Tworzymy pusty obiekt np. Kon k2
//  - Tworzymy nowy strumien 
//  - Stream path1 = File.OpenRead("kon1.xml");
// k2 = (Kon)xs.Deserialize(path1)


namespace Przed_3_kolosem
{
    class Pudelka
    {
        public double a, b, c;

        public Pudelka(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public static Pudelka operator + (Pudelka p1, Pudelka p2)
        {
            return new Pudelka(p1.a + p2.a, p1.b + p2.b, p1.c + p2.c);
        }

        public static bool operator ==(Pudelka p1, Pudelka p2)
        {
            return p1.Obj() == p2.Obj();

        }

        public static bool operator !=(Pudelka p1, Pudelka p2)
        {
            return p1.Obj() != p2.Obj();

        }

        public static bool operator >(Pudelka p1, Pudelka p2)
        {
            return p1.Obj() > p2.Obj();

        }

        public static bool operator <(Pudelka p1, Pudelka p2)
        {
            return p1.Obj() > p2.Obj();

        }

        public double Obj()
        {
            double objetosc = this.a * this.b * this.c;
            return objetosc;
        }
    }
    //Zadanie 2 
    class Zadanie2<T>
    {
        T[] arr;
        public int liczba;
        public Zadanie2(int a)
        {
            this.arr = new T[a];
            this.liczba = a;
        }

        //public void Uzupelnij()
        //{
        //    for (int i = 0; i < this.liczba; i++)
        //    {
        //        arr[0] = 
        //    }
        //}

    }
    //Zadanie 3
    class Zadanie3
    {
        public void Pobierz<T1, T2, T3>(T1 a,T2 b,T3 c)
        {
            Console.WriteLine(a+" "+b+" "+c);
        }
    }
    //Zadanie 4 
    class Worek<T>where T : struct
    {
        public T[] arr;
        public Worek(int a)
        {
            this.arr = new T[a];
        }
    }
    //Zadanie 5
    [Serializable]
     class Zadanie5
    {
        public double [] arr;
        Random rand = new Random();
        public Zadanie5(int a)
        {
            this.arr = new double[a];
        }
        public void Uzupelnij()
        {
            

            for (int i = 0; i < this.arr.Length; i++)
            {
                arr[i] = rand.Next(1, 20);
            }
        }
        public void WypisCo2()
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(arr[i]+" ");
                }
            }
        }
        
    }
    public static class BinarySerializer<T>
    {

        public static void Serialize(string path, T obj)
        {

            if (obj != null)
            {

                using (var fs = new FileStream(path, FileMode.Create))
                {

                    var bf = new BinaryFormatter();

                    bf.Serialize(fs, obj);

                }

            }

        }

        public static T Deserialize(string path)
        {

            T temp = default(T);

            if (File.Exists(path))
            {

                using (var fs = new FileStream(path, FileMode.Open))
                {

                    if (fs.Length > 0)
                    {

                        var bf = new BinaryFormatter();

                        return (T)bf.Deserialize(fs);

                    }

                }

            }

            return temp;

        }

    }
    // Zadanie 6
    public class Kon
    {
        public int id;
        public string nazwa, plec, masc, ojciec, matka, dataUrodzenia, miejsceUrodzenia, adresHodowcy;
        public Kon()
        {

        }

        public Kon(int id, string nazwa, string plec, string masc, string ojciec, string matka, string dataUrodzenia, string miejsceUrodzenia,
            string adresHodowcy)
        {
            this.id = id;
            this.nazwa = nazwa;
            this.masc = masc;
            this.plec = plec;
            this.ojciec = ojciec;
            this.matka = matka;
            this.dataUrodzenia = dataUrodzenia;
            this.miejsceUrodzenia = miejsceUrodzenia;
            this.adresHodowcy = adresHodowcy;
        }

        public void PrzedstawSie()
        {
            Console.WriteLine("Id: " + this.id);
            Console.WriteLine("Nazwa: " + this.nazwa);
            Console.WriteLine("Masc: " + this.masc);
            Console.WriteLine("Płeć: " + this.plec);
            Console.WriteLine("Ojciec: " + this.ojciec);
            Console.WriteLine("Matka: " + this.matka);
            Console.WriteLine("Data urodzenia: " + this.dataUrodzenia);
            Console.WriteLine("Miejsce urodzenia: " + this.miejsceUrodzenia);
            Console.WriteLine("Adres hodowcy: " + this.adresHodowcy);
        }
        public void Step()
        {
            Console.WriteLine("Step");
        }
        public void Klus()
        {
            Console.WriteLine("Klus");
        }
        public void Galop()
        {
            Console.WriteLine("Galop");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            //Pudelka p1 = new Pudelka(1, 2, 3);
            //Pudelka p2 = new Pudelka(3,4,5);
            //Pudelka p3 = p1 + p2;
            //Console.WriteLine("Objetosc dodanych pudelek: "+p3.Obj());
            //Console.WriteLine(p1>p2);
            //Zadanie2
            //Zadanie2<int> tab = new Zadanie2<int>(4);
            //Zadanie3
            //Zadanie3 z1 = new Zadanie3();
            //z1.Pobierz<int, int, int>(1, 2, 3);
            //z1.Pobierz<string, string, string >("ala","ma","kota");
            //z1.Pobierz<string, int, string >("ala",3,"kota");
            //Zadanie 4
            //Worek<int> worekA = new Worek<int>(2);
            //worekA.arr[0] = 1;
            //worekA.arr[1] = 2;
            //Worek<double> worekB = new Worek<double>(2);
            //worekB.arr[0] = 1.5d;
            //worekB.arr[1] = 1.5d;
            //Zadanie 5
            //Zadanie5 z1 = new Zadanie5(4);
            //z1.Uzupelnij();
            ////z1.WypisCo2();
            //string path = @"data.bin";
            ////BinarySerializer<Zadanie5>.Serialize(path, z1);

            //Zadanie5 z2;
            //z2=BinarySerializer<Zadanie5>.Deserialize(path);
            //z2.WypisCo2();
            //Zadanie 6
            //Kon k1 = new Kon(1, "kon Rafał", "ogier", "czarny", "nieznany", "klacz", "23-03-2005", "Katowice", "Mikołowska 123 Katowice");
            XmlSerializer xs = new XmlSerializer(typeof(Kon));
            //Stream path = File.Create("kon1.xml");
            //xs.Serialize(path, k1);
            Kon k2;
            //XmlSerializer xd = new XmlSerializer(typeof(Kon));
            Stream path1 = File.OpenRead("kon1.xml");
            
            k2 = (Kon)xs.Deserialize(path1);
            k2.Galop();
            Console.ReadKey();
        }
    }
}
