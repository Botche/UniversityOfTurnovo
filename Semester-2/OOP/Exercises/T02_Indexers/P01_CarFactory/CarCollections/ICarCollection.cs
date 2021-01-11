namespace P01_CarFactory.CarCollections
{
    using P01_CarFactory.Cars;

    public interface ICarCollection
    {
        public int AddCarToCollection(ICar car);

        ICar this[int index] { get; set; }

        ICar this[string index] { get; }
    }
}
