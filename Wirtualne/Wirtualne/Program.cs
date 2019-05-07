using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wirtualne
{
    class Pracownik
    {
        public virtual void Pracuje()
        {
            Console.WriteLine("Pracuje jak kazdy");
        }
    }
    class DyrektorNaczelny:Pracownik
    {
        public  void Pracuje()
        {
            Console.WriteLine("Pracuje jak dyrektor naczelny");
        }
    }
    class DyrektorZwykly:DyrektorNaczelny
    {
        public void Pracuje()
        {
            Console.WriteLine("Pracuje jak dyrektor zwyczajny");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik p1 = new Pracownik();
            p1.Pracuje();
            DyrektorNaczelny d1 = new DyrektorNaczelny();
            d1.Pracuje();
            DyrektorZwykly d2 = new DyrektorZwykly();
            d2.Pracuje();
            Console.ReadKey();
        }
    }
}
