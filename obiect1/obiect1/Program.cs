using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiect1
{
    class Program
    {
        static void Main(string[] args)
        {
            diary diary = new diary();//nowy obiekt klasy diary
            /*diary.addGrader(5);
            diary.addGrader(4.5f);//dodając f zaznaczamy że liczba ma byc floatem
            diary.addGrader(3);
            diary.addGrader(4);
            diary.addGrader(2.5f);

            float avarage1 = diary.average();
            float max1 = diary.takeMax();
            float min1 = diary.takeMin();*/

            for(; ; )
            {
                Console.WriteLine("podaj ocene z zakresu od 2 do 5 jeżeli będziesz chciał skończyć wprowadzanie ocen to wpisz 11 ");


                float grade;
                bool reasult = float.TryParse(Console.ReadLine(),out grade);
               
                

                if(grade == 11)
                {
                    break;
                }
                if(reasult)
                {
                    if (grade > 1 && grade <= 5)
                    {
                        diary.addGrader(grade);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba ");
                    }
                }
                

            }
            float average = diary.average();
            Console.WriteLine("srednia ocen to: " + average);
            if(average >=2.0f && average <= 4.0f)
            {
                Console.WriteLine("Wysokosc stypendium: 0,00zl");
            }
            else if (average >= 4.01f && average <= 4.60f)
            {
                Console.WriteLine("Wysokosc stypendium: 250,00zl");
            }
            else if (average >= 4.61f && average <= 4.80f)
            {
                Console.WriteLine("Wysokosc stypendium: 400,00zl");
            }
            else if (average >= 4.81f && average <= 5.00f)
            {
                Console.WriteLine("Wysokosc stypendium: 550,00zl");
            }
            Console.WriteLine("najwyzsza ocena to: " + diary.takeMax());
            Console.WriteLine("najnizsza ocena to: " + diary.takeMin());
            Console.ReadKey();
        }
    }
}
