using System;
using System.Collections.Generic;
using System.Text;

namespace LinearAlgebra
{
    public class NotQuadraticMatrixException : Exception
    {
        public NotQuadraticMatrixException() : base("Matrix is not quadratic.")
        {
        }

        public NotQuadraticMatrixException(string message) : base(message)
        {
        }
    }
}
