using System.Collections;

namespace exercise_1
{// так і не знайшла використання yield(((. мусимо продискутувати над Вашою реалізацією.
    public class Matrix : IEnumerable<int>
    {
        private int[,] _matrix;

        public Matrix(int[,] matrix)
        {
            MatrixValidator matrixValidator = new MatrixValidator();
            var resultValidation = matrixValidator.IsValidMatrix(matrix);
            if (!resultValidation.isSuccess)
            {
                throw new MatrixException(resultValidation.message);
            }

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            _matrix = new int[rows, columns];
            Array.Copy(matrix, _matrix, matrix.Length);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new DiagonalTreverseEnumerator(_matrix);
        }
    }
}
