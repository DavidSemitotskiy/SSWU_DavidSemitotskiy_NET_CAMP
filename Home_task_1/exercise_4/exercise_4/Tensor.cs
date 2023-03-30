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
    }
}
