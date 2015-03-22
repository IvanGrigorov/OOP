/* Test for the Matrix Class*/


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DefiningClasses
//{
//    class MatrixTest
//    {
//        static void Main() // To run another Main you need to comment this one
//        {                  // and uncomment the one you want to work. There can be only one compiled Main in a programm. 
//            double[,] m1 = new double[,] { { 3, -1, 4 }, { 3, 0, -2 }, { 5, 1, 2 }, { -1, -3, -1 } };
//            double[,] m2 = new double[,] { { -4.5, 8.2, 3.33 }, { 11.4, -5, 1.23 }, { 1, 5.2, 3.6 }, { 0, 0.01, -4.9 } };
//            double[,] m3 = new double[,] { { 1, 1.2 }, { -2.5, 0.4 }, { 6, -1 } };
//            Matrix<double>[] matrixArray = new Matrix<double>[4];
//            matrixArray[0] = new Matrix<double>(m1);
//            matrixArray[1] = new Matrix<double>(m2);
//            matrixArray[2] = new Matrix<double>(m3);
//            matrixArray[3] = new Matrix<double>(4, 3);
//            Matrix<double> sumMatrix = matrixArray[0] + matrixArray[1];
//            Matrix<double> differenceMatrix = matrixArray[0] - matrixArray[1];
//            Matrix<double> productMatrix = matrixArray[0] * matrixArray[2];
//            int i;
//            for (i = 0; i < matrixArray.Length; i++)
//            {
//                Console.WriteLine("Matrix {0}: ", i + 1);
//                Console.WriteLine(matrixArray[i].ToString());
//            }
//            Console.WriteLine("Matrix 1 + Matrix 2: ");
//            Console.WriteLine(sumMatrix.ToString());
//            Console.WriteLine("Matrix 1 - Matrix 2: ");
//            Console.WriteLine(differenceMatrix.ToString());
//            Console.WriteLine("Matrix 1 * Matrix 3: ");
//            Console.WriteLine(productMatrix.ToString());
//            Console.WriteLine(matrixArray[1] ? "Boolean value of Matrix 2: true" : "Boolean value of Matrix 2: false");
//            Console.WriteLine(matrixArray[3] ? "Boolean value of Matrix 4: true" : "Boolean value of Matrix 4: false");
//        }
//    }
//}
