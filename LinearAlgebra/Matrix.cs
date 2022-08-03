using System;
using System.Collections;
using System.Text;

namespace LinearAlgebra
{
    /// <summary>
    /// Class <c>Matrix</c> models a matrix of the dimensions given in the constructor.
    /// </summary>
    public class Matrix
    {
        private int numOfRows;
        private int numOfColumns;
        private double[,] elements;

        /// <summary>
        /// This constructor initializes the new matrix with the given dimensions 
        /// and all elements equaling zero.
        /// </summary>
        /// <exception cref="ArgumentException">When the given dimensions are less or equal 0.</exception>
        /// <param name="numOfRows">Represents number of rows in the matrix.</param>
        /// <param name="numOfColumns">Represents number of columns in the matrix.</param>
        public Matrix(int numOfRows, int numOfColumns)
        {
            if(numOfColumns < 1 || numOfRows < 1)
            {
                throw new ArgumentException("Matrix dimensions must be greater or equal 1.");
            }
            this.numOfRows = numOfRows;
            this.numOfColumns = numOfColumns;
            this.elements = new double[this.numOfRows,this.numOfColumns];
        }

        /// <summary>
        /// This constructor initializes the new matrix with the given dimensions 
        /// and the elements equaling values of the elements parameter.
        /// </summary>
        /// <exception cref="ArgumentException">When the given dimensions are less or equal 0 or when 
        /// dimensions of the elements parameter do not equal the given dimensions.
        /// </exception>
        /// <param name="numOfRows">Represents number of rows in the matrix.</param>
        /// <param name="numOfColumns">Represents number of columns in the matrix.</param>
        /// <param name="elements">Represents the elements of the matrix.</param>
        public Matrix(int numOfRows, int numOfColumns, double[,] elements)
        {
            if (numOfColumns < 1 || numOfRows < 1)
            {
                throw new ArgumentException("Matrix dimensions sholud be greater or equal 1.");
            }
            this.numOfRows = numOfRows;
            this.numOfColumns = numOfColumns;
            SetElements(elements);
        }

        public int NumOfRows { get => numOfRows; }
        public int NumOfColumns { get => numOfColumns; }
        
        /// <returns>Element of the matrix at the given row and column.</returns>
        /// <exception cref="IndexOutOfMatrixException">When the given row or column are outside the matrix.</exception>
        public double GetElementAt(int row, int column)
        {
            try
            {
                return elements[row - 1, column - 1];
            }
            catch (IndexOutOfRangeException)
            {

                throw new IndexOutOfMatrixException();
            }
        }

        /// <summary>Sets the element of the matrix at the given row and column to the given value.</summary>
        /// <exception cref="IndexOutOfMatrixException">When the given row or column are outside the matrix.</exception>
        public void SetElementAt(int row, int column, double element)
        {
            try
            {
                elements[row - 1, column - 1] = element;
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfMatrixException();
            }
        }

        /// <summary>
        /// Sets the elements of the matrix to values of elements parameter.
        /// </summary>
        /// <exception cref="ArgumentException">When dimensions of the elements parameter do not
        /// equal dimensions of the matrix.
        /// </exception>
        public void SetElements(double[,] elements)
        {
            if (elements.Rank != 2)
            {
                throw new ArgumentException("Array must be two-dimensional.");
            }
            else if (elements.GetLength(0) != numOfRows || elements.GetLength(1) != numOfColumns)
            {
                throw new ArgumentException($"Array must be size {numOfRows}x{numOfColumns}.");
            }
            else
            {
                this.elements = new double[this.numOfRows, this.numOfColumns];
                Array.Copy(elements, this.elements, elements.Length);
            }
        }

        public bool IsZeroMatrix
        {
            get
            {
                foreach (double[] row in RowsEnumerator())
                {
                    if (!Helper.IsZeroArray(row)) return false;
                }
                return true;
            }
        }
        public int Rank
        {
            get
            {
                int rank = numOfRows;
                foreach(double[] row in this.EchelonForm.RowsEnumerator())
                {
                    if (Helper.IsZeroArray(row)) rank--;
                }
                return rank;
            }
        }

