namespace P01_CarFactory
{
    using System;

    using P01_CarFactory.CarCollections;
    using P01_CarFactory.Cars;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                int countOfCars = int.Parse(Console.ReadLine());

                ICarCollection carCollection = new CarCollection(5);

                for (int i = 0; i < countOfCars; i++)
                {
                    carCollection.AddCarToCollection(new Car($"number: {i}", $"punto{i}"));
                }

                // Errors with countOfCars = 5
                Console.WriteLine(carCollection[6]);
                Console.WriteLine(carCollection[-1]);
                Console.WriteLine(carCollection["number"]);
                carCollection[6] = new Car("number: 1123123", "leon");
                carCollection[-1] = new Car("number: 1123123", "leon");
                carCollection[3] = null;

                // No Errors
                Console.WriteLine(carCollection[3]);
                Console.WriteLine(carCollection["number: 2"]);
                Console.WriteLine(carCollection["punto3"]);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (IndexOutOfRangeException iore)
            {
                Console.WriteLine(iore.Message);
            }
        }
    }
}
