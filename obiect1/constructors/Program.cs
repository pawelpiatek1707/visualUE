﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person2 = new Person(1, "Tomek");
            Person person3 = new Person(2, "Tomek", "Nowak");
            Person person4 = new Person(3, "Tomek", "Nowak", "Katowice", 18, "mezczyzna");
            //utworzono 4 nowe obiekty klasy person i dla każdej osoby wykorzystano inny konstruktor
        }
    }
}
