/* Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
   Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
   Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, 
   clearing the list, finding element by its value and ToString().
   Check all input parameters to avoid accessing elements at invalid positions.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class GenericList<T> where T : IComparable
    {
        #region Fields 

        private T[] elements;
        private int index;

        #endregion

        #region CustomIndex
        public T this[int customIndex]
        {
            get
            {
                return this.elements[customIndex];
            }
            set
            {
                this.elements[customIndex] = value;
            }
        }

        #endregion

        #region Properties
        public int Index
        {
            get { return this.index; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The list is already empty.");
                }
                this.index = value;
            }
        }

        public T[] Elements
        {
            get { return this.elements; }
        }

        #endregion

        #region Constructor
        public GenericList(int length)
        {
            this.elements = new T[length];
            this.index = 0;
        }

        #endregion

        #region Methods
        public void Add(T element) // adding element
        {
            AutoGrow(); // first checks if the array needs to be resized 
            this.Elements[this.Index] = element;
            this.Index++;
        }
        public T FindByIndex(int index) // find by index
        {
            if (index < 0 || index >= this.Elements.Length)
            {
                throw new IndexOutOfRangeException("There is no such index in the array");
            }
            return this.Elements[index];
        }
        public void Delete(int index) // delete element
        {
            if (index < 0 || index >= this.Elements.Length)
            {
                throw new IndexOutOfRangeException("There is no such index in the array");
            }
            for (int i = index; i < this.Index; i++)
            {
                this.Elements[i] = this.Elements[i + 1]; // make all elements from index to end be equal to the next one and make the value 
            }                                            // of the last one default
            this.Elements[this.Elements.Length - 1] = default(T);
            this.Index--;
        }
        public void Insert(int index, T element) // insert an element
        {
            if (index < 0 || index >= this.Elements.Length)
            {
                throw new IndexOutOfRangeException("There is no such index in the array");
            }

            AutoGrow(); // first checks if the array needs to be resized

                for (int i = index ; i < this.Index ; i++)
                {
                    this.Elements[i + 1] = this.Elements[i]; // make all the elements from index to end equal to the previous one and make the value
                }                                            // of the element with the specified index equal to the passed value
                this.Elements[index] = element;
                this.Index++;
        }
        public void Clear() // clear the array
        {
            Array.Clear(this.Elements, 0, this.Elements.Length); // clear the array from starting index 0 to the last index
        }
        public int FindByValue(T element) // find element by value (if there are several ones in the array return the first one)
        {
            int index = -1;
            for (int i = 0; i < this.Index; i++)
            {
                if (this.Elements[i].CompareTo(element) == 0) // search the whole array and if there is a match in the values 
                {                                             // returns the index of the element in the array
                    index = i;
                    break;
                }
            }
            return index;
        }
        public override string ToString() // makes a method how to display the array
        {
            return string.Join(",", this.Elements);
        }
        public void AutoGrow() // doubles the size of the array if it is needed and almost full
        {
            if (this.Index == this.Elements.Length - 2) // if the index is almost at the end of array close to the value of it's length
            {
                Array.Resize(ref this.elements, this.Elements.Length * 2); // resize it's length with two times more
            }
        }
        public static T Min<T>(GenericList<T> someList) where T : IComparable // finds the minimum element in the array
        {
            T minElement = someList[0];
            for (int i = 0; i < someList.Index; i++)
            {
                if (minElement.CompareTo(someList[i]) >= 0) // serach the whole array for the minimum element
                {
                    minElement = someList[i];
                }
            }
            return minElement;
        }
        public static T Max<T>(GenericList<T> someList) where T : IComparable // finding the maximum element in the array
        {
            T maxElement = someList[0];
            for (int i = 0; i < someList.Index; i++)
            {
                if (maxElement.CompareTo(someList[i]) <= 0) // search the whole array for the maximum element
                {
                    maxElement = someList[i];
                }
            }
            return maxElement;
        }

        #endregion
    }
}
