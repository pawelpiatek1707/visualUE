using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Przed_egzaminem_II_2
{
    /*
     * 1. Readonly
     * 2. Serializacja 
     * */

    //1. Readonly
    class ReadonlyVsConst
    {
        public const int Stala = 10;
        public readonly int Readonly = 10;

        public void Zmien()
        {
            //Readonly = 20; - wystąpi błąd
        }
        public ReadonlyVsConst()
        {
            Readonly = 10; //możemy przypisać wartośc dla readonly w momencie tworzenia danej klasy
        }
    }
    //2.Serializacja 
    /* - Serializacja XML wymaga dołączenia dodatkowych przestrzeni nazw : System.Xml, System.Sml.Serialization
     * - Serializacja binarana też wymaga dołączenia dodatkowych przestrzeni nazw: System.Runtime.Serialization, 
     *      System.Runtime.Serialization.Formater.Binary
     *  - Przy serializacji Xml korzystamy z gotowej klasy XmlSerialization i za pomocą niej tworzymy obiekt dzięki któremu możemy 
     *          podać serializacji i deserializaji inny obiekt, 
     *          -> Wymaga to dodania doodatkowych przestrzeni nazw do obsługi plików i strumieni (System.IO)
     *          -> Wymagane jest tez dodanie nagłóówka [Serializable] przed definicja klasy która będziemy chcieli serializować 
     *          -> Do serializacji i deserializacji wymagany jest domyślny konstruktor bez parametrów 
     *          -> należy pamiętać żeby klasa była publiczne (wymagane) oraz żeby pola klasy klasy które chcemy zserializowac 
     *              też były publiczne, ponieważ w innym przypadku nasza zserializowana klasa będzie pusta
     *  - Przy serializacji i deserializacji binarner tworzymy nowy statyczny typ generyczny (klase) z metodami do Serializacji 
     *          i deserializacji
     *     
     * */
    static class BinarySerialization<T>
    {
        public static void Serialize(string path, T obj)
        {
            if (obj != null)
            {
                FileStream fs = File.Create(path);
                var bf = new BinaryFormatter();
                bf.Serialize(fs, obj);
            }
        }
        public static T Deserialize(string path)
        {
            T temp = default(T); //tworzymy zmienna z domyślnym typem dla T
            if (File.Exists(path)) //jeżeli plik istnieje to 
            {
                FileStream fs = File.OpenRead(path); //tworzymy strumień do odczytu z podanej ścieżki

                if (fs.Length > 0) //jeżeli jest jeszcze co odczytać z pliku 
                {
                    var bf = new BinaryFormatter();
                    return (T)bf.Deserialize(fs); //zwraccamy zdeserializowany obiekt który jest rzutowany na typ naszej klasy
                }
            }
            return temp;
            
        }
    }
        [Serializable]
        public class KlasaSerializacja
        {
            public int liczba;
            public string slowo;

            public KlasaSerializacja()
            {

            }

            public KlasaSerializacja(int liczba, string slowo) : this()
            {
                this.liczba = liczba;
                this.slowo = slowo;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
            //1.Readonly 
            //Różnice między const i readonly 
            // - wartośc dla const jest przypisywana w trakcie kompilacji
            // - wartość dla readonly jest przypisywana w czasie działanie programu
            // - wartosc dla readonly można zmieniac w konstruktoeze a wartości stałej nie można zmienić nawet w konstruktorze
            // - jest to spowodowane tym że wartość dla readonly jest ustala w momencie dziłanie programu 
            //====================================================
            //2. Serializacja i deserializacja 
            //  - Serializacja i deserializacja XML
            // KlasaSerializacja k1 = new KlasaSerializacja(1, "slowo"); //Tworzymy obiekt który chcemu zserializaować 
            //Stream path = File.Create("obiekt1.xml"); //tworzymy plik do którego chcemy zserializować 
            //XmlSerializer xs = new XmlSerializer(typeof(KlasaSerializacja)); // Tworzym obiekkt za pomocą którego będziemy mogli
            // serializować i zaznaczamy że ma to być typu "klasa"
            //xs.Serialize(path, k1); // serializacja w podane miejsce wybranego obiektu
            //Deserializacja XMl
            //Stream path1 = File.OpenRead("obiekt1.xml");//tworzymy nowy stumień w trybie do odczytu
            //KlasaSerializacja k2; // tworzymy nowy obiekt naszej klasy do którego chcemy deserializowac plik
            // k2 = (KlasaSerializacja)xs.Deserialize(path1); //Wymagane jest rzutowanie typu klasy na obbiekt do deserializacji 

          

                //Serializacja i deserializacja binarna
                //KlasaSerializacja k3 = new KlasaSerializacja(10, "binaran");
                //BinarySerialization<KlasaSerializacja>.Serialize(@"data.bin",k3); // wykorzystanie statycznej metody generycznej
                // z podaniem typu zmiennej jako "klasa"
                //Deserializacja binarna 
                //KlasaSerializacja k4;
                //k4=BinarySerialization<KlasaSerializacja>.Deserialize(@"data.bin");

                
                
                


            }
        }
    
}

