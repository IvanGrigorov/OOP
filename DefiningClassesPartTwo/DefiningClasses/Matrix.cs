/* Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
   Implement an indexer this[row, col] to access the inner matrix cells.
   Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
   Throw an exception when the operation cannot be performed.
   Implement the true operator (check for non-zero elements).*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Matrix<T> where T : IComparable
    {
        #region Fields

        private T[,] matrix;
        private int rowSize;
        private int colSize;

        #endregion

        #region Properties 

        public int Rows
        {
            get { return this.rowSize; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("There can be a matrix with less then one row.");
                }
                this.rowSize = value;
            }
        }

        public int Columns
        {
            get { return this.colSize; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("There can be a matrix with less then one column.");
                }
                this.colSize = value;
            }
        }


        #endregion 

        #region Constructors
        public Matrix(int row, int col) // Default Constructor
        {
            matrix = new T[row, col];
            this.rowSize = row;
            this.colSize = col;
        }
        public Matrix(T[,] fillingMatrix) // Constructor for filling a matrix from array
        {
            this.matrix = new T[fillingMatrix.GetLength(0), fillingMatrix.GetLength(1)];
            for (int i = 0; i < fillingMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < fillingMatrix.GetLength(1); j++)
                {
                    this.matrix[i, j] = fillingMatrix[i, j];
                }
            }
            this.rowSize = fillingMatrix.GetLength(0);
            this.colSize = fillingMatrix.GetLength(1);
        }

        #endregion

        #region CustomIndex
        public T this[int row, int col] // custom index created from 0 to n, where 0 is the first row or first column 
        {
            get { return this.matrix[row, col]; }

            set
            {
                if (row < 0 || row > rowSize
                    || col < 0 || col > colSize)
                {
                    throw new IndexOutOfRangeException("There is no such index");
                }
                this.matrix[row, col] = value;
            }
        }

        #endregion

        #region Operators
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix) // operator for sum of matricies
        { 
            if (firstMatrix.Rows != secondMatrix.Rows ||
                firstMatrix.Columns != secondMatrix.Columns)
            {
                throw new ArgumentException("Different matricies cannot be added");
            }
            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Columns);
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Columns; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j];
                }
            }
            return result;
        }
        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix) // Operator for substracting matricies
        {
            if (firstMatrix.Rows != secondMatrix.Rows ||
                firstMatrix.Columns != secondMatrix.Columns)
            {
                throw new ArgumentException("Different matricies cannot be substracted");
            }
            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Columns);
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Columns; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] - (dynamic)secondMatrix[i, j];
                }
            }
            return result;
        }
        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix) // operator for multiplying matricies
        {
            if (firstMatrix.Columns != secondMatrix.Rows)
            {
                throw new ArgumentException("Different matricies cannot be multiplied");
            }
            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, secondMatrix.Columns);
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Columns; j++)
                {
                    for (int indeks = 0; indeks < firstMatrix.Columns; indeks++)
                    {
                        result[i, j] += (dynamic)firstMatrix[i, indeks] * (dynamic)secondMatrix[indeks, j];
                    }
                }
            }
            return result;
        }
        // Checking for non - zero values in the matrix
        public static bool operator true(Matrix<T> matrix) // True operator, which returns true if there is at least one value
        {                                                  // in the matrix that is not 0
            for (int i = 0; i < matrix.Rows; i++)          // else returns false
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    if ((dynamic)matrix[i, j] != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        // The oposite of the true operator
        public static bool operator false(Matrix<T> matrix) // True operator, which returns false if there is at least one value
        {                                                   // in the matrix that is not 0
            for (int i = 0; i < matrix.Rows; i++)           // else returns true
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    if ((dynamic)matrix[i, j] != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        #endregion

        #region Methods
        public override string ToString() // Displays the whole matrix
        {
            string resultMatrix = string.Empty;
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {
                    resultMatrix += string.Format("{0}", this.matrix[i, j]);
                    resultMatrix += "\t";
                }
                resultMatrix += "\n";
            }
            return resultMatrix;
        }

        #endregion
    }
}
