﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Car
    {
        private string model;
        private string registrationNumber;
        private ushort velocity;
        private bool driveModeOn;

        public Car(string brand, string model, string registrationNumber)
        {
            Brand = brand;
            this.model = model;
            this.registrationNumber = registrationNumber;
        }

        //auto-implemented property
        //automatically creates private backing field
        public string Brand { get; }

        public string Model
        {
            get
            {
                return model;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
            set
            {
                registrationNumber = value.Length > 7           //boolean expression
                                     ? value.Substring(0, 7)    //if true
                                     : value;                   //if false
            }
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