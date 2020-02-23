using System;

namespace ModelLib
{
    public class Car
    {

        public string Model { get; set; }
        public string Color { get; set; }
        public int RegistrationNumber { get; set; }

        public override string ToString()
        {
            return Model + " " + Color + " " + RegistrationNumber;
        }
    }
}
