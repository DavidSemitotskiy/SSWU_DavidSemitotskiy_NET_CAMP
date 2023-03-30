using System.Text;

namespace exercise_4
{
    public class Tensor<T>
    {
        private T[]? _arr;

        private T? _value;

        private TensorInfo<T> _tensorInfo;

        public Tensor(TensorInfo<T> tensorInfo)
        {
            if (tensorInfo == null)
            {
                throw new ArgumentNullException("TensorInfo can't be null");
            }

            _tensorInfo = tensorInfo;
            var tensor = _tensorInfo.PrepareTensor();
            if (tensor is T[] arrayTensor)
            {
                _arr = arrayTensor;
                return;
            }

            _value = (T)tensor;
        }

        public T Value
        {
            get
            {
                if (!_tensorInfo.IsTensorValue())
                {
                    throw new RankException("Tensor isn't value");
                }

                return _value;
            }
            set
            {
                if (!_tensorInfo.IsTensorValue())
                {
                    throw new RankException("Tensor isn't value");
                }

                _value = value;
            }
        }

        public T this[params int[] indexes]
        {
            get
            {
                return _arr[_tensorInfo.CountIndexOffset(indexes)];
            }
            set
            {
                _arr[_tensorInfo.CountIndexOffset(indexes)] = value;
            }
        }

        public TensorInfo<T> GetTensorInfo()
        {
            return _tensorInfo;
        }

        public override string ToString()
        {
            if (_tensorInfo.IsTensorValue())
            {
                return $"Value - {_value}";
            }

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(_tensorInfo.ToString());
            stringBuilder.Append("Data: ");
            foreach (var item in _arr)
            {
                stringBuilder.Append($"{item} ");
            }

            return stringBuilder.ToString();
        }
    }
}
