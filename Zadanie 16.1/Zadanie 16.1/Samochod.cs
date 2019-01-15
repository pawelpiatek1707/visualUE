using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_16._1
{
    class Samochod
    {
        private string marka;
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private int iloscDrzwi;
        public int IloscDrzwi
        {
            get { return iloscDrzwi; }
            set { iloscDrzwi = value; }
        }
        private double pojemnoscSilnika;
        public double PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = value; }
        }
        private double ObliczSrednieSpalanie(double iloscPaliwa, double iloscKilometrow)
        {
            double srednieSpalanie = iloscPaliwa/iloscKilometrow*100;
            return srednieSpalanie;
        }

        private double Spalanie(double trasa, double iloscPaliwa, double iloscKilometrow)
        {

            double srednieSpalanie = ObliczSrednieSpalanie(iloscPaliwa, iloscKilometrow);
            double srednieSpalanieWynik = srednieSpalanie * trasa/100d;
            return srednieSpalanieWynik;

            
        }
        public double ObliczKosztPrzejazdu(double trasa, double cenaPaliwa, double iloscPaliwa, double iloscKilometrow)
        {
            double spalanie = Spalanie(trasa, iloscPaliwa, iloscKilometrow);
            double spalanieWynik = spalanie * cenaPaliwa;
            return spalanieWynik;
        }

        public void Info(double iloscPaliwa, double iloscKilometrow, double trasa, double cenaPaliwa)
        {
            Console.WriteLine("Unformacje na temat samochodu");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Marka: " + Marka);
            Console.WriteLine("Model: " +Model);
            Console.WriteLine("Ilosć drzwi: "+IloscDrzwi);
            Console.WriteLine("Pojemnosc silnika: "+ PojemnoscSilnika);
            Console.WriteLine("Srednie spalanie: " + ObliczSrednieSpalanie(iloscPaliwa,iloscKilometrow)+"l");
            Console.WriteLine("Spalanie na trasie: "+Spalanie(trasa,iloscPaliwa,iloscKilometrow));
            Console.WriteLine("Koszty przejazdu: {0:c}", ObliczKosztPrzejazdu(trasa,cenaPaliwa,iloscPaliwa,iloscKilometrow));

        }

        public Samochod(string marka1,string model1, int ilosc, double pojemnosc)
        {
            
            marka = marka1;
            model = model1;
            iloscDrzwi = ilosc;
            pojemnoscSilnika = pojemnosc;
        }
     
    }
}