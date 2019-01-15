using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przed_II_Kolosem
{
    class Power
    {
        private int meterId;
        private float begin;
        private float current;

        public void ShowMeterId()
        {
            Console.WriteLine("Numer licznika: "+meterId);
        }
        public void ShowBegin()
        {
            Console.WriteLine("Początkowy stan licznika: "+begin);
        }
        public void ShowCurrent()
        {
            Console.WriteLine("Bieżący stan licznka: "+current);
        }
        public void PowerState()
        {
            float state = current / begin * 30;
            Console.WriteLine("Zużycie energii elektrycznej: "+state);
        }
        public Power(int a,float b,float c)
        {
            meterId = a;
            begin = b;
            current = c;
        }
    }
}
