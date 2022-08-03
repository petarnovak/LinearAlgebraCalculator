using System;
using System.Collections.Generic;
using System.Text;

namespace LinearAlgebra
{
    public class IndexOutOfMatrixException : Exception
    {
        public IndexOutOfMatrixException() : base("Matrix doesn't contain element with this index.")
        {
        }

        public IndexOutOfMatrixException(string message) : base(message)
        {
        }
    }
}
