using System.Text;

namespace exercise_4
{
    public class TensorInfo<T>
    {
        private int _rank;

        private int[]? _countElementsInEachDimension;

        public TensorInfo(int dimensions, int[]? countElementsInEachDimension = null)
        {
            _rank = dimensions - 1;
            if (_rank < 0)
            {
                throw new ArgumentException("Incorrect number of dimensions");
            }

            if (_rank == 0)
            {
                _countElementsInEachDimension = null;
                return;
            }

            if (countElementsInEachDimension == null)
            {
                throw new Exception("Required count of elements for each dimension");
            }

            if (countElementsInEachDimension.Length != _rank)
            {
                throw new RankException("Incorrect rank for tensor");
            }

            foreach (var countElements in countElementsInEachDimension)
            {
                if (countElements == 0)
                {
                    throw new ArgumentException("Count elements in dimensions can't be 0");
                }
            }

            _countElementsInEachDimension = countElementsInEachDimension;
        }

        public object PrepareTensor()
        {
            if (IsTensorValue())
            {
                return default(T);
            }

            int countAllElements = 1;
            foreach (var countElementsInDimension in _countElementsInEachDimension)
            {
                countAllElements *= countElementsInDimension;
            }

            return new T[countAllElements];
        }

        public int GetLength(int indexDimension)
        {
            if (IsTensorValue())
            {
                throw new RankException("Tensor doesn't have dimensions");
            }

            return _countElementsInEachDimension[indexDimension];
        }

        public int GetRank()
        {
            return _rank;
        }

        public bool IsTensorValue()
        {
            return _rank == 0;
        }

        public bool IsTensorArray()
        {
            return _rank > 0;
        }

        public int CountIndexOffset(params int[] indexes)
        {
            if (IsTensorValue())
            {
                throw new RankException("Tensor isn't array to operate with indexes");
            }

            if (indexes.Length != _rank)
            {
                throw new IndexOutOfRangeException("Incorrect number of dimensions");
            }

            int index = 0;
            int offset = 1;
            for (int i = _countElementsInEachDimension.Length - 1; i >= 0; i--)
            {
                index += indexes[i] * offset;
                offset *= _countElementsInEachDimension[i];
            }

            return index;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Rank - {_rank}");
            for (int i = 0; i < _countElementsInEachDimension.Length; i++)
            {
                stringBuilder.AppendLine($"Dimension {i} - {_countElementsInEachDimension[i]}");
            }

            return stringBuilder.ToString();
        }
    }
}
