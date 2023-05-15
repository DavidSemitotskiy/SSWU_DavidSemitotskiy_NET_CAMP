namespace exercise_1
{
    public static class EnumerableExtensions
    {
        //необхідне для глубокої копії коллекції
        public static IEnumerable<T> Clone<T>(this IEnumerable<T> enumerableToClone) where T : ICloneable
        {
            return enumerableToClone.Select(item => (T)item.Clone());
        }
    }
}