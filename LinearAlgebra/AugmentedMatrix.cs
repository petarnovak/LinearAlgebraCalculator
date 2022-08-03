using System;
using System.Collections.Generic;
using System.Text;

namespace LinearAlgebra
{
    /// <summary>
    /// Class <c>AugmentedMatrix</c> models an augmented matrix of the matrices given in the constructor.
    /// In linear algebra, an augmented matrix is a matrix obtained by appending the columns of two given matrices,
    /// usually for the purpose of performing the same elementary row operations on each of the given matrices.
    /// </summary>
    public class AugmentedMatrix
    {
        private Matrix leftMatrix;
        private Matrix rightMatrix;
        public int NumOfRows { get => leftMatrix.NumOfRows; }
        public int NumOfColumns { get => leftMatrix.NumOfColumns + rightMatrix.NumOfColumns; }
        public Matrix LeftMatrix { get => leftMatrix; }
        public Matrix RightMatrix { get => rightMatrix; }
        public AugmentedMatrix EchelonForm { get => getEchelonForm(); }

        /// <summary>
        /// Creates augmented matrix with the given matrices.
        /// </summary>
        /// <exception cref="ArgumentException">When left and right matrix don't have the same number of rows.</exception>
        public AugmentedMatrix(Matrix leftMatrix, Matrix rightMatrix)
        {
            if(leftMatrix.NumOfRows != rightMatrix.NumOfRows)
            {
                throw new ArgumentException("Left and right matrix must have the same number of rows.");
            }
            else
            {
                this.leftMatrix = leftMatrix;
                this.rightMatrix = rightMatrix;
            }
        }
        private AugmentedMatrix getEchelonForm()
        {
            Matrix leftClone = leftMatrix.Clone;
            Matrix rightClone = rightMatrix.Clone;

            int nextRowWithLeadingCoefficient = 0;
            for (int i = 1; i <= leftClone.NumOfColumns; i++)
            {
                int rowWithNotZero = 0; //the first row with not zero element in column i
                bool notZeroElementFound = false;
                for (int j = nextRowWithLeadingCoefficient + 1; j <= leftClone.NumOfRows; j++)
                {
                    if (!Helper.DoubleEquals(leftClone.GetElementAt(j, i), 0))
                    {
                        rowWithNotZero = j;
                        nextRowWithLeadingCoefficient++;
                        notZeroElementFound = true;
                        break;
                    }
                }
                if (notZeroElementFound)
                {
                    leftClone.swapRows(rowWithNotZero, nextRowWithLeadingCoefficient);
                    rightClone.swapRows(rowWithNotZero, nextRowWithLeadingCoefficient);
                    double scalar1 = 1.0 / leftClone.GetElementAt(nextRowWithLeadingCoefficient, i);
                    leftClone.multiplyRowWithScalar(nextRowWithLeadingCoefficient, scalar1);
                    rightClone.multiplyRowWithScalar(nextRowWithLeadingCoefficient, scalar1);
                    for (int j = 1; j <= leftClone.NumOfRows; j++)
                    {
                        if (j != nextRowWithLeadingCoefficient)
                        {
                            double scalar2 = -1.0 * leftClone.GetElementAt(j, i);
                            leftClone.addRowToRow(nextRowWithLeadingCoefficient, j, scalar2);
                            rightClone.addRowToRow(nextRowWithLeadingCoefficient, j, scalar2);
                        }
                    }
                }

            }


            return new AugmentedMatrix(leftClone, rightClone);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 1; i <= leftMatrix.NumOfRows; i++)
            {
                for (int j = 1; j <= leftMatrix.NumOfColumns; j++)
                {
                    output.Append(String.Format("{0, -8} ", leftMatrix.GetElementAt(i, j).ToString("F3")));
                }
                output.Append(" | ");
                for (int j = 1; j <= rightMatrix.NumOfColumns; j++)
                {
                    output.Append(String.Format("{0, -8} ", rightMatrix.GetElementAt(i, j).ToString("F3")));
                }
                output.Append('\n');
            }
            return output.ToString();
        }
    }
}
