using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors
{
    class Person
    {
        int id;
        string firstName;
        string lastName;
        string adress;
        int age;
        string gender;
        public Person()
        {
            id = 1;
            firstName = "Marcin";
            lastName = "Kowalski";
            age = 18;
            //domyslne wartosci dla nowej osoby
        }

        public Person(int id,string firstName, string lastName, string adress, int age, string gender)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.adress = adress;
            this.age = age;
            this.gender = gender;
            //konnstruktory moga byc przeciążane
        }
        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            adress = "Katowice";
            age = 18;
        }
        public Person(int id, string firstName)
        {
            this.id = id;
            this.firstName = firstName;
        }
    }
}
