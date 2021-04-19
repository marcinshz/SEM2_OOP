using System;

namespace PD06._02
{
    class MotorVehicle
    {
        private string description;
        private int maxSpeed;

        public MotorVehicle(string description, int maxSpeed)
        {
            this.description = description;
            this.maxSpeed = maxSpeed;
        }


        public string Description
        {
            get
            {
                return description;
            }
        }

        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
        }
    }
    interface IMovable
    {
        void Start();
        void Stop();

    }
    interface ISteerable
    {
        void Left();
        void Right();
    }
    interface IAccelerable
    {
        void Accelerate();
        void SlowDown();
    }
    class Car : MotorVehicle, IMovable, ISteerable, IAccelerable
    {
        private double currentSpeed;
        private bool engineStarted;
        public Car(string description, int maxSpeed) : base(description, maxSpeed)
        {
            currentSpeed = 0;
            engineStarted = false;
        }
        public void Start()
        {
            if (engineStarted == false)
            {
                engineStarted = true;
            }
            else
            {
                Console.WriteLine("Car engine is already working");
            }
        }

        public void Stop()
        {
            currentSpeed = 0;
            engineStarted = false;
        }
        public void Accelerate()
        {
            if (currentSpeed + 10 <= MaxSpeed)
            {
                currentSpeed += 10;
            }
            else if (currentSpeed + 10 > MaxSpeed && currentSpeed < MaxSpeed)
            {
                currentSpeed = MaxSpeed;
            }
            else
            {
                Console.WriteLine("Max speed!");
            }
        }

        public void SlowDown()
        {
            if (currentSpeed + 10 >= 0)
            {
                currentSpeed -= 10;
            }
            else if (currentSpeed + 10 < 0 && currentSpeed > 0)
            {
                currentSpeed = 0;
            }
            else
            {
                Console.WriteLine("Velocity is 0");
            }
        }

        public void Left()
        {
            throw new NotImplementedException();
        }

        public void Right()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Description + ", Max speed: " + MaxSpeed + "Current speed " + currentSpeed;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
