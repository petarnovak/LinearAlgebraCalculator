using System;
using System.Collections.Generic;
using System.Text;

namespace LinearAlgebra
{
    public class MatrixNotInvertibileException : Exception
    {
        public MatrixNotInvertibileException() : base("Matrix is not invertibile.")
        {
        }

        public MatrixNotInvertibileException(string message) : base(message)
        {
        }
    }
}
