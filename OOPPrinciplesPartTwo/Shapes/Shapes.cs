/* Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
   Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
   (height * width for rectangle and height * width/2 for triangle).
   Define class Square and suitable constructor so that at initialization height must be kept equal to width and 
   implement the CalculateSurface() method.
   Write a program that tests the behaviour of the CalculateSurface() method for different shapes 
   (Square, Rectangle, Triangle) stored in an array.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Shapes
    {
        static void Main(string[] args)
        {
            // Test array
            Shape[] figures = new Shape[3];
            figures[0] = new Triangle(4, 5);
            figures[1] = new Rectangle(3, 5);
            figures[2] = new Square(6);

            // Printing the surfaces
            foreach (Shape shape in figures)
            {
                Console.WriteLine("The surface of the figure is {0}", shape.CalculateSurface().ToString());
                Console.WriteLine();
            }
        }
    }
}
