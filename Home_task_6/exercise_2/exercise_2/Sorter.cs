namespace exercise_2
{
    public class Sorter
    {
        public IEnumerable<int> MergeAndSortCollections(params IEnumerable<int>[] collections)
        {
            IEnumerable<int> joined = collections.SelectMany(x => x);
            foreach (int item in joined.Order())
            {
                yield return item;
            }
        }
    }
}