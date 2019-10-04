namespace Car
{
    class Car
    {
        //auto-implemented property
        //automatically creates private backing field
        public string Brand { get; }
        public string Model { get; }
        private string registrationNumber;
        private ushort velocity;
        private bool driveModeOn;


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

        public ushort Velocity { get; }

        public void Accelerate()
        {
            velocity += 5;
        }

        public void Break()
        {
            if (velocity >= 10)
                velocity -= 10;
            else
                velocity = 0;
        }

    }
}
