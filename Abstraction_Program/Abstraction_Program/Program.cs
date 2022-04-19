using System;

namespace Abstraction_Program
{
    public class Car
    {
        private String _carName = "Alto";
        private String _carColor = "Red";
        public String carName
        {
            set
            {
                _carName = value;
            }
            get
            {
                return _carName;
            }
        }
        public String carColor
        {
            set
            {
                _carColor = value;
            }
            get
            {
                return _carColor;
            }
        }
        public void Speed()
        {
            Console.WriteLine("Speed of the car is excellent");
        }
        public void Gear()
        {
            Console.WriteLine("Gear is working fine");
        }
        static void Main(string[] args)
        {
            Car c = new Car();
            String CarName = c.carName;
            String CarColor = c.carColor;
            Console.WriteLine("My car name is " + CarName);
            Console.WriteLine("My car color is " + CarColor);
            c.Speed();
            c.Gear();
        }
    }
}
