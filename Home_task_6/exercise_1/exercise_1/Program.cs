namespace exercise_1
{
    public class Program
    {
        public static void Main()
        {
            int[,] arr = { { 2, 6, 1 }, { 8, 3, 12 }, { 0, 18, 10 } };
            Matrix matrix = new Matrix(arr);
            foreach (int element in matrix)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
            foreach (int element in matrix)
            {
                Console.Write($"{element} ");
            }
        }
    }
}