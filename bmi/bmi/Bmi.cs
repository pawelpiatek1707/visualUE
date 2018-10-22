using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmi
{
    class Bmi
    {
        
        float weight, height,bmi;
        public Bmi(float weight, float height)
        {
           
            this.weight = weight;
            this.height = height;
           

        }
      

       

       public float countBmi()
        {
             
            return bmi = this.weight / (this.height * this.height);
           
        }
        public void checkBmi()
        {
            if(bmi< 18.5f)
            {
                Console.WriteLine("Masz niedowage: ");
            }
            else if(bmi>=18.5f && bmi < 25)
            {
                Console.WriteLine("Twoje Bmi jest prawidlowe");
            }
            else
            {
                Console.WriteLine("Masz nadwage. Lepiej coś z tym zrob!!!!!!");
            }
        }
    }
}
