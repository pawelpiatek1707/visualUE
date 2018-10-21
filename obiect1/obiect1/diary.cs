using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiect1
{
    class diary
    {

        public diary()//konstruktor
        {
            grades = new List<float>();//tworzy nowy obiekt listy
        }
        List<float> grades;//liista ocen


        public void addGrader(float grade)
        {
            grades.Add(grade);
        }

        public float average()
        {
            float sum = 0,avg=0;
            foreach(var grade in grades)
            {
                sum += grade;
            }
            avg = sum / grades.Count;//Count to metoda zliczająca 
            return avg;
        }

        public float takeMax()
        {
            return grades.Max();
        }

        public float takeMin()
        {
            return grades.Min();
        }


    }
}
