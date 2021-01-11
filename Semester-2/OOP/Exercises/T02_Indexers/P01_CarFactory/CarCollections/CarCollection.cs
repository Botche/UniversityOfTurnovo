namespace P01_CarFactory.CarCollections
{
    using System;

    using P01_CarFactory.Cars;

    public class CarCollection : ICarCollection
    {
        private readonly ICar[] cars;

        private int currentCount;

        private CarCollection()
        {
            this.currentCount = 0;
        }

        public CarCollection(int count)
            : this()
        {
            this.cars = new ICar[count];
        }

        public CarCollection(ICar[] cars)
            : this()
        {
            this.cars = cars;
        }

        public int AddCarToCollection(ICar car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car), "Cannot add null to collection");
            }

            if (this.currentCount == this.cars.Length)
            {
                throw new ArgumentException("The collection is filled");
            }

            if (!CheckIfModelIsUnique(car.Model) || !CheckIfRegistrationNumberIsUnique(car.RegistrationNumber))
            {
                throw new ArgumentException("Car is not with unique combination from registration number and model.");
            }

            cars[currentCount] = car;
            this.currentCount++;

            return this.currentCount;
        }

        public ICar this[int index]
        {
            get
            {
                if (index < 0 || index >= cars.Length)
                {
                    throw new IndexOutOfRangeException($"Index is not in the collection range! 'Collection range: 0 - {cars.Length - 1}'");
                }

                return cars[index];
            }
            set
            {
                if (index < 0 || index >= cars.Length)
                {
                    throw new IndexOutOfRangeException($"Index is not in the collection range! 'Collection range: 0 - {cars.Length - 1}'");
                }

                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Car should be different from null");
                }

                if (!CheckIfModelIsUnique(value.Model) || !CheckIfRegistrationNumberIsUnique(value.RegistrationNumber))
                {
                    throw new ArgumentException("Car is not with unique combination from registration number and model.");
                }

                cars[index] = value;
            }
        }

        public ICar this[string index]
        {
            get
            {
                ICar carToReturn = null;

                for (int i = 0; i < this.currentCount; i++)
                {
                    ICar car = cars[i];

                    if (car.RegistrationNumber.ToUpper() == index.ToUpper() || car.Model.ToUpper() == index.ToUpper())
                    {
                        carToReturn = car;
                        break;
                    }
                }

                if (carToReturn == null)
                {
                    throw new ArgumentException("Car with this registration number or model does not exists");
                }

                return carToReturn;
            }
        }

        private bool CheckIfModelIsUnique(string model)
        {
            bool isUnique = true;

            for (int i = 0; i < this.currentCount; i++)
            {
                ICar carToCheck = this.cars[i];

                if (carToCheck.Model.ToUpper() == model.ToUpper())
                {
                    isUnique = false;
                    break;
                }
            }

            return isUnique;
        }

        private bool CheckIfRegistrationNumberIsUnique(string registrationNumber)
        {
            bool isUnique = true;

            for (int i = 0; i < this.currentCount; i++)
            {
                ICar carToCheck = this.cars[i];

                if (carToCheck.RegistrationNumber.ToUpper() == registrationNumber.ToUpper())
                {
                    isUnique = false;
                    break;
                }
            }

            return isUnique;
        }
    }
}
