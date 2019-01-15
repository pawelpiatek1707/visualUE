using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przed_II_Kolosem
{
    class Car
    {
        private float power;
        private string model;
        private float speed = 123f;

        public void ShowPower()
        {
            Console.WriteLine("Moc silnika: "+power);
        }
        public void ShowModel()
        {
            Console.WriteLine("Marka samochodu: "+model);
        }
        public void Start()
        {
            Console.WriteLine("Silnik uruchomiony");
        }
        public void Ride()
        {
            Console.WriteLine("Samochód jedzie z prędkością: " + speed+"hm/h");
        }
        public void Stop()
        {
            Console.WriteLine("Samochód zatrzymany");
        }
        public Car(float constructorPower, string constructorModel)
        {
            power = constructorPower;
            model = constructorModel;
        }
    }
}
