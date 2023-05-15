namespace exercise_1
{
    //інтерфейс для створення об'єднаних перехресть
    public interface ICrossroadsFactory
    {
        IEnumerable<Crossroad> CreateLinkedCrossroads();
    }
}