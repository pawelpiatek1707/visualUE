using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_tutorial
{
    public class Person
    {
        public String FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
                //FullName jest wymagane żeby wyświetlić w comboboxie imie i nazwisko
                //ponieważ możemy bindowac tylko po jednym elemencie a nie możemy podać 
                //bindowania po dówch elementach
            }
        }
    }
}
