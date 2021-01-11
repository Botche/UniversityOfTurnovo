namespace P01_CarFactory.Cars
{
    using System;
    using System.Text;

    public class Car : ICar
    {
        private string registrationNumber;
        private string model;

        public Car(string registrationNumber, string model)
        {
            this.registrationNumber = registrationNumber;
            this.model = model;
        }

        public string RegistrationNumber 
        { 
            get => this.registrationNumber;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Registration number cannot be null or empty!");
                }

                this.registrationNumber = value;
            }
        }

        public string Model 
        { 
            get => this.model;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Model cannot be null or empty!");
                }

                this.model = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Car with registration number '{this.RegistrationNumber}' and model '{this.Model}'");

            return sb.ToString().TrimEnd();
        }
    }
}
