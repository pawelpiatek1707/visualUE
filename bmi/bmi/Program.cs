using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("| SUPER PROGRAM DO LICZENIA BMI !!! |");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Podaj wage w kilogramach: ");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w metrach: ");
            float height = float.Parse(Console.ReadLine());
            Bmi bmi1 = new Bmi(weight,height);
            Console.Clear();
            float exe1 = bmi1.countBmi();
            Console.WriteLine("-------------------");
            Console.WriteLine("twoje bmi: " + exe1);
            Console.WriteLine("-------------------");
            Console.WriteLine("Jeśli chcesz sprawdzić czy twoje Bmi jest prawidłowe wpisz 'BMI': ");
            string check = Console.ReadLine();
            if(check == "BMI" || check =="bmi")
            {
                Console.Clear();
                bmi1.checkBmi();

            }
            
            Console.ReadKey();
        }
    }
}
