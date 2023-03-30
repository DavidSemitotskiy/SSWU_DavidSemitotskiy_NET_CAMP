namespace exercise_4
{
    public class Program
    {
        public static void Main()
        {
            string separator = new string('_', 30);
            Console.WriteLine(separator);
            var valueTensor = new Tensor<int>(new TensorInfo<int>(1));
            valueTensor.Value = 456;
            Console.WriteLine(valueTensor.GetTensorInfo().IsTensorArray());
            try
            {
                Console.WriteLine(valueTensor.GetTensorInfo().GetLength(2));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine(valueTensor[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(separator);
            var arrTensor = new Tensor<int>(new TensorInfo<int>(2, new int[] { 5 }));
            Console.WriteLine(arrTensor.GetTensorInfo().IsTensorArray());
            try
            {
                Console.WriteLine(arrTensor.Value);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                arrTensor[2, 3] = 5450;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            arrTensor[3] = 43;
            Console.WriteLine(arrTensor);
            Console.WriteLine(separator);
            var matrixTensor = new Tensor<int>(new TensorInfo<int>(3, new int[] { 3, 2 }));
            matrixTensor[2, 0] = 84;
            Console.WriteLine(matrixTensor);
            Console.WriteLine(separator);
        }
    }
}
