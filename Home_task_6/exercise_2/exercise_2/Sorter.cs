namespace exercise_2
{
    public static class Sorter
    {
        public static IEnumerable<int> MergeAndSortCollectionsLinq(params IEnumerable<int>[] collections)
        {
            IEnumerable<int> joined = collections.SelectMany(x => x);
            foreach (int item in joined.Order())
            {
                yield return item;
            }
        }

        public static IEnumerable<int> MergeAndSortCollections(params IEnumerable<int>[] collections)
        {
            List<int> joined = collections.SelectMany(x => x).ToList();
            (int value, int index) minResult;
            while (joined.Count != 0)
            {
                minResult = FindMinElement(joined);
                yield return minResult.value;
                joined.RemoveAt(minResult.index);
            }
        }

        private static (int, int) FindMinElement(List<int> collection)
        {
            int min = collection[0];
            int indexMin = 0;
            for (int i = 1; i < collection.Count; i++)
            {
                if (collection[i] < min)
                {
                    min = collection[i];
                    indexMin = i;
                }
            }

            return (min, indexMin);
        }
    }
}