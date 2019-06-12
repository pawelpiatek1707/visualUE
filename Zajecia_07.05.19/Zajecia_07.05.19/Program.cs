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


namespace Zajecia_07._05._19
{
    //Zadanie 1
    class Pudelka
    {
        public int x, y, z;

      
        public Pudelka(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
          
        }
        public int Obj()
        {
            return this.x * this.y * this.z;
        }

        public static Pudelka operator + (Pudelka a, Pudelka b)
        {
            return new Pudelka(a.x+b.x,a.y+b.y,a.z+b.z);
        }
    }


    
    //Zadanie 2
    public class Zadanie2<T>

    {
        T[] dane;
       
        public Zadanie2(int liczba)
        {
            this.dane = new T[liczba];
            
        }
    }
    //Zadanie 3 
    static class Zadanie3
    {
        public static void Metoda<T1, T2,T3>(T1 a, T2 b, T3 c)
        {
            Console.Write(a);
            Console.Write(b);
            Console.WriteLine(c);
        }
    }
    //Zadanie 4
    class Zadanie4<T>where T:struct
    {
        public const string slowo = "aaaa";
        public T[] dane;
        public void Wyswietl()
        {
            Console.Clear();
            foreach(var x in dane)
            {
                Console.Write(x+" ");
            }
        }

        public Zadanie4(int liczba)
        {
            this.dane = new T[liczba];

        }
    }
    //Zadanie 5
    [Serializable]
    class Zadanie5
    {
        public int[] arr;
        Random rand = new Random();

        public Zadanie5(int liczba)
        {
            this.arr = new int[liczba];
            for (int i = 0; i < liczba; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
        }

        public void Wyswietl()
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(this.arr[i]);
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
    //Zadanie 6
    public class Kon
    {
        public int id;
        public string nazwa, plec,masc,ojciec,matka,dataUrodzenia,miejsceUrodzenia,adresHodowcy;
        public Kon()
        {

        }

        public Kon(int id,string nazwa,string plec,string masc,string ojciec,string matka,string dataUrodzenia,string miejsceUrodzenia,
            string adresHodowcy )
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
            Console.WriteLine("Id: "+this.id);
            Console.WriteLine("Nazwa: "+this.nazwa);
            Console.WriteLine("Masc: "+this.masc);
            Console.WriteLine("Płeć: "+this.plec);
            Console.WriteLine("Ojciec: "+this.ojciec);
            Console.WriteLine("Matka: "+this.matka);
            Console.WriteLine("Data urodzenia: "+this.dataUrodzenia);
            Console.WriteLine("Miejsce urodzenia: "+this.miejsceUrodzenia);
            Console.WriteLine("Adres hodowcy: "+this.adresHodowcy);
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
    //Zadnaie 7
    public class katalog
    {
        public class ksiazka
        {
            public string autor, tytul, rodzaj, data, opis;
            public double cena;
        }

    }
    
    

class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            //Pudelka p1 = new Pudelka(3, 4, 5);
            //Pudelka p2 = new Pudelka(6, 7, 8);
            //Pudelka wynik = p1 + p2;
            //Console.WriteLine(wynik.Obj());

            //Zadanie 2
            //Zadanie2<int> tablica = new Zadanie2<int>(4);           
            //Zadanie2<string> tablica1 = new Zadanie2<string>(4);
            //Zadanie 3
            //Zadanie3.Metoda<int, int, int>(3, 4, 5);
            //Zadanie3.Metoda<string, string, string>("a","b","c");
            //Zadanie3.Metoda<string, int, string>("a",1,"c");
            //Zadanie 4
            //Console.Write("Podaj rozmair tablicy: ");
            //int liczba = int.Parse(Console.ReadLine());
            //Zadanie4<int> tablicaInt = new Zadanie4<int>(liczba);

            //for (int i = 0; i < liczba; i++)
            //{
            //    Console.WriteLine("Podaj zawartosc tablicy");
            //    tablicaInt.dane[i] = int.Parse(Console.ReadLine());
            //}
            //tablicaInt.Wyswietl();
            //Zadanie 5
            //Zadanie5 z5 = new Zadanie5(5);
            //z5.Wyswietl();
            //string path = @"data.bin";
            //BinarySerializer<Zadanie5>.Serialize(path, z5);
            //Zadanie5 z2;
            //z2 = BinarySerializer<Zadanie5>.Deserialize(path);
            //z2.Wyswietl();
            //Zadanie 6
            //Kon k1 = new Kon(1, "kon Rafał", "ogier", "czarny", "nieznany", "klacz", "23-03-2005", "Katowice", "Mikołowska 123 Katowice");

            //k1.PrzedstawSie();
            //k1.Galop();
            //k1.Step();
            //k1.Klus();
            //XmlSerializer xs = new XmlSerializer(typeof(Kon));
            //Stream path = File.Create("kon1.xml");
            //xs.Serialize(path, k1);

            //Kon k2;

            //XmlSerializer xd = new XmlSerializer(typeof(Kon));
            //Stream path1 = File.OpenRead("kon.xml");
            //k2 = (Kon)xd.Deserialize(path1);
            //Console.WriteLine("---------");
            //k2.PrzedstawSie();
            //Zadanie 7

            XmlSerializer serializer = new XmlSerializer(typeof(List<katalog>));

            using (FileStream stream = File.OpenRead("Zadanie_7_serializacja.xml"))
            {
                List<katalog> dezerializedList = (List<katalog>)serializer.Deserialize(stream);
            }






            Console.ReadKey();
        }
    }
}
