namespace exercise_1
{
    public class MatrixValidator
    {
        public (bool isSuccess, string message) IsValidMatrix(int[,] matrix)
        {
            if (matrix == null)
            {
                return (false, "Matrix can't be null");
            }

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            if (rows < 2 || columns < 2)
            {
                return (false, "Matrix is required");
            }

            if (rows != columns)
            {
                return (false, "Square matrix is required");
            }

            return (true, string.Empty);
        }
    }
}
