namespace Car
{
    abstract class Car
    {
        //auto-implemented property
        //automatically creates private backing field
        public string Brand { get; }
        public string Model { get; }
        private string registrationNumber;
        public double Velocity { get; protected set; }
        private bool driveModeOn;

        private int averageAcceleration = 4; // m/s^2

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        public Car(string brand, string model, string registrationNumber)
        {
            Brand = brand;
            Model = model;
            RegistrationNumber = registrationNumber;
        }

        public string RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
            set
            {
                registrationNumber = value.Length > 6           //boolean expression
                                     ? value.Substring(0, 6)    //if true
                                     : value;                   //if false
            }
        }

        public void SetRegistrationNumber(string value)
        {
            RegistrationNumber = value;
        }

        public void Accelerate()
        {
            Velocity += 5;
        }

        public abstract void Accelerate(int seconds);

        public void Break()
        {
            if (Velocity >= 10)
                Velocity -= 10;
            else
                Velocity = 0;
        }

    }
}