        private bool isUpperTriangular()
        {
            if (numOfColumns != numOfRows) return false;
            if (numOfColumns == 1) return false;

            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfColumns; j++)
                {
                    if(i < j)
                    {
                        if (!Helper.DoubleEquals(elements[i, j], 0)) return false;
                    }
                }

            }
            return true;
        }

        private bool isDownerTriangular()
        {
            if (numOfColumns != numOfRows) return false;
            if(numOfColumns == 1) return false;
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfColumns; j++)
                {
                    if (i > j)
                    {
                        if (!Helper.DoubleEquals(elements[i, j], 0)) return false;
                    }
                }

            }
            return true;
        }
        public bool IsQuadratic { get => numOfColumns == numOfRows; }
        public bool IsDiagonal { get => isDownerTriangular() && isUpperTriangular() && !IsZeroMatrix;  }
        public bool IsTriangular { get => isDownerTriangular() || isUpperTriangular(); }
        public bool IsUpperTriangular { get => isUpperTriangular(); }
        public bool IsDownerTriangular { get => isDownerTriangular(); }
        /// <returns>
        /// Determinant of the matrix.
        /// </returns>
        /// <exception cref="NotQuadraticMatrixException">If matrix is not quadratic.</exception>
        public double Determinant { get => getDeterminant(); }
        public Matrix EchelonForm { get => getEchelonForm(); }

        /// <returns>
        /// Inverse of the matrix.
        /// </returns>
        /// <exception cref="MatrixNotInvertibileException">If matrix has no inverse.</exception>
        public Matrix Inverse
        {
            get
            {
                if (Helper.DoubleEquals(0, Determinant))
                {
                    throw new MatrixNotInvertibileException();
                }
                AugmentedMatrix am = new AugmentedMatrix(this, Matrix.IdentityMatrix(numOfRows));
                return am.EchelonForm.RightMatrix;
            }
        }

        private double getDeterminant()
        {
            if(numOfColumns != numOfRows)
            {
                throw new NotQuadraticMatrixException();
            }
            if(numOfRows == 1)
            {
                return this.GetElementAt(1, 1);
            }
            if(numOfRows == 2)
            {
                return elements[0, 0] * elements[1, 1] - elements[0, 1] * elements[1, 0];
            }
            if (this.IsTriangular)
            {
                double d = 1;
                for (int i = 0; i < numOfRows; i++)
                {
                    d *= elements[i, i];
                }
                return d;
            }
            int rowWithMostZeros = 1;
            int mostZerosInRow = 0;
            for (int i = 1; i <= numOfRows; i++)
            {
                double[] currentRow = GetRow(i);
                if (Helper.IsZeroArray(currentRow)) return 0;
                int zerosInCurrentRow = Helper.numOfZerosInArray(currentRow);
                if (zerosInCurrentRow > mostZerosInRow)
                {
                    mostZerosInRow = zerosInCurrentRow;
                    rowWithMostZeros = i;
                }
                int twoSameRows = -1;
                foreach(double[] row in RowsEnumerator())
                {
                    if (Helper.DoubleArrayEquals(row, currentRow)) twoSameRows++;
                }
                if (twoSameRows >= 1) return 0;
            }

            int mostZerosInColumn = 0;
            int columnWithMostZeros = 1;
            for (int i = 1; i <= numOfColumns; i++)
            {
                double[] currentColumn = GetColumn(i);
                if (Helper.IsZeroArray(currentColumn)) return 0;
                int zerosInCurrentColumn = Helper.numOfZerosInArray(currentColumn);
                if (zerosInCurrentColumn > mostZerosInRow)
                {
                    mostZerosInColumn = zerosInCurrentColumn;
                    columnWithMostZeros = i;
                }
                int twoSameColumns = -1;
                foreach (double[] column in ColumnsEnumerator())
                {
                    if (Helper.DoubleArrayEquals(column, currentColumn)) twoSameColumns++;
                }
                if (twoSameColumns >= 1) return 0;
            }

            double determinant = 0;
            if(mostZerosInColumn > mostZerosInRow)
            {
                int i = 1;
                foreach (double element in GetColumn(columnWithMostZeros))
                {
                    if(!Helper.DoubleEquals(element, 0))
                    {
                        double sign = (((i + columnWithMostZeros) % 2) == 0) ? 1 : -1;
                        determinant += element * GetMinor(i, columnWithMostZeros).getDeterminant() * sign;
                    }
                    i++;
                }
            }
            else
            {
                int i = 1;
                foreach (double element in GetRow(rowWithMostZeros))
                {
                    if (!Helper.DoubleEquals(element, 0))
                    {
                        double sign = (((i + rowWithMostZeros) % 2) == 0) ? 1 : -1;
                        determinant += element * GetMinor(rowWithMostZeros, i).getDeterminant() * sign;
                    }
                    i++;
                }
            }
            return determinant;
        }

        /// <returns>
        /// Inverse of the matrix.
        /// </returns>
        /// <exception cref="IndexOutOfMatrixException">When the given row or column are outside the matrix.</exception>
        /// <exception cref="ArgumentException">If matrix has only one row.</exception>
        public Matrix GetMinor(int row, int column)
        {
            if(row > numOfRows || row < 1 || column > numOfColumns || column < 1)
            {
                throw new IndexOutOfMatrixException();
            }
            if(numOfColumns == 1 || numOfRows == 1)
            {
                throw new ArgumentException("Matrices with only one row or column don't have minors.");
            }
            Matrix output = new Matrix(numOfRows - 1, numOfColumns - 1);
            for (int i = 0; i < this.numOfRows; i++)
            {
                if (i == row - 1) continue;
                for (int j = 0; j < this.numOfColumns; j++)
                {
                    if (j == column - 1) continue;
                    int rowInMinor = (i > row - 1) ? i - 1 : i;
                    int columnInMinor = (j > column - 1) ? j - 1 : j;
                    output.elements[rowInMinor, columnInMinor] = GetElementAt(i + 1, j + 1);
                }
            }
            return output;
        }

        internal void swapRows(int row1, int row2)
        {
            if (row1 > numOfRows || row1 < 1 || row2 > numOfRows || row2 < 1)
            {
                throw new IndexOutOfMatrixException();
            }
            if (row1 == row2) return;
            for (int i = 0; i < numOfColumns; i++)
            {
                double help = elements[row1 - 1, i];
                elements[row1 - 1, i] = elements[row2 - 1, i];
                elements[row2 - 1, i] = help;
            }
        }

        internal void multiplyRowWithScalar(int row, double scalar)
        {
            if (row > numOfRows || row < 1)
            {
                throw new IndexOutOfMatrixException();
            }
            for (int i = 0; i < numOfColumns; i++)
            {
                elements[row - 1, i] *= scalar;
            }
        }

        internal void addRowToRow(int rowToAdd, int rowToAddTo, double scalar = 1)
        {
            if (rowToAdd > numOfRows || rowToAdd < 1 || rowToAddTo > numOfRows || rowToAddTo < 1)
            {
                throw new IndexOutOfMatrixException();
            }
            double[] addingRow = GetRow(rowToAdd);
            for (int i = 0; i < numOfColumns; i++)
            {
                elements[rowToAddTo - 1, i] += (addingRow[i] * scalar);
            }
        }

        private Matrix getEchelonForm()
        {
            Matrix output = this.Clone;
            int nextRowWithLeadingCoefficient = 0;
            for (int i = 1; i <= numOfColumns; i++)
            {
                int rowWithNotZero = 0; //the first row with not zero element in column i
                bool notZeroElementFound = false;
                for (int j = nextRowWithLeadingCoefficient + 1; j <= numOfRows; j++)
                {
                    if(!Helper.DoubleEquals(output.GetElementAt(j, i), 0))
                    {
                        rowWithNotZero = j;
                        nextRowWithLeadingCoefficient++;
                        notZeroElementFound = true;
                        break;
                    }
                }
                if (notZeroElementFound)
                {
                    output.swapRows(rowWithNotZero, nextRowWithLeadingCoefficient);
                    output.multiplyRowWithScalar(nextRowWithLeadingCoefficient, (1.0 / output.GetElementAt(nextRowWithLeadingCoefficient, i)));
                    for (int j = 1; j <= numOfRows; j++)
                    {
                        if (j != nextRowWithLeadingCoefficient)
                        {
                            output.addRowToRow(nextRowWithLeadingCoefficient, j, -1.0* output.GetElementAt(j,i));
                        }
                    }
                }
                
            }
            return output;
        }

        public Matrix Clone
        { 
            get
            {
                double[,] newElements = new double[numOfRows, numOfColumns];
                Array.Copy(elements, newElements, elements.Length);
                return new Matrix(NumOfRows, numOfColumns, newElements);
            }
        }

        /// <returns>
        /// Double array representing elements of the row.
        /// </returns>
        /// <exception cref="IndexOutOfMatrixException">When the given row is outside the matrix.</exception>
        public double[] GetRow(int index)
        {
            try
            {
                double[] output = new double[numOfColumns];
                for (int i = 0; i < output.Length; i++)
                {
                    output[i] = elements[index - 1, i];
                }
                return output;
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfMatrixException();
            }
        }

        /// <returns>
        /// Double array representing elements of the column.
        /// </returns>
        /// <exception cref="IndexOutOfMatrixException">When the given column is outside the matrix.</exception>
        public double[] GetColumn(int index)
        {
            try
            {
                double[] output = new double[numOfRows];
                for (int i = 0; i < output.Length; i++)
                {
                    output[i] = elements[i, index - 1];
                }
                return output;
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfMatrixException();
            }
        }

        public System.Collections.IEnumerable RowsEnumerator()
        {
            for(int i = 1; i <= numOfRows; i++)
            {
                yield return GetRow(i);
            }
        }

        public System.Collections.IEnumerable ColumnsEnumerator()
        {
            for (int i = 1; i <= numOfColumns; i++)
            {
                yield return GetColumn(i);
            }
        }

        public static Matrix IdentityMatrix(int size)
        {
            Matrix output = new Matrix(size, size);
            for (int i = 0; i < size; i++)
            {
                output.elements[i, i] = 1;
            }
            return output;
        }

        /// <returns>
        /// The result of multiplying the given marix with the given scalar.
        /// </returns>
        public static Matrix MultipyMatrixWithScalar(Matrix matrix, double scalar)
        {
            for (int i = 0; i < matrix.numOfRows; i++)
            {
                for (int j = 0; j < matrix.numOfColumns; j++)
                {
                    matrix.elements[i, j] *= scalar;
                }
            }
            return matrix;
        }

        /// <returns>
        /// The result of adding two given matrices.
        /// </returns>
        /// <exception cref="ArgumentException">When the given matrices can't be added.</exception>
        public static Matrix Add(Matrix matrix1, Matrix matrix2)
        {
            if(matrix1.numOfRows == matrix2.numOfRows && matrix1.numOfColumns == matrix2.numOfColumns)
            {
                Matrix output = new Matrix(matrix1.numOfRows, matrix1.NumOfColumns);
                for (int i = 0; i < output.numOfRows; i++)
                {
                    for (int j = 0; j < output.numOfColumns; j++)
                    {
                        output.elements[i, j] = matrix1.elements[i, j] + matrix2.elements[i, j];
                    }
                }
                return output;
            }
            else
            {
                throw new ArgumentException("You can only add matrices of the same dimensions.");
            }
        }

        /// <returns>
        /// The result of multiplying two given matrices.
        /// </returns>
        /// <exception cref="ArgumentException">When the given matrices can't be multiplied.</exception>
        public static Matrix Multiply(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.numOfColumns == matrix2.numOfRows)
            {
                Matrix output = new Matrix(matrix1.numOfRows, matrix2.NumOfColumns);
                for (int i = 0; i < output.numOfRows; i++)
                {
                    for (int j = 0; j < output.numOfColumns; j++)
                    {
                        double element = 0;
                        for(int k = 0; k < matrix1.numOfColumns; k++)
                        {
                            element += matrix1.elements[i, k] * matrix2.elements[k, j];
                        }
                        output.elements[i, j] = element;
                    }
                }
                return output;
            }
            else
            {
                throw new ArgumentException("Number of columns of the first matrix must be the same" +
                    " as number of rows of the second matrix.");
            }
        }

        public override String ToString()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfColumns; j++)
                {
                    output.Append(String.Format("{0, -8} ", elements[i, j].ToString("F3")));
                }
                output.Append('\n');
            }
            return output.ToString();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Matrix)) return false;
            Matrix matrix = (Matrix) obj;
            if (this.numOfRows == matrix.numOfRows && this.numOfColumns == matrix.numOfColumns)
            {
                for(int i = 0; i < numOfRows; i++)
                {
                    for (int j = 0; j < numOfColumns; j++)
                    {
                        if (!Helper.DoubleEquals(this.elements[i, j], matrix.elements[i, j]))
                            return false;                        
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            int[] hash = new int[numOfRows];
            int i = 0;
            foreach (double[] row in RowsEnumerator())
            {
                hash[i++] = StructuralComparisons.StructuralEqualityComparer.GetHashCode(row);
            }
            return StructuralComparisons.StructuralEqualityComparer.GetHashCode(hash);
        }
    }
}
