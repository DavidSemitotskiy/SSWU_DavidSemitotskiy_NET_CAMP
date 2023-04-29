using System.Collections;

namespace exercise_1
{
    public class DiagonalTreverseEnumerator : IEnumerator<int>
    {
        private int[,] _matrix;

        private int _indexCol = -1;

        private int _indexRow = -1;

        private int _currentElement = 0;

        private int _countRows;

        private int _countColumns;

        public DiagonalTreverseEnumerator(int[,] matrix)
        {
            MatrixValidator matrixValidator = new MatrixValidator();
            var resultValidation = matrixValidator.IsValidMatrix(matrix);
            if (!resultValidation.isSuccess)
            {
                throw new MatrixException(resultValidation.message);
            }

            _matrix = matrix;
            _countRows = _matrix.GetLength(0);
            _countColumns = _matrix.GetLength(1);
        }

        public int Current 
        {
            get
            {
                if (_indexRow == -1 && _indexCol == -1)
                {
                    throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
                }

                return _matrix[_indexRow, _indexCol];
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (_indexRow == -1 && _indexCol == -1)
            {
                _indexRow++;
                _indexCol++;
                _currentElement++;
                return true;
            }

            if (_currentElement < _matrix.Length)
            {
                if ((_indexRow + _indexCol) % 2 != 0)
                {
                    MoveDirection(ref _indexCol, ref _indexRow, _countColumns);
                }
                else
                {
                    MoveDirection(ref _indexRow, ref _indexCol, _countRows);
                }

                _currentElement++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _indexCol = -1;
            _indexRow = -1;
            _currentElement = 0;
        }

        private void MoveDirection(ref int firstIndex, ref int secondIndex, int count)
        {
            if (firstIndex == count - 1)
            {
                secondIndex++;
            }
            else if (secondIndex == 0)
            {
                firstIndex++;
            }
            else
            {
                firstIndex++;
                secondIndex--;
            }
        }
    }
}