namespace exercise_1
{
    //інтерфейс для створення паттернів доріг
    public interface IRoadsFactory
    {
        IEnumerable<Road> CreateRoads();
    }
}
